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
    public partial class LevelComplete : Form
    {
        public static string cnstr = ADT_Project_Final.Properties.Settings.Default.cnstr;

        public LevelComplete()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are You Sure? Saved Score Will Be Deleted.!", "Warning", MessageBoxButtons.YesNo);
            if (ans.Equals(DialogResult.Yes))
            {
                btncontinue.Hide();
                lblname.Show();
                txtname.Show();
                btnstart.Show();
            }

            txtname.Focus();
        }

        private void btnhighscore_Click(object sender, EventArgs e)
        {
            panelhighscore.Show();

            high1st.Show();
            high2nd.Show();
            high3rd.Show();
            high4th.Show();
            high5th.Show();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;

            if (!string.IsNullOrEmpty(name))
            {
                level1 l1 = new level1();
                l1.Show();
            }
        }

        private void LevelComplete_Load(object sender, EventArgs e)
        {
            lblname.Hide();
            txtname.Hide();
            btnstart.Hide();

            high1st.Hide();
            high2nd.Hide();
            high3rd.Hide();
            high4th.Hide();
            high5th.Hide();

            panelhighscore.Hide();

            update_HighScore_Display();
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();

            string currentlevel_search = "select level from currentuser";
            SqlCommand current_level_search_cmd = new SqlCommand(currentlevel_search, cn);
            SqlDataReader current = current_level_search_cmd.ExecuteReader();
            current.Read();

            int level = Convert.ToInt32(current["level"]);
            current.Close();

            switch (level)
            {
                case 1:
                    level2 l2 = new level2();
                    l2.Show();
                    this.Hide();
                    break;
                case 2:
                    break;
            }
        }

        public void update_HighScore_Display()
        {
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();

            string highscore_search = "select * from dbo.highscore order by level desc,seconds";
            SqlCommand highscore_cmd = new SqlCommand(highscore_search, cn);
            SqlDataReader highscore = highscore_cmd.ExecuteReader();

            if (highscore.Read())
            {
                string high1ststr = Convert.ToString(highscore["name"]);
                string high1str = "Level : ";
                high1str += Convert.ToString(highscore["level"]);
                high1str += "    Seconds : ";
                high1str += Convert.ToString(highscore["seconds"]);
                high1st.Text = high1ststr;
                label1.Text = high1str;
            }

            if (highscore.Read())
            {
                string high2ndstr = Convert.ToString(highscore["name"]);
                string high2str = "Level : ";
                high2str += Convert.ToString(highscore["level"]);
                high2str += "    Seconds : ";
                high2str += Convert.ToString(highscore["seconds"]);
                high2nd.Text = high2ndstr;
                label2.Text = high2str;
            }

            if (highscore.Read())
            {
                string high3rdstr = Convert.ToString(highscore["name"]);
                string high3str = "Level : ";
                high3str += Convert.ToString(highscore["level"]);
                high3str += "    Seconds : ";
                high3str += Convert.ToString(highscore["seconds"]);
                high3rd.Text = high3rdstr;
                label3.Text = high3str;
            }

            if (highscore.Read())
            {
                string high4thstr = Convert.ToString(highscore["name"]);
                string high4str = "Level : ";
                high4str += Convert.ToString(highscore["level"]);
                high4str += "    Seconds : ";
                high4str += Convert.ToString(highscore["seconds"]);
                high4th.Text = high4thstr;
                label4.Text = high4str;
            }

            if (highscore.Read())
            {
                string high5thstr = Convert.ToString(highscore["name"]);
                string high5str = "Level : ";
                high5str += Convert.ToString(highscore["level"]);
                high5str += "    Seconds : ";
                high5str += Convert.ToString(highscore["seconds"]);
                high5th.Text = high5thstr;
                label5.Text = high5str;
            }

            highscore.Close();
        }

        private void LevelComplete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
