using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADT_Project_Final
{
    public partial class level1 : Form 
    {
        public string cnstr = ADT_Project_Final.Properties.Settings.Default.cnstr;
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        
        double counter, seconds;

        public level1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point StartingPoint = panel1.Location;
            StartingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(StartingPoint);
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void labelfinish_MouseEnter(object sender, EventArgs e)
        {
            timer.Enabled = false;
            seconds = counter / 100;

            finishSoundPlayer.Play();
            MessageBox.Show("Your Score : " + seconds + " Seconds !");

            update_currentuser_Database();
            update_highscore_Database();

            LevelComplete lc = new LevelComplete();
            lc.Show();
            this.Hide();
            
        }

        private void level1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            counter = 0;
        }

        private void level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
        }

        void update_currentuser_Database()
        {
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();

            string currentuser_query = "update currentuser set level=1, seconds=@sec";
            SqlCommand currentuser_cmd = new SqlCommand(currentuser_query, cn);
            currentuser_cmd.Parameters.AddWithValue("@sec", seconds);
            currentuser_cmd.ExecuteNonQuery();

            cn.Close(); //
        }

        void update_highscore_Database()
        {
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();

            string search_currentuser = "select * from dbo.currentuser";
            SqlCommand search_currentuser_cmd = new SqlCommand(search_currentuser, cn);
            SqlDataReader currentuser = search_currentuser_cmd.ExecuteReader();
            currentuser.Read();
            string cu_name = Convert.ToString(currentuser["name"]);
            int cu_level = Convert.ToInt32(currentuser["level"]);
            double cu_sec = Convert.ToDouble(currentuser["seconds"]);
            currentuser.Close(); //

            string search_highscore_count = "select count(id) count from dbo.highscore";
            SqlCommand search_highscore_count_cmd = new SqlCommand(search_highscore_count, cn);
            SqlDataReader highscore_count = search_highscore_count_cmd.ExecuteReader();
            highscore_count.Read();
            int highscoreCount = Convert.ToInt32(highscore_count["count"]);
            highscore_count.Close(); //

            if (highscoreCount == 5)
            {
                string search_highscore_desc = "select * from dbo.highscore order by level desc,seconds";
                SqlCommand search_highscore_desc_cmd = new SqlCommand(search_highscore_desc, cn);
                SqlDataReader highscore_desc = search_highscore_desc_cmd.ExecuteReader();

                while (highscore_desc.Read())
                {
                    int hs_level = Convert.ToInt32(highscore_desc["level"]);
                    

                    if (hs_level < cu_level)
                    {
                        highscore_desc.Close(); //

                        string insert_highscore = "insert into dbo.highscore values(@name,@level,@seconds)";
                        SqlCommand insert_highscore_cmd = new SqlCommand(insert_highscore, cn);
                        insert_highscore_cmd.Parameters.AddWithValue("@name", cu_name);
                        insert_highscore_cmd.Parameters.AddWithValue("@level", cu_level);
                        insert_highscore_cmd.Parameters.AddWithValue("@seconds", cu_sec);

                        insert_highscore_cmd.ExecuteNonQuery();

                        break;
                    }
                    else if (hs_level == cu_level)
                    {
                        double hs_sec = Convert.ToDouble(highscore_desc["seconds"]);
                        
                        if (cu_sec < hs_sec)
                        {
                            highscore_desc.Close(); //

                            string insert_highscore = "insert into dbo.highscore values(@name,@level,@seconds)";
                            SqlCommand insert_highscore_cmd = new SqlCommand(insert_highscore, cn);
                            insert_highscore_cmd.Parameters.AddWithValue("@name", cu_name);
                            insert_highscore_cmd.Parameters.AddWithValue("@level", cu_level);
                            insert_highscore_cmd.Parameters.AddWithValue("@seconds", cu_sec );

                            insert_highscore_cmd.ExecuteNonQuery();

                            break;
                        }
                    }
                }

                highscore_desc.Close(); //

                string search_highscore_asc = "select * from dbo.highscore order by level,seconds desc";
                SqlCommand search_highscore_asc_cmd = new SqlCommand(search_highscore_asc, cn);
                SqlDataReader highscore_asc = search_highscore_asc_cmd.ExecuteReader();
                highscore_asc.Read();

                int del_id = Convert.ToInt32(highscore_asc["id"]);
                highscore_asc.Close();

                string delete_lowest = "delete from dbo.highscore where id=@id";
                SqlCommand delete_lowest_cmd = new SqlCommand(delete_lowest, cn);
                delete_lowest_cmd.Parameters.AddWithValue("@id", del_id);
                delete_lowest_cmd.ExecuteNonQuery();
            }
            else
            {
                string insert_highscore = "insert into dbo.highscore values(@name,@level,@seconds)";
                SqlCommand insert_highscore_cmd = new SqlCommand(insert_highscore, cn);
                insert_highscore_cmd.Parameters.AddWithValue("@name", cu_name);
                insert_highscore_cmd.Parameters.AddWithValue("@level", cu_level);
                insert_highscore_cmd.Parameters.AddWithValue("@seconds", cu_sec);

                insert_highscore_cmd.ExecuteNonQuery();
            }

            cn.Close(); // 
        }
    }
}
