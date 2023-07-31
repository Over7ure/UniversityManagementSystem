namespace Students
{
    partial class FrmMaintea
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
            任课情况ToolStripMenuItem = new ToolStripMenuItem();
            课程信息ToolStripMenuItem = new ToolStripMenuItem();
            课程平均成绩ToolStripMenuItem = new ToolStripMenuItem();
            学生成绩录入ToolStripMenuItem = new ToolStripMenuItem();
            laWelcome1 = new Label();
            laUsername = new Label();
            laWelcome2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 学生信息ToolStripMenuItem, 课程信息ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 1;
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
            修改密码ToolStripMenuItem.Size = new Size(180, 22);
            修改密码ToolStripMenuItem.Text = "修改密码";
            修改密码ToolStripMenuItem.Click += 修改密码ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(180, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 学生信息ToolStripMenuItem
            // 
            学生信息ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 个人信息ToolStripMenuItem, 任课情况ToolStripMenuItem });
            学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            学生信息ToolStripMenuItem.Size = new Size(68, 21);
            学生信息ToolStripMenuItem.Text = "教师信息";
            // 
            // 个人信息ToolStripMenuItem
            // 
            个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            个人信息ToolStripMenuItem.Size = new Size(180, 22);
            个人信息ToolStripMenuItem.Text = "个人信息";
            个人信息ToolStripMenuItem.Click += 个人信息ToolStripMenuItem_Click;
            // 
            // 任课情况ToolStripMenuItem
            // 
            任课情况ToolStripMenuItem.Name = "任课情况ToolStripMenuItem";
            任课情况ToolStripMenuItem.Size = new Size(180, 22);
            任课情况ToolStripMenuItem.Text = "任课情况";
            任课情况ToolStripMenuItem.Click += 任课情况ToolStripMenuItem_Click;
            // 
            // 课程信息ToolStripMenuItem
            // 
            课程信息ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 课程平均成绩ToolStripMenuItem, 学生成绩录入ToolStripMenuItem });
            课程信息ToolStripMenuItem.Name = "课程信息ToolStripMenuItem";
            课程信息ToolStripMenuItem.Size = new Size(68, 21);
            课程信息ToolStripMenuItem.Text = "课程信息";
            // 
            // 课程平均成绩ToolStripMenuItem
            // 
            课程平均成绩ToolStripMenuItem.Name = "课程平均成绩ToolStripMenuItem";
            课程平均成绩ToolStripMenuItem.Size = new Size(180, 22);
            课程平均成绩ToolStripMenuItem.Text = "课程平均成绩";
            课程平均成绩ToolStripMenuItem.Click += 课程平均成绩ToolStripMenuItem_Click;
            // 
            // 学生成绩录入ToolStripMenuItem
            // 
            学生成绩录入ToolStripMenuItem.Name = "学生成绩录入ToolStripMenuItem";
            学生成绩录入ToolStripMenuItem.Size = new Size(180, 22);
            学生成绩录入ToolStripMenuItem.Text = "学生成绩录入";
            学生成绩录入ToolStripMenuItem.Click += 学生成绩录入ToolStripMenuItem_Click;
            // 
            // laWelcome1
            // 
            laWelcome1.AutoSize = true;
            laWelcome1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            laWelcome1.Location = new Point(288, 41);
            laWelcome1.Name = "laWelcome1";
            laWelcome1.Size = new Size(202, 25);
            laWelcome1.TabIndex = 3;
            laWelcome1.Text = "欢迎使用教师管理系统";
            // 
            // laUsername
            // 
            laUsername.AutoSize = true;
            laUsername.Location = new Point(496, 87);
            laUsername.Name = "laUsername";
            laUsername.Size = new Size(0, 17);
            laUsername.TabIndex = 6;
            // 
            // laWelcome2
            // 
            laWelcome2.AutoSize = true;
            laWelcome2.Location = new Point(446, 87);
            laWelcome2.Name = "laWelcome2";
            laWelcome2.Size = new Size(44, 17);
            laWelcome2.TabIndex = 5;
            laWelcome2.Text = "你好，";
            // 
            // FrmMaintea
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(laUsername);
            Controls.Add(laWelcome2);
            Controls.Add(laWelcome1);
            Controls.Add(menuStrip1);
            Name = "FrmMaintea";
            Text = "教师管理系统";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 修改密码ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 学生信息ToolStripMenuItem;
        private ToolStripMenuItem 个人信息ToolStripMenuItem;
        private ToolStripMenuItem 任课情况ToolStripMenuItem;
        private ToolStripMenuItem 班级信息ToolStripMenuItem;
        private ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private ToolStripMenuItem 课程信息ToolStripMenuItem;
        private ToolStripMenuItem 教师任课信息ToolStripMenuItem;
        private ToolStripMenuItem 课程平均成绩ToolStripMenuItem;
        private Label laWelcome1;
        private Label laUsername;
        private Label laWelcome2;
        private ToolStripMenuItem 学生成绩录入ToolStripMenuItem;
    }
}