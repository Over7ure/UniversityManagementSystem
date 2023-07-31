namespace Students
{
    partial class frmStuInfoAdm
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
            txtregion = new TextBox();
            label7 = new Label();
            txtage = new TextBox();
            label8 = new Label();
            txtgrade = new TextBox();
            txtclass = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtsource = new TextBox();
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
            groupBox2.Controls.Add(txtregion);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtage);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtgrade);
            groupBox2.Controls.Add(txtclass);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtsource);
            groupBox2.Controls.Add(txtname);
            groupBox2.Controls.Add(txtgender);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnInsert);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtno);
            groupBox2.Location = new Point(12, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1043, 114);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "信息录入";
            // 
            // txtregion
            // 
            txtregion.Location = new Point(681, 66);
            txtregion.Name = "txtregion";
            txtregion.Size = new Size(100, 23);
            txtregion.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(631, 69);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 21;
            label7.Text = "地区：";
            // 
            // txtage
            // 
            txtage.Location = new Point(681, 24);
            txtage.Name = "txtage";
            txtage.Size = new Size(100, 23);
            txtage.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(631, 27);
            label8.Name = "label8";
            label8.Size = new Size(44, 17);
            label8.TabIndex = 19;
            label8.Text = "年龄：";
            // 
            // txtgrade
            // 
            txtgrade.Location = new Point(366, 66);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new Size(100, 23);
            txtgrade.TabIndex = 18;
            // 
            // txtclass
            // 
            txtclass.Location = new Point(522, 66);
            txtclass.Name = "txtclass";
            txtclass.Size = new Size(100, 23);
            txtclass.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 69);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 16;
            label3.Text = "班级：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 69);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 14;
            label5.Text = "年级：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 69);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 13;
            label6.Text = "生源地：";
            // 
            // txtsource
            // 
            txtsource.Location = new Point(186, 66);
            txtsource.Name = "txtsource";
            txtsource.Size = new Size(100, 23);
            txtsource.TabIndex = 15;
            // 
            // txtname
            // 
            txtname.Location = new Point(366, 24);
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
            label4.Location = new Point(472, 27);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 7;
            label4.Text = "性别：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 27);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "姓名：";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(883, 45);
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
            // txtno
            // 
            txtno.Location = new Point(186, 24);
            txtno.Name = "txtno";
            txtno.Size = new Size(100, 23);
            txtno.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(719, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 39);
            btnSave.TabIndex = 21;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(833, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 39);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(947, 399);
            cancel.Name = "cancel";
            cancel.Size = new Size(108, 39);
            cancel.TabIndex = 19;
            cancel.Text = "退出";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // dataGView
            // 
            dataGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGView.Location = new Point(12, 168);
            dataGView.Name = "dataGView";
            dataGView.RowTemplate.Height = 25;
            dataGView.Size = new Size(1045, 216);
            dataGView.TabIndex = 18;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(31, 9);
            title.Name = "title";
            title.Size = new Size(88, 25);
            title.TabIndex = 16;
            title.Text = "学生信息";
            // 
            // frmStuInfoAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 450);
            Controls.Add(groupBox2);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(cancel);
            Controls.Add(dataGView);
            Controls.Add(title);
            Name = "frmStuInfoAdm";
            Text = "学生信息";
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
        private TextBox txtregion;
        private Label label7;
        private TextBox txtage;
        private Label label8;
        private TextBox txtgrade;
        private TextBox txtclass;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtsource;
    }
}