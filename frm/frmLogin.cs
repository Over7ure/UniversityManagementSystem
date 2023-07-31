using System.Data;

namespace Students
{
    public partial class frmLogin : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string position = comPosition.SelectedItem.ToString();
            if (txtName.Text == "" || txtPwd.Text == "")
                MessageBox.Show("用户名或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string pwd = null;
                string sql = null;
                try
                {
                    if (position == "学生")
                    {
                        sql = "SELECT wcw_Spassword12 FROM Wangcw_StudentUsers12 WHERE wcw_Susername12=" + txtName.Text;
                    }
                    else if (position == "教师")
                    {
                        sql = "SELECT wcw_tpassword12 FROM Wangcw_TeacherUsers12 WHERE wcw_tusername12=" + txtName.Text;
                    }
                    else if (position == "管理员")
                    {
                        sql = "SELECT wcw_apassword12 FROM Wangcw_adminUsers12 WHERE wcw_ausername12='" + txtName.Text + "'";
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPwd.Text = "";
                    }
                    ds = con.Getds(sql);
                    if (ds.Tables[0].Rows[0].ItemArray[0] != null)
                    {
                        pwd = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    }
                }
                catch
                {
                    txtPwd.Text = "";
                }
                if (pwd != null && txtPwd.Text == pwd)
                {
                    if (position == "学生")
                    {
                        FrmMainstu fmainstu = new FrmMainstu(txtName.Text);
                        fmainstu.Show();
                    }
                    else if (position == "教师")
                    {
                        FrmMaintea fmaintea = new FrmMaintea(txtName.Text);
                        fmaintea.Show();
                    }
                    else if (position == "管理员")
                    {
                        FrmMainadm fmainadm = new FrmMainadm(txtName.Text);
                        fmainadm.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPwd.Text = "";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}