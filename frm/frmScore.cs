using System.Data;

namespace Students
{
    public partial class frmScore : Form
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
                    sql = "select * from wangcw_scoreview12 where 学生编号=" + userid + " and 学年=" + txtYear.Text;
                    con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else
                {
                    sql = "select * from wangcw_scoreview12 where 学生编号=" + userid + " and 学年=" + txtYear.Text + " and 学期=" + semester;
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
        public frmScore()
        {
            InitializeComponent();
        }
        public frmScore(string str = "")
        {
            InitializeComponent();
            userid = str;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SetBind(userid);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
