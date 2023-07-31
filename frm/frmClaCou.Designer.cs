namespace Students
{
    partial class frmClaCou
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
            txtYear = new TextBox();
            txtClaNo = new TextBox();
            semester = new Label();
            comSemester = new ComboBox();
            year = new Label();
            calNo = new Label();
            btnOK = new Button();
            cancel = new Button();
            dataGView = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(12, 12);
            title.Name = "title";
            title.Size = new Size(164, 25);
            title.TabIndex = 0;
            title.Text = "班级选课情况查询";
            title.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtClaNo);
            groupBox1.Controls.Add(semester);
            groupBox1.Controls.Add(comSemester);
            groupBox1.Controls.Add(year);
            groupBox1.Controls.Add(calNo);
            groupBox1.Controls.Add(btnOK);
            groupBox1.Location = new Point(122, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 74);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "信息输入";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(277, 28);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 6;
            // 
            // txtClaNo
            // 
            txtClaNo.Location = new Point(112, 28);
            txtClaNo.Name = "txtClaNo";
            txtClaNo.Size = new Size(100, 23);
            txtClaNo.TabIndex = 5;
            // 
            // semester
            // 
            semester.AutoSize = true;
            semester.Location = new Point(403, 31);
            semester.Name = "semester";
            semester.Size = new Size(44, 17);
            semester.TabIndex = 4;
            semester.Text = "学期：";
            // 
            // comSemester
            // 
            comSemester.FormattingEnabled = true;
            comSemester.Items.AddRange(new object[] { "全部", "1", "2" });
            comSemester.Location = new Point(452, 28);
            comSemester.Name = "comSemester";
            comSemester.Size = new Size(121, 25);
            comSemester.TabIndex = 3;
            // 
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(228, 31);
            year.Name = "year";
            year.Size = new Size(44, 17);
            year.TabIndex = 2;
            year.Text = "学年：";
            // 
            // calNo
            // 
            calNo.AutoSize = true;
            calNo.Location = new Point(38, 31);
            calNo.Name = "calNo";
            calNo.Size = new Size(68, 17);
            calNo.TabIndex = 1;
            calNo.Text = "班级编号：";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(579, 28);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "查询";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(672, 382);
            cancel.Name = "cancel";
            cancel.Size = new Size(86, 44);
            cancel.TabIndex = 2;
            cancel.Text = "退出";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // dataGView
            // 
            dataGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView.Location = new Point(12, 148);
            dataGView.Name = "dataGView";
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(776, 195);
            dataGView.TabIndex = 3;
            // 
            // frmClaCou
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGView);
            Controls.Add(cancel);
            Controls.Add(groupBox1);
            Controls.Add(title);
            Name = "frmClaCou";
            Text = "班级开课信息";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private GroupBox groupBox1;
        private TextBox txtClaNo;
        private Label semester;
        private ComboBox comSemester;
        private Label year;
        private Label calNo;
        private Button btnOK;
        private Button cancel;
        private TextBox txtYear;
        private DataGridView dataGView;
    }
}