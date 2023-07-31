namespace Students
{
    partial class frmSelCou
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
            dataGView = new DataGridView();
            cancel = new Button();
            btn = new Button();
            groupBox1 = new GroupBox();
            txtYear = new TextBox();
            txtClaNo = new TextBox();
            semester = new Label();
            comSemester = new ComboBox();
            year = new Label();
            calNo = new Label();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "选课";
            // 
            // dataGView
            // 
            dataGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView.Location = new Point(12, 121);
            dataGView.Name = "dataGView";
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(970, 212);
            dataGView.TabIndex = 1;
            // 
            // cancel
            // 
            cancel.Location = new Point(894, 375);
            cancel.Name = "cancel";
            cancel.Size = new Size(88, 42);
            cancel.TabIndex = 3;
            cancel.Text = "退出";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // btn
            // 
            btn.Location = new Point(786, 375);
            btn.Name = "btn";
            btn.Size = new Size(88, 42);
            btn.TabIndex = 4;
            btn.Text = "选课";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
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
            groupBox1.Location = new Point(316, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 74);
            groupBox1.TabIndex = 5;
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
            comSemester.Items.AddRange(new object[] { "1", "2" });
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
            // frmSelCou
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 450);
            Controls.Add(groupBox1);
            Controls.Add(btn);
            Controls.Add(cancel);
            Controls.Add(dataGView);
            Controls.Add(label1);
            Name = "frmSelCou";
            Text = "选课";
            ((System.ComponentModel.ISupportInitialize)dataGView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGView;
        private Button cancel;
        private Button btn;
        private GroupBox groupBox1;
        private TextBox txtYear;
        private TextBox txtClaNo;
        private Label semester;
        private ComboBox comSemester;
        private Label year;
        private Label calNo;
        private Button btnOK;
    }
}