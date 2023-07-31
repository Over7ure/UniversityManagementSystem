using System.Data;

namespace Students
{
    public partial class FrmMaintea : Form
    {
        private string userid;
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string username;
        public FrmMaintea()
        {
            InitializeComponent();
        }
        public FrmMaintea(string str = "")
        {
            InitializeComponent();
            userid = str;
            try
            {
                sql = "SELECT wcw_tname12 FROM Wangcw_teachers12 WHERE wcw_tno12=" + userid;
                ds = con.Getds(sql);
            }
            catch
            {
                MessageBox.Show("发生错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            if (ds.Tables[0].Rows[0].ItemArray[0] != null)
            {
                username = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            laUsername.Text = username;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeaInfo frm = new frmTeaInfo(userid);
            frm.ShowDialog();
        }

        private void 任课情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeaCou fTeaCou = new frmTeaCou(userid);
            fTeaCou.ShowDialog();
        }

        private void 授课学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 课程平均成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvgScore fAvg = new frmAvgScore(userid);
            fAvg.ShowDialog();
        }

        private void 学生成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScoreIn fSco = new frmScoreIn(userid);
            fSco.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPwdTea fPwd = new frmPwdTea(userid);
            fPwd.ShowDialog();
        }
    }
}
