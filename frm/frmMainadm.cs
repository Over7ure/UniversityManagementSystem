using System.Data;

namespace Students
{
    public partial class FrmMainadm : Form
    {
        private string userid;
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string userfunction;
        public FrmMainadm()
        {
            InitializeComponent();
        }
        public FrmMainadm(string str = "")
        {
            InitializeComponent();
            userid = str;
            try
            {
                sql = "SELECT wcw_afunction12 FROM Wangcw_adminusers12 WHERE wcw_ausername12='" + userid + "'";
                ds = con.Getds(sql);
            }
            catch
            {
                MessageBox.Show("发生错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            if (ds.Tables[0].Rows[0].ItemArray[0] != null)
            {
                userfunction = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            laUsername.Text = userfunction;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuInfoAdm fPwd = new frmStuInfoAdm();
            fPwd.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPwdAdm fPwd = new frmPwdAdm(userid);
            fPwd.ShowDialog();
        }

        private void 注册新用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewUser fPwd = new frmNewUser();
            fPwd.ShowDialog();
        }

        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClaInfoAdm fPwd = new frmClaInfoAdm();
            fPwd.ShowDialog();
        }

        private void 教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeaInfoAdm fPwd = new frmTeaInfoAdm();
            fPwd.ShowDialog();
        }

        private void 专业信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMajInfoAdm fPwd = new frmMajInfoAdm();
            fPwd.ShowDialog();
        }

        private void 学院信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColInfoAdm fPwd = new frmColInfoAdm();
            fPwd.ShowDialog();
        }

        private void 地区学生数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNumberAdm fPwd = new frmNumberAdm();
            fPwd.ShowDialog();
        }

        private void 学生成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScoreAdm fPwd = new frmScoreAdm();
            fPwd.ShowDialog();
        }
    }
}
