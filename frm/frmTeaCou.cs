using System.Data;

namespace Students
{
    public partial class frmTeaCou : Form
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
                    sql = "select wcw_couno12 as 课程编号, wcw_tno12 as 教师编号, wcw_tsemester12 as 学期, wcw_tyear12 as 学年 from wangcw_teach12 where wcw_tno12=" + txtTeaNo.Text + " and wcw_tyear12=" + txtYear.Text;
                    con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else
                {
                    sql = "select wcw_couno12 as 课程编号, wcw_tno12 as 教师编号, wcw_tsemester12 as 学期, wcw_tyear12 as 学年 from wangcw_teach12 where wcw_tno12=" + txtTeaNo.Text + " and wcw_tyear12=" + txtYear.Text + " and wcw_tsemester12=" + semester;
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
        public frmTeaCou()
        {
            InitializeComponent();
        }
        public frmTeaCou(string str = "")
        {
            InitializeComponent();
            txtTeaNo.Text = str;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetBind();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
