namespace Students
{
    partial class frmAvgScore
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
            groupBox1 = new GroupBox();
            selSemester = new ComboBox();
            semester = new Label();
            btn = new Button();
            year = new Label();
            txtYear = new TextBox();
            dataGView = new DataGridView();
            cancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(34, 9);
            title.Name = "title";
            title.Size = new Size(164, 25);
            title.TabIndex = 8;
            title.Text = "课程平均成绩查询";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selSemester);
            groupBox1.Controls.Add(semester);
            groupBox1.Controls.Add(btn);
            groupBox1.Controls.Add(year);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Location = new Point(232, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 66);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "学年学期选择";
            // 
            // selSemester
            // 
            selSemester.FormattingEnabled = true;
            selSemester.Items.AddRange(new object[] { "全部", "1", "2" });
            selSemester.Location = new Point(309, 28);
            selSemester.Name = "selSemester";
            selSemester.Size = new Size(121, 25);
            selSemester.TabIndex = 10;
            // 
            // semester
            // 
            semester.AutoSize = true;
            semester.Location = new Point(259, 31);
            semester.Name = "semester";
            semester.Size = new Size(44, 17);
            semester.TabIndex = 1;
            semester.Text = "学期：";
            // 
            // btn
            // 
            btn.Location = new Point(460, 28);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 5;
            btn.Text = "查询";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(70, 31);
            year.Name = "year";
            year.Size = new Size(44, 17);
            year.TabIndex = 0;
            year.Text = "学年：";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(120, 28);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 2;
            // 
            // dataGView
            // 
            dataGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView.Location = new Point(12, 116);
            dataGView.Name = "dataGView";
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(776, 229);
            dataGView.TabIndex = 10;
            // 
            // cancel
            // 
            cancel.Location = new Point(646, 375);
            cancel.Name = "cancel";
            cancel.Size = new Size(108, 39);
            cancel.TabIndex = 11;
            cancel.Text = "退出";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // frmAvgScore
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancel);
            Controls.Add(dataGView);
            Controls.Add(groupBox1);
            Controls.Add(title);
            Name = "frmAvgScore";
            Text = "课程平均成绩";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private GroupBox groupBox1;
        private ComboBox selSemester;
        private Label semester;
        private Button btn;
        private Label year;
        private TextBox txtYear;
        private DataGridView dataGView;
        private Button cancel;
    }
}