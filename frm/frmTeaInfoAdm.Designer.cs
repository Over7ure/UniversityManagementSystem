namespace Students
{
    partial class frmTeaInfoAdm
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
            groupBox2 = new GroupBox();
            txttitle = new TextBox();
            txttel = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtage = new TextBox();
            txtname = new TextBox();
            txtgender = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnInsert = new Button();
            label2 = new Label();
            txtno = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            cancel = new Button();
            dataGView = new DataGridView();
            title = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txttitle);
            groupBox2.Controls.Add(txttel);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtage);
            groupBox2.Controls.Add(txtname);
            groupBox2.Controls.Add(txtgender);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnInsert);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtno);
            groupBox2.Location = new Point(32, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(737, 124);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "信息录入";
            // 
            // txttitle
            // 
            txttitle.Location = new Point(342, 74);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(100, 23);
            txttitle.TabIndex = 18;
            // 
            // txttel
            // 
            txttel.Location = new Point(522, 74);
            txttel.Name = "txttel";
            txttel.Size = new Size(100, 23);
            txttel.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 77);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 16;
            label3.Text = "教师电话：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 77);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 14;
            label5.Text = "教师职称：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 77);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 13;
            label6.Text = "教师年龄：";
            // 
            // txtage
            // 
            txtage.Location = new Point(162, 74);
            txtage.Name = "txtage";
            txtage.Size = new Size(100, 23);
            txtage.TabIndex = 15;
            // 
            // txtname
            // 
            txtname.Location = new Point(342, 24);
            txtname.Name = "txtname";
            txtname.Size = new Size(100, 23);
            txtname.TabIndex = 12;
            // 
            // txtgender
            // 
            txtgender.Location = new Point(522, 24);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(100, 23);
            txtgender.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 27);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 7;
            label4.Text = "教师性别：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 27);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 1;
            label1.Text = "教师姓名：";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(644, 52);
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
            label2.Location = new Point(88, 27);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 0;
            label2.Text = "教师编号：";
            // 
            // txtno
            // 
            txtno.Location = new Point(162, 24);
            txtno.Name = "txtno";
            txtno.Size = new Size(100, 23);
            txtno.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(432, 487);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 39);
            btnSave.TabIndex = 33;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(546, 487);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 39);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(660, 487);
            cancel.Name = "cancel";
            cancel.Size = new Size(108, 39);
            cancel.TabIndex = 31;
            cancel.Text = "退出";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // dataGView
            // 
            dataGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView.Location = new Point(32, 192);
            dataGView.Name = "dataGView";
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(737, 253);
            dataGView.TabIndex = 30;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(51, 8);
            title.Name = "title";
            title.Size = new Size(88, 25);
            title.TabIndex = 29;
            title.Text = "教师信息";
            // 
            // frmTeaInfoAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(groupBox2);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(cancel);
            Controls.Add(dataGView);
            Controls.Add(title);
            Name = "frmTeaInfoAdm";
            Text = "教师信息";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtname;
        private TextBox txtgender;
        private Label label4;
        private Label label1;
        private Button btnInsert;
        private Label label2;
        private TextBox txtno;
        private Button btnSave;
        private Button btnDelete;
        private Button cancel;
        private DataGridView dataGView;
        private Label title;
        private TextBox txttitle;
        private TextBox txttel;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtage;
    }
}