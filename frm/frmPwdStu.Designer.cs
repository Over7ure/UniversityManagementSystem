namespace Students
{
    partial class frmPwdStu
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
            curPwd = new Label();
            nowPwd = new Label();
            txtCurPwd = new TextBox();
            txtNowPwd = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(105, 55);
            title.Name = "title";
            title.Size = new Size(88, 25);
            title.TabIndex = 0;
            title.Text = "修改密码";
            // 
            // curPwd
            // 
            curPwd.AutoSize = true;
            curPwd.Location = new Point(47, 136);
            curPwd.Name = "curPwd";
            curPwd.Size = new Size(84, 17);
            curPwd.TabIndex = 1;
            curPwd.Text = "当 前 密 码 ：";
            // 
            // nowPwd
            // 
            nowPwd.AutoSize = true;
            nowPwd.Location = new Point(47, 201);
            nowPwd.Name = "nowPwd";
            nowPwd.Size = new Size(92, 17);
            nowPwd.TabIndex = 2;
            nowPwd.Text = "修改后的密码：";
            // 
            // txtCurPwd
            // 
            txtCurPwd.Location = new Point(141, 133);
            txtCurPwd.Name = "txtCurPwd";
            txtCurPwd.Size = new Size(100, 23);
            txtCurPwd.TabIndex = 3;
            // 
            // txtNowPwd
            // 
            txtNowPwd.Location = new Point(141, 198);
            txtNowPwd.Name = "txtNowPwd";
            txtNowPwd.Size = new Size(100, 23);
            txtNowPwd.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(64, 254);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 5;
            btnOK.Text = "确定";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(145, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmPwdStu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 345);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtNowPwd);
            Controls.Add(txtCurPwd);
            Controls.Add(nowPwd);
            Controls.Add(curPwd);
            Controls.Add(title);
            Name = "frmPwdStu";
            Text = "修改密码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label curPwd;
        private Label nowPwd;
        private TextBox txtCurPwd;
        private TextBox txtNowPwd;
        private Button btnOK;
        private Button btnCancel;
    }
}