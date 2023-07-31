using System.Data;

namespace Students
{
    public partial class frmStuInfo : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind(string userid = "")
        {
            try
            {
                sql = "select wcw_sno12 as 学生编号,wcw_sname12 as 姓名,wcw_sgender12 as 性别,wcw_sage12 as 年龄,wcw_ssource12 as 生源地,wcw_sgrade12 as 年级,wcw_scredits12 as 已修学分,wcw_sgpa12 as 绩点,wcw_clano12 as 班级编号,wcw_sregion12 as 地区  from wangcw_students12 where wcw_sno12=" + userid;
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
        public frmStuInfo()
        {
            InitializeComponent();
            SetBind();
        }
        public frmStuInfo(string str)
        {
            InitializeComponent();
            SetBind(str);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
