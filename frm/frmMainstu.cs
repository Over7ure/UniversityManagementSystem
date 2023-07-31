using System.Data;

namespace Students
{
    public partial class FrmMainstu : Form
    {
        private string userid;
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string username;
        public FrmMainstu()
        {
            InitializeComponent();
        }
        public FrmMainstu(string str)
        {
            InitializeComponent();
            userid = str;
            try
            {
                sql = "SELECT wcw_Sname12 FROM Wangcw_Students12 WHERE wcw_Sno12=" + userid;
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMainstu_Load(object sender, EventArgs e)
        {

        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuInfo fStu = new frmStuInfo(userid);
            fStu.ShowDialog();

        }

        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClaInfo fCla = new frmClaInfo(userid);
            fCla.ShowDialog();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScore fSco = new frmScore(userid);
            fSco.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPwdStu fPwd = new frmPwdStu(userid);
            fPwd.ShowDialog();
        }

        private void 班级开课信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmClaCou fClaCou = new frmClaCou();
            fClaCou.ShowDialog();
        }

        private void 教师任课信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeaCou fTeaCou = new frmTeaCou();
            fTeaCou.ShowDialog();
        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelCou fCalCou = new frmSelCou();
            fCalCou.ShowDialog();
        }
    }
}
