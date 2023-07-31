using System.Data;

namespace Students
{
    public partial class frmScoreIn : Form
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
                    sql = "select * from wangcw_scoreview12 where 教师编号=" + userid + " and 学年=" + txtYear.Text;
                    con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else
                {
                    sql = "select * from wangcw_scoreview12 where 教师编号=" + userid + " and 学年=" + txtYear.Text + " and 学期=" + semester;
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
        public frmScoreIn()
        {
            InitializeComponent();
        }
        public frmScoreIn(string str = "")
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string semester;
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    semester = selSemester.SelectedItem.ToString();
                    sql = "delete from wangcw_scores12  where wcw_sno12='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "' and wcw_tno12=" + userid + " and wcw_tyear12=" + txtYear.Text + " and wcw_tsemester12=" + semester + " and wcw_couno12='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind(userid);
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string semester;
            try
            {
                semester = selSemester.SelectedItem.ToString();
                sql = "update wangcw_scores12 set wcw_sscore12='" + dataGView.CurrentRow.Cells[8].Value.ToString() + "' where wcw_sno12='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "' and wcw_tno12=" + userid + " and wcw_tyear12=" + txtYear.Text + " and wcw_tsemester12=" + semester + " and wcw_couno12='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind(userid);
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            string semester;
            try
            {
                semester = selSemester.SelectedItem.ToString();
                sql = "insert into wangcw_scores12 values( '" + txtSno.Text + "','" + txtCno.Text + "','" + semester + "','" + txtYear.Text + "','" + userid + "','" + txtScore.Text + "')";
                con.OperateData(sql);
                SetBind(userid);
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
