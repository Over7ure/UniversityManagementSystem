namespace Students
{
    partial class frmStuInfo
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
            dataGView = new DataGridView();
            title = new Label();
            Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGView).BeginInit();
            SuspendLayout();
            // 
            // dataGView
            // 
            dataGView.AllowUserToAddRows = false;
            dataGView.AllowUserToDeleteRows = false;
            dataGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView.Location = new Point(12, 83);
            dataGView.Name = "dataGView";
            dataGView.ReadOnly = true;
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(1045, 198);
            dataGView.TabIndex = 0;
            dataGView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(471, 27);
            title.Name = "title";
            title.Size = new Size(126, 25);
            title.TabIndex = 1;
            title.Text = "我的个人信息";
            // 
            // Cancel
            // 
            Cancel.Location = new Point(817, 360);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(104, 41);
            Cancel.TabIndex = 2;
            Cancel.Text = "退出";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // frmStuInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 450);
            Controls.Add(Cancel);
            Controls.Add(title);
            Controls.Add(dataGView);
            Name = "frmStuInfo";
            Text = "学生个人信息";
            ((System.ComponentModel.ISupportInitialize)dataGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGView;
        private Label title;
        private Button Cancel;
    }
}