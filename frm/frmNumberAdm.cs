using System.Data;

namespace Students
{
    public partial class frmNumberAdm : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind(string userid = "")
        {
            try
            {
                sql = "select * from wangcw_numberofregion12()";
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
        public frmNumberAdm()
        {
            InitializeComponent();
            SetBind();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
