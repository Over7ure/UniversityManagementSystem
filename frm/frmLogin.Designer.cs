namespace Students
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPwd = new TextBox();
            laName = new Label();
            laPwd = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            position = new Label();
            comPosition = new ComboBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(130, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 23);
            txtName.TabIndex = 0;
            // 
            // txtPwd
            // 
            txtPwd.BorderStyle = BorderStyle.FixedSingle;
            txtPwd.Location = new Point(130, 109);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(161, 23);
            txtPwd.TabIndex = 1;
            // 
            // laName
            // 
            laName.AutoSize = true;
            laName.Location = new Point(68, 56);
            laName.Name = "laName";
            laName.Size = new Size(56, 17);
            laName.TabIndex = 2;
            laName.Text = "用户名：";
            // 
            // laPwd
            // 
            laPwd.AutoSize = true;
            laPwd.Location = new Point(68, 109);
            laPwd.Name = "laPwd";
            laPwd.Size = new Size(56, 17);
            laPwd.TabIndex = 3;
            laPwd.Text = "密   码：";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(92, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(65, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "确定";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(194, 210);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "取消";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // position
            // 
            position.AutoSize = true;
            position.Location = new Point(68, 158);
            position.Name = "position";
            position.Size = new Size(56, 17);
            position.TabIndex = 6;
            position.Text = "身   份：";
            // 
            // comPosition
            // 
            comPosition.FormattingEnabled = true;
            comPosition.Items.AddRange(new object[] { "管理员", "教师", "学生" });
            comPosition.Location = new Point(130, 155);
            comPosition.Name = "comPosition";
            comPosition.Size = new Size(161, 25);
            comPosition.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 287);
            Controls.Add(comPosition);
            Controls.Add(position);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(laPwd);
            Controls.Add(laName);
            Controls.Add(txtPwd);
            Controls.Add(txtName);
            Name = "frmLogin";
            Text = "欢迎登陆";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPwd;
        private Label laName;
        private Label laPwd;
        private Button btnLogin;
        private Button btnExit;
        private Label position;
        private ComboBox comPosition;
    }
}