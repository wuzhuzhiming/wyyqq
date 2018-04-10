using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace qqserver
{
    class dboperate
    {
        SqlConnection db_connect;

        //连接数据库
        public void connect_db()
        {
            string str_conect = "server=PC-20120726ZSPY\\SQLEXPRESS;database=db_wyyqq;uid=sa;pwd=123";
            db_connect = new SqlConnection(str_conect);
            db_connect.Open();
        }
    }
}
