using System.Data;

namespace Students
{
    public partial class frmPwdTea : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string userid;
        private string sql;
        public frmPwdTea()
        {
            InitializeComponent();
        }
        public frmPwdTea(string str = "")
        {
            InitializeComponent();
            userid = str;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCurPwd.Text == txtNowPwd.Text)
            {
                MessageBox.Show("修改后的密码不能与原密码一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("确定要修改密码吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        sql = "update wangcw_teacherusers12 set wcw_tpassword12='" + txtNowPwd.Text + "'  where wcw_tusername12=" + userid;
                        con.OperateData(sql);
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("当前密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
