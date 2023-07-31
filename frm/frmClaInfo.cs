using System.Data;

namespace Students
{
    public partial class frmClaInfo : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind(string userid = "")
        {
            try
            {
                sql = "SELECT wcw_clano12 AS 班级编号, wangcw_majors12.wcw_mno12 AS 专业编号, wcw_mname12 AS 专业名称, wangcw_colleges12.wcw_colno12 AS 学院编号, wcw_colname12 AS 学院名称 FROM wangcw_classes12 JOIN wangcw_majors12 ON wangcw_majors12.wcw_mno12 = wangcw_classes12.wcw_mno12 JOIN wangcw_colleges12 ON wangcw_colleges12.wcw_colno12 = wangcw_majors12.wcw_colno12 WHERE wcw_clano12 = (   SELECT wcw_clano12   FROM wangcw_students12   WHERE wcw_sno12=" + userid + ")";
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
        public frmClaInfo()
        {
            InitializeComponent();
            SetBind();
        }
        public frmClaInfo(string str = "")
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
