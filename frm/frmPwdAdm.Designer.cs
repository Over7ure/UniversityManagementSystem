namespace Students
{
    partial class frmPwdAdm
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
            btnCancel = new Button();
            btnOK = new Button();
            txtNowPwd = new TextBox();
            txtCurPwd = new TextBox();
            nowPwd = new Label();
            curPwd = new Label();
            title = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(147, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(66, 260);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 12;
            btnOK.Text = "确定";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtNowPwd
            // 
            txtNowPwd.Location = new Point(143, 204);
            txtNowPwd.Name = "txtNowPwd";
            txtNowPwd.Size = new Size(100, 23);
            txtNowPwd.TabIndex = 11;
            // 
            // txtCurPwd
            // 
            txtCurPwd.Location = new Point(143, 139);
            txtCurPwd.Name = "txtCurPwd";
            txtCurPwd.Size = new Size(100, 23);
            txtCurPwd.TabIndex = 10;
            // 
            // nowPwd
            // 
            nowPwd.AutoSize = true;
            nowPwd.Location = new Point(49, 207);
            nowPwd.Name = "nowPwd";
            nowPwd.Size = new Size(92, 17);
            nowPwd.TabIndex = 9;
            nowPwd.Text = "修改后的密码：";
            // 
            // curPwd
            // 
            curPwd.AutoSize = true;
            curPwd.Location = new Point(49, 142);
            curPwd.Name = "curPwd";
            curPwd.Size = new Size(84, 17);
            curPwd.TabIndex = 8;
            curPwd.Text = "当 前 密 码 ：";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(107, 61);
            title.Name = "title";
            title.Size = new Size(88, 25);
            title.TabIndex = 7;
            title.Text = "修改密码";
            // 
            // frmPwdAdm
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
            Name = "frmPwdAdm";
            Text = "修改密码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private TextBox txtNowPwd;
        private TextBox txtCurPwd;
        private Label nowPwd;
        private Label curPwd;
        private Label title;
    }
}