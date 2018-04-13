using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data;
using System.Data.SqlClient;

namespace qqserver
{
    static class dboperate
    {
        static SqlConnection db_connect;

        static dboperate()
        {
            connect_db();
        }

        //连接数据库
        public static void connect_db()
        {
            string str_conect = "server=PC-20120726ZSPY\\SQLEXPRESS;database=db_wyyqq;uid=sa;pwd=123456";
            db_connect = new SqlConnection(str_conect);
            db_connect.Open();
        }

        //查询账号是否已经存在
        public static bool check_account(string str_account)
        {
            string str_sql = "select count(*) from t_user where account=\'" + str_account + "\'";
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            int account_num = (int)sql_cmd.ExecuteScalar();

            if (account_num > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //创建用户数据
        public static void create_user(string[] arr_recv)
        {
            string str_sql = "=\'" + str_account + "\'";
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            sql_cmd.ExecuteNonQuery();
        }
    }
}
