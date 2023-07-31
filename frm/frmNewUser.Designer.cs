namespace Students
{
    partial class frmNewUser
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
            title = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            comPosition = new ComboBox();
            semester = new Label();
            btn = new Button();
            year = new Label();
            txtPwd = new TextBox();
            cancel = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(118, 58);
            title.Name = "title";
            title.Size = new Size(107, 25);
            title.TabIndex = 8;
            title.Text = "添加新用户";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(170, 122);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 125);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 11;
            label1.Text = "用户名：";
            // 
            // comPosition
            // 
            comPosition.FormattingEnabled = true;
            comPosition.Items.AddRange(new object[] { "系统管理员", "校级管理员", "院级管理员", "教师", "学生" });
            comPosition.Location = new Point(170, 200);
            comPosition.Name = "comPosition";
            comPosition.Size = new Size(100, 25);
            comPosition.TabIndex = 10;
            // 
            // semester
            // 
            semester.AutoSize = true;
            semester.Location = new Point(82, 203);
            semester.Name = "semester";
            semester.Size = new Size(56, 17);
            semester.TabIndex = 1;
            semester.Text = "身   份：";
            // 
            // btn
            // 
            btn.Location = new Point(82, 287);
            btn.Name = "btn";
            btn.Size = new Size(87, 31);
            btn.TabIndex = 5;
            btn.Text = "添加";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(82, 164);
            year.Name = "year";
            year.Size = new Size(56, 17);
            year.TabIndex = 0;
            year.Text = "密   码：";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(170, 161);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(100, 23);
            txtPwd.TabIndex = 2;
            // 
            // cancel
            // 
            cancel.Location = new Point(183, 287);
            cancel.Name = "cancel";
            cancel.Size = new Size(87, 31);
            cancel.TabIndex = 11;
            cancel.Text = "退出";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // frmNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 419);
            Controls.Add(btn);
            Controls.Add(comPosition);
            Controls.Add(txtUsername);
            Controls.Add(semester);
            Controls.Add(cancel);
            Controls.Add(label1);
            Controls.Add(txtPwd);
            Controls.Add(year);
            Controls.Add(title);
            Name = "frmNewUser";
            Text = "添加新用户";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox txtUsername;
        private Label label1;
        private ComboBox comPosition;
        private Label semester;
        private Button btn;
        private Label year;
        private TextBox txtPwd;
        private Button cancel;
    }
}