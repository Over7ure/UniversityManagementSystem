using System.Data;

namespace Students
{
    public partial class frmClaCou : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            string semester;
            try
            {
                semester = comSemester.SelectedItem.ToString();
                if (semester == "全部")
                {
                    sql = "select * from wangcw_clacouview12 where 班级编号='" + txtClaNo.Text + "' and 学年=" + txtYear.Text;
                    con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else
                {
                    sql = "select * from wangcw_clacouview12 where 班级编号='" + txtClaNo.Text + "' and 学年=" + txtYear.Text + " and 学期=" + semester;
                    con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public frmClaCou()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetBind();
        }
    }
}
