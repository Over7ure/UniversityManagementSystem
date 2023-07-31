using System.Data;

namespace Students
{
    public partial class frmScoreAdm : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind(string userid = "")
        {
            string semester;
            try
            {
                semester = selSemester.SelectedItem.ToString();
                if (semester == "全部")
                {
                    sql = "select * from wangcw_scoreview12 where 学年=" + txtYear.Text;
                    con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else
                {
                    sql = "select * from wangcw_scoreview12 where 学年=" + txtYear.Text + " and 学期=" + semester;
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
        public frmScoreAdm()
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
