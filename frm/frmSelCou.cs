using System.Data;

namespace Students
{
    public partial class frmSelCou : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind(string userid = "")
        {
            string semester;
            try
            {
                semester = comSemester.SelectedItem.ToString();
                sql = "select * from wangcw_clacouview12 where 学年=" + txtYear.Text + " and 学期=" + semester + " and 班级编号='" + txtClaNo.Text + "'";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public frmSelCou()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("选课成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetBind();
        }
    }
}
