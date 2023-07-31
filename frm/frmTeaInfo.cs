using System.Data;

namespace Students
{
    public partial class frmTeaInfo : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind(string userid = "")
        {
            try
            {
                sql = "select wcw_tno12 as 教师编号,wcw_tname12 as 姓名,wcw_tgender12 as 性别,wcw_tage12 as 年龄,wcw_ttitle12 as 职称,wcw_ttel12 as 电话  from wangcw_teachers12 where wcw_tno12=" + userid;
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
        public frmTeaInfo()
        {
            InitializeComponent();
        }
        public frmTeaInfo(string str = "")
        {
            InitializeComponent();
            SetBind(str);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
