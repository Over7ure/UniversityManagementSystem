namespace Students
{
    partial class frmScore
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
            label1 = new Label();
            label2 = new Label();
            txtYear = new TextBox();
            label3 = new Label();
            btn = new Button();
            groupBox1 = new GroupBox();
            selSemester = new ComboBox();
            semester = new Label();
            year = new Label();
            title = new Label();
            dataGView = new DataGridView();
            cancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 28);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(120, 28);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 35);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 3;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(selSemester);
            groupBox1.Controls.Add(semester);
            groupBox1.Controls.Add(btn);
            groupBox1.Controls.Add(year);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Location = new Point(449, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 66);
            groupBox1.TabIndex = 6;
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
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(70, 31);
            year.Name = "year";
            year.Size = new Size(44, 17);
            year.TabIndex = 0;
            year.Text = "学年：";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(34, 24);
            title.Name = "title";
            title.Size = new Size(126, 25);
            title.TabIndex = 7;
            title.Text = "学生成绩查询";
            // 
            // dataGView
            // 
            dataGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView.Location = new Point(12, 127);
            dataGView.Name = "dataGView";
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(993, 229);
            dataGView.TabIndex = 8;
            // 
            // cancel
            // 
            cancel.Location = new Point(821, 384);
            cancel.Name = "cancel";
            cancel.Size = new Size(108, 39);
            cancel.TabIndex = 9;
            cancel.Text = "退出";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // frmScore
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 450);
            Controls.Add(cancel);
            Controls.Add(dataGView);
            Controls.Add(title);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmScore";
            Text = "成绩查询";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtYear;
        private Label label3;
        private TextBox txtSemester;
        private Button btn;
        private GroupBox groupBox1;
        private Label semester;
        private Label year;
        private Label title;
        private DataGridView dataGView;
        private Button cancel;
        private ComboBox selSemester;
    }
}