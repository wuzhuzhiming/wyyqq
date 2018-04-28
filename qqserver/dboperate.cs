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
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            int account_num = (int)sql_cmd.ExecuteScalar();
            db_connect.Close();
            connect_db();

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
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            sql_cmd.ExecuteNonQuery();
            db_connect.Close();
            connect_db();
        }

        //查询密码是否已经一致
        public static bool check_pass(string str_account, string str_pass)
        {
            string str_sql = "select pass from t_user where account=\'" + str_account + "\'";
            //connect_db();
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

            //sql_result.Close();
            db_connect.Close();
            connect_db();
            return check_ret;
        }

        //通过账号查询用户基本信息
        public static Dictionary<string, string> get_user_info(string str_account)
        {
            string str_sql = "select * from t_user where account=\'" + str_account + "\'";
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            SqlDataReader sql_result = sql_cmd.ExecuteReader();

            Dictionary<string, string> map_result = new Dictionary<string, string>();
            if (sql_result.Read())
            {
                map_result.Add("account", sql_result["account"].ToString());
                map_result.Add("pass", sql_result["pass"].ToString());
                map_result.Add("userid", sql_result["userid"].ToString());
                map_result.Add("name", sql_result["name"].ToString());
                map_result.Add("sex", sql_result["sex"].ToString());
                map_result.Add("head", sql_result["head"].ToString());
            }

            //sql_result.Close();
            db_connect.Close();
            connect_db();
            return map_result;
        }

        //通过userid查询用户基本信息
        public static Dictionary<string, string> get_user_info_from_userid(int userid)
        {
            string str_sql = String.Format("select * from t_user where userid={0}", userid);
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            SqlDataReader sql_result = sql_cmd.ExecuteReader();

            Dictionary<string, string> map_result = new Dictionary<string, string>();
            if (sql_result.Read())
            {
                map_result.Add("account", sql_result["account"].ToString());
                map_result.Add("pass", sql_result["pass"].ToString());
                map_result.Add("userid", sql_result["userid"].ToString());
                map_result.Add("name", sql_result["name"].ToString());
                map_result.Add("sex", sql_result["sex"].ToString());
                map_result.Add("head", sql_result["head"].ToString());
            }

            //sql_result.Close();
            db_connect.Close();
            connect_db();
            return map_result;
        }

        //创建一条新消息
        public static void create_news(int userid, int news_type, int with_userid, int with_groupid)
        {
            string str_sql = String.Format(@"insert into t_news(userid,news_type,with_userid,with_groupid) 
                values({0},{1},{2},{3})",
                userid, news_type, with_userid, with_groupid);
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            sql_cmd.ExecuteNonQuery();
            db_connect.Close();
            connect_db();
        }

        //获取一条消息
        public static void get_one_news(int userid, ref int news_type, out string with_userid, out string with_username, out string with_groupid, out string with_groupname)
        {
            string str_sql = String.Format("select top 1 * from v_news where userid={0}", userid);
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            SqlDataReader sql_result = sql_cmd.ExecuteReader();

            if (sql_result.Read())
            {
                news_type = int.Parse(sql_result["news_type"].ToString());
                with_userid = sql_result["with_userid"].ToString();
                with_username = sql_result["with_username"].ToString();
                with_groupid = sql_result["with_groupid"].ToString();
                with_groupname = sql_result["with_groupname"].ToString();
            }
            else
            {
                news_type = 0;
                with_userid = "";
                with_username = "";
                with_groupid = "";
                with_groupname = "";
            }

            //sql_result.Close();
            db_connect.Close();
            connect_db();
        }

        //删除一条新消息
        public static void del_news(int userid, int news_type, int with_userid, int with_groupid)
        {
            string str_sql = String.Format(@"delete from t_news where userid={0} and news_type={1} and with_userid={2} and with_groupid={3}",
                userid, news_type, with_userid, with_groupid);
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            sql_cmd.ExecuteNonQuery();
            db_connect.Close();
            connect_db();
        }

        //查询是否已经是好友
        public static bool check_friend(int userid, int with_userid)
        {
            string str_sql = String.Format(@"select * from t_friend where userid={0} and with_userid={1}", userid, with_userid);
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            SqlDataReader sql_result = sql_cmd.ExecuteReader();

            bool check_ret = false;

            if (sql_result.Read())
            {
                check_ret = true;
            }

            //sql_result.Close();
            db_connect.Close();
            connect_db();
            return check_ret;
        }

        //创建好友数据
        public static void create_friend(int userid, int with_userid)
        {
            string str_sql = String.Format(@"insert into t_friend(userid,with_userid) values({0},{1});insert into t_friend(userid,with_userid) values({2},{3});",
                userid, with_userid, with_userid, userid);
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            sql_cmd.ExecuteNonQuery();
            db_connect.Close();
            connect_db();
        }

        //查询用户的好友列表
        public static List<string> get_friendlist(int userid)
        {
            string str_sql = String.Format("select * from v_friend where userid={0}", userid);
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            SqlDataReader sql_result = sql_cmd.ExecuteReader();

            List<string> list_result = new List<string>();
            while (sql_result.Read())
            {
                //把好友的基本信息拼接成字符串
                string str_friend = String.Format(@"{0}|{1}|{2}|{3}",
                    sql_result["friend_userid"].ToString(),
                    sql_result["name"].ToString(),
                    sql_result["sex"].ToString(),
                    sql_result["head"].ToString());
                list_result.Add(str_friend);
            }

            //sql_result.Close();
            db_connect.Close();
            connect_db();
            return list_result;
        }

        //修改用户资料
        public static void modify_userinfo(int userid, string[] arr_recv)
        {
            string str_sql = String.Format(@"update t_user set pass='{0}',name='{1}',head={2} where userid={3}",
                arr_recv[1], arr_recv[2], int.Parse(arr_recv[3]), userid);
            //connect_db();
            SqlCommand sql_cmd = new SqlCommand(str_sql, db_connect);
            sql_cmd.ExecuteNonQuery();
            db_connect.Close();
            connect_db();
        }
    }
}
