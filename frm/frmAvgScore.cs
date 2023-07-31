using System.Data;

namespace Students
{
    public partial class frmAvgScore : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string userid;
        protected void SetBind(string userid = "")
        {
            string semester;
            try
            {
                semester = selSemester.SelectedItem.ToString();
                if (semester == "全部")
                {
                    sql = "select * from wangcw_avgscoreview12 where 任课教师编号=" + userid + " and 学年=" + txtYear.Text;
                    con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else
                {
                    sql = "select * from wangcw_avgscoreview12 where 任课教师编号=" + userid + " and 学年=" + txtYear.Text + " and 学期=" + semester;
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
        public frmAvgScore()
        {
            InitializeComponent();
        }
        public frmAvgScore(string str = "")
        {
            InitializeComponent();
            userid = str;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SetBind(userid);
        }
    }
}
