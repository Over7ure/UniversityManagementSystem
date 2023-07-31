using System.Data;
using System.Data.Odbc;

namespace Students
{
    internal class sqlConnect
    {
        String odbcstr = "Dsn=****;Uid=****;Pwd=****;";
        public OdbcConnection conn = null;
        public sqlConnect()//构造函数，连接
        {
            if (conn == null)
            {
                conn = new OdbcConnection(odbcstr);
                if (conn.State == ConnectionState.Closed) conn.Open();
            }
        }
        public void closeConnect()//关闭连接
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        //下面这个方法是从数据库中查找数据的方法
        public DataSet Getds(string sql)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet ds = new DataSet();//DataSet是表的集合
            OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);//从数据库中查询
            da.Fill(ds);//将数据填充到DataSet
            conn.Close();//关闭连接
            return ds;//返回结果
        }
        //下面的方法是对数据库进行更新
        public int OperateData(string sql)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            OdbcCommand sqlcom = new OdbcCommand();//表示要对数据源执行的SQL语句或存储过程
            sqlcom.CommandText = sql;//设置命令的文本
            sqlcom.CommandType = CommandType.Text;//设置命令的类型
            sqlcom.Connection = conn;//设置命令的连接
            int x = sqlcom.ExecuteNonQuery();//执行SQL语句
            conn.Close();//关闭连接
            return x;   //返回一个影响行数

        }
        //----绑定DataGridView
        public DataSet BindDataGridView(DataGridView dgv, string sql)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            return ds;
        }

    }
}
