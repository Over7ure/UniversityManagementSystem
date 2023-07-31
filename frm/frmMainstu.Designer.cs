namespace Students
{
    partial class FrmMainstu
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
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            修改密码ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            学生信息ToolStripMenuItem = new ToolStripMenuItem();
            个人信息ToolStripMenuItem = new ToolStripMenuItem();
            班级信息ToolStripMenuItem = new ToolStripMenuItem();
            班级开课信息ToolStripMenuItem = new ToolStripMenuItem();
            成绩查询ToolStripMenuItem = new ToolStripMenuItem();
            课程信息ToolStripMenuItem = new ToolStripMenuItem();
            教师任课信息ToolStripMenuItem = new ToolStripMenuItem();
            选课ToolStripMenuItem = new ToolStripMenuItem();
            laWelcome1 = new Label();
            laWelcome2 = new Label();
            laUsername = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 学生信息ToolStripMenuItem, 课程信息ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 修改密码ToolStripMenuItem, 退出ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 修改密码ToolStripMenuItem
            // 
            修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            修改密码ToolStripMenuItem.Size = new Size(124, 22);
            修改密码ToolStripMenuItem.Text = "修改密码";
            修改密码ToolStripMenuItem.Click += 修改密码ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(124, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 学生信息ToolStripMenuItem
            // 
            学生信息ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 个人信息ToolStripMenuItem, 班级信息ToolStripMenuItem, 班级开课信息ToolStripMenuItem, 成绩查询ToolStripMenuItem });
            学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            学生信息ToolStripMenuItem.Size = new Size(68, 21);
            学生信息ToolStripMenuItem.Text = "学生信息";
            // 
            // 个人信息ToolStripMenuItem
            // 
            个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            个人信息ToolStripMenuItem.Size = new Size(148, 22);
            个人信息ToolStripMenuItem.Text = "个人信息";
            个人信息ToolStripMenuItem.Click += 个人信息ToolStripMenuItem_Click;
            // 
            // 班级信息ToolStripMenuItem
            // 
            班级信息ToolStripMenuItem.Name = "班级信息ToolStripMenuItem";
            班级信息ToolStripMenuItem.Size = new Size(148, 22);
            班级信息ToolStripMenuItem.Text = "班级信息";
            班级信息ToolStripMenuItem.Click += 班级信息ToolStripMenuItem_Click;
            // 
            // 班级开课信息ToolStripMenuItem
            // 
            班级开课信息ToolStripMenuItem.Name = "班级开课信息ToolStripMenuItem";
            班级开课信息ToolStripMenuItem.Size = new Size(148, 22);
            班级开课信息ToolStripMenuItem.Text = "班级开课信息";
            班级开课信息ToolStripMenuItem.Click += 班级开课信息ToolStripMenuItem_Click_1;
            // 
            // 成绩查询ToolStripMenuItem
            // 
            成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            成绩查询ToolStripMenuItem.Size = new Size(148, 22);
            成绩查询ToolStripMenuItem.Text = "成绩查询";
            成绩查询ToolStripMenuItem.Click += 成绩查询ToolStripMenuItem_Click;
            // 
            // 课程信息ToolStripMenuItem
            // 
            课程信息ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 教师任课信息ToolStripMenuItem, 选课ToolStripMenuItem });
            课程信息ToolStripMenuItem.Name = "课程信息ToolStripMenuItem";
            课程信息ToolStripMenuItem.Size = new Size(68, 21);
            课程信息ToolStripMenuItem.Text = "课程信息";
            // 
            // 教师任课信息ToolStripMenuItem
            // 
            教师任课信息ToolStripMenuItem.Name = "教师任课信息ToolStripMenuItem";
            教师任课信息ToolStripMenuItem.Size = new Size(180, 22);
            教师任课信息ToolStripMenuItem.Text = "教师任课信息";
            教师任课信息ToolStripMenuItem.Click += 教师任课信息ToolStripMenuItem_Click;
            // 
            // 选课ToolStripMenuItem
            // 
            选课ToolStripMenuItem.Name = "选课ToolStripMenuItem";
            选课ToolStripMenuItem.Size = new Size(180, 22);
            选课ToolStripMenuItem.Text = "选课";
            选课ToolStripMenuItem.Click += 选课ToolStripMenuItem_Click;
            // 
            // laWelcome1
            // 
            laWelcome1.AutoSize = true;
            laWelcome1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            laWelcome1.Location = new Point(306, 40);
            laWelcome1.Name = "laWelcome1";
            laWelcome1.Size = new Size(202, 25);
            laWelcome1.TabIndex = 2;
            laWelcome1.Text = "欢迎使用学生管理系统";
            // 
            // laWelcome2
            // 
            laWelcome2.AutoSize = true;
            laWelcome2.Location = new Point(458, 85);
            laWelcome2.Name = "laWelcome2";
            laWelcome2.Size = new Size(44, 17);
            laWelcome2.TabIndex = 3;
            laWelcome2.Text = "你好，";
            // 
            // laUsername
            // 
            laUsername.AutoSize = true;
            laUsername.Location = new Point(508, 85);
            laUsername.Name = "laUsername";
            laUsername.Size = new Size(0, 17);
            laUsername.TabIndex = 4;
            // 
            // FrmMainstu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(laUsername);
            Controls.Add(laWelcome2);
            Controls.Add(laWelcome1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMainstu";
            Text = "学生管理系统";
            Load += FrmMainstu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 学生信息ToolStripMenuItem;
        private ToolStripMenuItem 个人信息ToolStripMenuItem;
        private ToolStripMenuItem 班级信息ToolStripMenuItem;
        private ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private ToolStripMenuItem 课程信息ToolStripMenuItem;
        private ToolStripMenuItem 教师任课信息ToolStripMenuItem;
        private ToolStripMenuItem 修改密码ToolStripMenuItem;
        private ToolStripMenuItem 选课ToolStripMenuItem;
        private Label laWelcome1;
        private Label laWelcome2;
        private Label laUsername;
        private ToolStripMenuItem 班级开课信息ToolStripMenuItem;
    }
}