namespace Students
{
    partial class FrmMainadm
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
            注册新用户ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            学校信息ToolStripMenuItem = new ToolStripMenuItem();
            学生信息ToolStripMenuItem = new ToolStripMenuItem();
            班级信息ToolStripMenuItem = new ToolStripMenuItem();
            教师信息ToolStripMenuItem = new ToolStripMenuItem();
            专业信息ToolStripMenuItem = new ToolStripMenuItem();
            学院信息ToolStripMenuItem = new ToolStripMenuItem();
            统计信息ToolStripMenuItem = new ToolStripMenuItem();
            地区学生数ToolStripMenuItem = new ToolStripMenuItem();
            学生成绩统计ToolStripMenuItem = new ToolStripMenuItem();
            laUsername = new Label();
            laWelcome2 = new Label();
            laWelcome1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 学校信息ToolStripMenuItem, 统计信息ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 修改密码ToolStripMenuItem, 注册新用户ToolStripMenuItem, 退出ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 修改密码ToolStripMenuItem
            // 
            修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            修改密码ToolStripMenuItem.Size = new Size(136, 22);
            修改密码ToolStripMenuItem.Text = "修改密码";
            修改密码ToolStripMenuItem.Click += 修改密码ToolStripMenuItem_Click;
            // 
            // 注册新用户ToolStripMenuItem
            // 
            注册新用户ToolStripMenuItem.Name = "注册新用户ToolStripMenuItem";
            注册新用户ToolStripMenuItem.Size = new Size(136, 22);
            注册新用户ToolStripMenuItem.Text = "注册新用户";
            注册新用户ToolStripMenuItem.Click += 注册新用户ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(136, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 学校信息ToolStripMenuItem
            // 
            学校信息ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 学生信息ToolStripMenuItem, 班级信息ToolStripMenuItem, 教师信息ToolStripMenuItem, 专业信息ToolStripMenuItem, 学院信息ToolStripMenuItem });
            学校信息ToolStripMenuItem.Name = "学校信息ToolStripMenuItem";
            学校信息ToolStripMenuItem.Size = new Size(68, 21);
            学校信息ToolStripMenuItem.Text = "学校信息";
            // 
            // 学生信息ToolStripMenuItem
            // 
            学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            学生信息ToolStripMenuItem.Size = new Size(124, 22);
            学生信息ToolStripMenuItem.Text = "学生信息";
            学生信息ToolStripMenuItem.Click += 学生信息ToolStripMenuItem_Click;
            // 
            // 班级信息ToolStripMenuItem
            // 
            班级信息ToolStripMenuItem.Name = "班级信息ToolStripMenuItem";
            班级信息ToolStripMenuItem.Size = new Size(124, 22);
            班级信息ToolStripMenuItem.Text = "班级信息";
            班级信息ToolStripMenuItem.Click += 班级信息ToolStripMenuItem_Click;
            // 
            // 教师信息ToolStripMenuItem
            // 
            教师信息ToolStripMenuItem.Name = "教师信息ToolStripMenuItem";
            教师信息ToolStripMenuItem.Size = new Size(124, 22);
            教师信息ToolStripMenuItem.Text = "教师信息";
            教师信息ToolStripMenuItem.Click += 教师信息ToolStripMenuItem_Click;
            // 
            // 专业信息ToolStripMenuItem
            // 
            专业信息ToolStripMenuItem.Name = "专业信息ToolStripMenuItem";
            专业信息ToolStripMenuItem.Size = new Size(124, 22);
            专业信息ToolStripMenuItem.Text = "专业信息";
            专业信息ToolStripMenuItem.Click += 专业信息ToolStripMenuItem_Click;
            // 
            // 学院信息ToolStripMenuItem
            // 
            学院信息ToolStripMenuItem.Name = "学院信息ToolStripMenuItem";
            学院信息ToolStripMenuItem.Size = new Size(124, 22);
            学院信息ToolStripMenuItem.Text = "学院信息";
            学院信息ToolStripMenuItem.Click += 学院信息ToolStripMenuItem_Click;
            // 
            // 统计信息ToolStripMenuItem
            // 
            统计信息ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 地区学生数ToolStripMenuItem, 学生成绩统计ToolStripMenuItem });
            统计信息ToolStripMenuItem.Name = "统计信息ToolStripMenuItem";
            统计信息ToolStripMenuItem.Size = new Size(68, 21);
            统计信息ToolStripMenuItem.Text = "统计信息";
            // 
            // 地区学生数ToolStripMenuItem
            // 
            地区学生数ToolStripMenuItem.Name = "地区学生数ToolStripMenuItem";
            地区学生数ToolStripMenuItem.Size = new Size(180, 22);
            地区学生数ToolStripMenuItem.Text = "地区学生数";
            地区学生数ToolStripMenuItem.Click += 地区学生数ToolStripMenuItem_Click;
            // 
            // 学生成绩统计ToolStripMenuItem
            // 
            学生成绩统计ToolStripMenuItem.Name = "学生成绩统计ToolStripMenuItem";
            学生成绩统计ToolStripMenuItem.Size = new Size(180, 22);
            学生成绩统计ToolStripMenuItem.Text = "学生成绩统计";
            学生成绩统计ToolStripMenuItem.Click += 学生成绩统计ToolStripMenuItem_Click;
            // 
            // laUsername
            // 
            laUsername.AutoSize = true;
            laUsername.Location = new Point(491, 92);
            laUsername.Name = "laUsername";
            laUsername.Size = new Size(0, 17);
            laUsername.TabIndex = 7;
            // 
            // laWelcome2
            // 
            laWelcome2.AutoSize = true;
            laWelcome2.Location = new Point(441, 92);
            laWelcome2.Name = "laWelcome2";
            laWelcome2.Size = new Size(44, 17);
            laWelcome2.TabIndex = 6;
            laWelcome2.Text = "你好，";
            // 
            // laWelcome1
            // 
            laWelcome1.AutoSize = true;
            laWelcome1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            laWelcome1.Location = new Point(289, 47);
            laWelcome1.Name = "laWelcome1";
            laWelcome1.Size = new Size(164, 25);
            laWelcome1.TabIndex = 5;
            laWelcome1.Text = "欢迎使用管理系统";
            // 
            // FrmMainadm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(laUsername);
            Controls.Add(laWelcome2);
            Controls.Add(laWelcome1);
            Controls.Add(menuStrip1);
            Name = "FrmMainadm";
            Text = "管理系统";
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
        private ToolStripMenuItem 学校信息ToolStripMenuItem;
        private ToolStripMenuItem 学生信息ToolStripMenuItem;
        private ToolStripMenuItem 班级信息ToolStripMenuItem;
        private ToolStripMenuItem 专业信息ToolStripMenuItem;
        private ToolStripMenuItem 学院信息ToolStripMenuItem;
        private ToolStripMenuItem 统计信息ToolStripMenuItem;
        private ToolStripMenuItem 地区学生数ToolStripMenuItem;
        private ToolStripMenuItem 学生成绩统计ToolStripMenuItem;
        private Label laUsername;
        private Label laWelcome2;
        private Label laWelcome1;
        private ToolStripMenuItem 教师信息ToolStripMenuItem;
        private ToolStripMenuItem 注册新用户ToolStripMenuItem;
    }
}