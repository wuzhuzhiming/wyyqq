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
                return true;
            }
            else
            {
                return false;
            }
        }

        //创建用户数据
        public static void create_user(string[] arr_recv)
        {
            string str_sql = String.Format(@"insert into t_user(account,pass,name,sex,head) values('{0}','{1}','{2}',{3},{4})",
                arr_recv[1], arr_recv[2], arr_recv[3], int.Parse(arr_recv[4]), int.Parse(arr_recv[5]));
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            sql_cmd.ExecuteNonQuery();
        }

        //查询密码是否已经一致
        public static bool check_pass(string str_account, string str_pass)
        {
            string str_sql = "select pass from t_user where account=\'" + str_account + "\'";
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            SqlDataReader sql_result = sql_cmd.ExecuteReader();

            bool check_ret = false;

            if (!sql_result.Read())
            {
                check_ret = false;
            }

            if (sql_result["pass"].ToString() != str_pass)
            {
                check_ret = false;
            }
            else
            {
                check_ret = true;
            }

            sql_result.Close();
            return check_ret;
        }

        //通过账号查询用户基本信息
        public static Dictionary<string, string> get_user_info(string str_account)
        {
            string str_sql = "select * from t_user where account=\'" + str_account + "\'";
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            SqlDataReader sql_result = sql_cmd.ExecuteReader();

            Dictionary<string, string> map_result = new Dictionary<string, string>();
            if (sql_result.Read())
            {
                map_result.Add("account", sql_result["account"].ToString());
                map_result.Add("userid", sql_result["userid"].ToString());
                map_result.Add("name", sql_result["name"].ToString());
                map_result.Add("sex", sql_result["sex"].ToString());
                map_result.Add("head", sql_result["head"].ToString());
            }

            sql_result.Close();
            return map_result;
        }

        //通过userid查询用户基本信息
        public static Dictionary<string, string> get_user_info_from_userid(int userid)
        {
            string str_sql = String.Format("select * from t_user where userid={0}", userid);
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            SqlDataReader sql_result = sql_cmd.ExecuteReader();

            Dictionary<string, string> map_result = new Dictionary<string, string>();
            if (sql_result.Read())
            {
                map_result.Add("account", sql_result["account"].ToString());
                map_result.Add("userid", sql_result["userid"].ToString());
                map_result.Add("name", sql_result["name"].ToString());
                map_result.Add("sex", sql_result["sex"].ToString());
                map_result.Add("head", sql_result["head"].ToString());
            }

            sql_result.Close();
            return map_result;
        }

        //创建一条新消息
        public static void create_news(int userid, int news_type, int with_userid, int with_groupid)
        {
            string str_sql = String.Format(@"insert into t_news(userid,news_type,with_userid,with_groupid) 
                values({0},{1},{2},{3})",
                userid, news_type, with_userid, with_groupid);
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            sql_cmd.ExecuteNonQuery();
        }

        //获取消息列表
    }
}
