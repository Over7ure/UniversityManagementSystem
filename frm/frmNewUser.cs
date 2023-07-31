using System.Data;

namespace Students
{
    public partial class frmNewUser : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            string position;
            try
            {
                position = comPosition.SelectedItem.ToString();
                if (position == "学生")
                {
                    sql = "insert into wangcw_studentusers12 values('" + txtUsername.Text + "','" + txtPwd.Text + "','" + txtUsername.Text + "')";
                    con.OperateData(sql);
                }
                else if (position == "教师")
                {
                    sql = "insert into wangcw_teacherusers12 values('" + txtUsername.Text + "','" + txtPwd.Text + "','" + txtUsername.Text + "')";
                    con.OperateData(sql);
                }
                else
                {
                    sql = "insert into wangcw_adminusers12 values( '" + txtUsername.Text + "', '" + txtPwd.Text + "', '" + position + "')";
                    con.OperateData(sql);
                }
                MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SetBind();
        }
    }
}
