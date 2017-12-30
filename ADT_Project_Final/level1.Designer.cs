namespace ADT_Project_Final
{
    partial class level1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelfinish = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape12 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape13 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape14 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape15 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelfinish);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 328);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // labelfinish
            // 
            this.labelfinish.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelfinish.Location = new System.Drawing.Point(345, 263);
            this.labelfinish.Name = "labelfinish";
            this.labelfinish.Padding = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.labelfinish.Size = new System.Drawing.Size(86, 58);
            this.labelfinish.TabIndex = 1;
            this.labelfinish.Text = "Finish";
            this.labelfinish.MouseEnter += new System.EventHandler(this.labelfinish_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.highScoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // highScoreToolStripMenuItem
            // 
            this.highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
            this.highScoreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.highScoreToolStripMenuItem.Text = "High Score";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 25;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 129;
            this.lineShape1.X2 = 128;
            this.lineShape1.Y1 = 25;
            this.lineShape1.Y2 = 70;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(429, 347);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape15,
            this.lineShape14,
            this.lineShape13,
            this.lineShape12,
            this.lineShape11,
            this.lineShape10,
            this.lineShape9,
            this.lineShape8,
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(425, 324);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape2.BorderWidth = 25;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 134;
            this.lineShape2.X2 = 134;
            this.lineShape2.Y1 = 0;
            this.lineShape2.Y2 = 80;
            this.lineShape2.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape3.BorderWidth = 25;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 57;
            this.lineShape3.X2 = 57;
            this.lineShape3.Y1 = 40;
            this.lineShape3.Y2 = 120;
            this.lineShape3.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape4.BorderWidth = 25;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 45;
            this.lineShape4.X2 = 223;
            this.lineShape4.Y1 = 131;
            this.lineShape4.Y2 = 131;
            this.lineShape4.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape5.BorderWidth = 25;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 212;
            this.lineShape5.X2 = 212;
            this.lineShape5.Y1 = 40;
            this.lineShape5.Y2 = 205;
            this.lineShape5.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape6.BorderWidth = 25;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 223;
            this.lineShape6.X2 = 283;
            this.lineShape6.Y1 = 193;
            this.lineShape6.Y2 = 193;
            this.lineShape6.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape7.BorderWidth = 25;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 270;
            this.lineShape7.X2 = 270;
            this.lineShape7.Y1 = 204;
            this.lineShape7.Y2 = 264;
            this.lineShape7.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape8.BorderWidth = 25;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 0;
            this.lineShape8.X2 = 146;
            this.lineShape8.Y1 = 191;
            this.lineShape8.Y2 = 192;
            this.lineShape8.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape9
            // 
            this.lineShape9.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape9.BorderWidth = 25;
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = 133;
            this.lineShape9.X2 = 133;
            this.lineShape9.Y1 = 200;
            this.lineShape9.Y2 = 230;
            this.lineShape9.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape10
            // 
            this.lineShape10.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape10.BorderWidth = 25;
            this.lineShape10.Name = "lineShape10";
            this.lineShape10.X1 = 40;
            this.lineShape10.X2 = 344;
            this.lineShape10.Y1 = 274;
            this.lineShape10.Y2 = 274;
            this.lineShape10.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape11
            // 
            this.lineShape11.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape11.BorderWidth = 25;
            this.lineShape11.Name = "lineShape11";
            this.lineShape11.X1 = 282;
            this.lineShape11.X2 = 342;
            this.lineShape11.Y1 = 131;
            this.lineShape11.Y2 = 131;
            this.lineShape11.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape12
            // 
            this.lineShape12.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape12.BorderWidth = 25;
            this.lineShape12.Name = "lineShape12";
            this.lineShape12.X1 = 353;
            this.lineShape12.X2 = 353;
            this.lineShape12.Y1 = 119;
            this.lineShape12.Y2 = 205;
            this.lineShape12.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape13
            // 
            this.lineShape13.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape13.BorderWidth = 25;
            this.lineShape13.Name = "lineShape13";
            this.lineShape13.X1 = 364;
            this.lineShape13.X2 = 427;
            this.lineShape13.Y1 = 192;
            this.lineShape13.Y2 = 192;
            this.lineShape13.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape14
            // 
            this.lineShape14.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape14.BorderWidth = 25;
            this.lineShape14.Name = "lineShape14";
            this.lineShape14.X1 = 294;
            this.lineShape14.X2 = 294;
            this.lineShape14.Y1 = 58;
            this.lineShape14.Y2 = 142;
            this.lineShape14.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // lineShape15
            // 
            this.lineShape15.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape15.BorderWidth = 25;
            this.lineShape15.Name = "lineShape15";
            this.lineShape15.X1 = 305;
            this.lineShape15.X2 = 365;
            this.lineShape15.Y1 = 71;
            this.lineShape15.Y2 = 71;
            this.lineShape15.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 347);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer2);
            this.Name = "level1";
            this.Text = "level1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.level1_FormClosing);
            this.Load += new System.EventHandler(this.level1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelfinish;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape15;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape14;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape13;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape12;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape11;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}