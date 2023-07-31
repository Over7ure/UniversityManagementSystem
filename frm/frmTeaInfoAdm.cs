using System.Data;

namespace Students
{
    public partial class frmTeaInfoAdm : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind(string userid = "")
        {
            try
            {
                sql = "select * from wangcw_teachers12";
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
        public frmTeaInfoAdm()
        {
            InitializeComponent();
            SetBind();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into wangcw_teachers12 values( '" + txtno.Text + "','" + txtname.Text + "','" + txtgender.Text + "','" + txtage.Text + "','" + txttitle.Text + "','" + txttel.Text + "')";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update wangcw_teachers12 set wcw_tname12='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "', wcw_tgender12='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "' ,wcw_tage12='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "', wcw_ttitle12='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "', wcw_ttel12='" + dataGView.CurrentRow.Cells[5].Value.ToString() + "' where wcw_tno12='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from wangcw_teachers12  where wcw_tno12='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
