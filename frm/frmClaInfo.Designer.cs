namespace Students
{
    partial class frmClaInfo
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
            dataGView = new DataGridView();
            Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGView).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(220, 50);
            title.Name = "title";
            title.Size = new Size(126, 25);
            title.TabIndex = 2;
            title.Text = "我的班级信息";
            // 
            // dataGView
            // 
            dataGView.AllowUserToAddRows = false;
            dataGView.AllowUserToDeleteRows = false;
            dataGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView.Location = new Point(12, 124);
            dataGView.Name = "dataGView";
            dataGView.ReadOnly = true;
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(549, 198);
            dataGView.TabIndex = 3;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(373, 361);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(104, 41);
            Cancel.TabIndex = 4;
            Cancel.Text = "退出";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // frmClaInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(Cancel);
            Controls.Add(dataGView);
            Controls.Add(title);
            Name = "frmClaInfo";
            Text = "学生班级信息";
            ((System.ComponentModel.ISupportInitialize)dataGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private DataGridView dataGView;
        private Button Cancel;
    }
}