namespace Students
{
    partial class frmScoreIn
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
            btnDelete = new Button();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            txtCno = new TextBox();
            txtScore = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnInsert = new Button();
            label2 = new Label();
            txtSno = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(27, 9);
            title.Name = "title";
            title.Size = new Size(126, 25);
            title.TabIndex = 9;
            title.Text = "学生成绩录入";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selSemester);
            groupBox1.Controls.Add(semester);
            groupBox1.Controls.Add(btn);
            groupBox1.Controls.Add(year);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Location = new Point(423, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 66);
            groupBox1.TabIndex = 10;
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
            dataGView.Location = new Point(12, 187);
            dataGView.Name = "dataGView";
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(967, 153);
            dataGView.TabIndex = 11;
            // 
            // cancel
            // 
            cancel.Location = new Point(859, 379);
            cancel.Name = "cancel";
            cancel.Size = new Size(108, 39);
            cancel.TabIndex = 12;
            cancel.Text = "退出";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(745, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 39);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(631, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 39);
            btnSave.TabIndex = 14;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCno);
            groupBox2.Controls.Add(txtScore);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnInsert);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSno);
            groupBox2.Location = new Point(247, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(732, 66);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "成绩录入";
            // 
            // txtCno
            // 
            txtCno.Location = new Point(366, 24);
            txtCno.Name = "txtCno";
            txtCno.Size = new Size(100, 23);
            txtCno.TabIndex = 12;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(522, 24);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 27);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 7;
            label4.Text = "成绩：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 27);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 1;
            label1.Text = "课程编号：";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(636, 24);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "录入";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 27);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 0;
            label2.Text = "学生编号：";
            // 
            // txtSno
            // 
            txtSno.Location = new Point(186, 24);
            txtSno.Name = "txtSno";
            txtSno.Size = new Size(100, 23);
            txtSno.TabIndex = 2;
            // 
            // frmScoreIn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 450);
            Controls.Add(groupBox2);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(cancel);
            Controls.Add(dataGView);
            Controls.Add(groupBox1);
            Controls.Add(title);
            Name = "frmScoreIn";
            Text = "学生成绩录入";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button btnDelete;
        private Button btnSave;
        private GroupBox groupBox2;
        private TextBox txtCno;
        private TextBox txtScore;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnInsert;
        private Label label2;
        private TextBox txtSno;
    }
}