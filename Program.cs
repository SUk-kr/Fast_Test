using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


//mysql에 접속하여 모든정보를 받아오는 방법

namespace Fast_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> db_colums = new List<string>();
            List<List<string>> datas = new List<List<string>>();

            string strConn = "Server=localhost;Database=mydb;Uid=mes;Pwd=0462;";    //mysql 접속하기위한 명령어 선언
            using (MySqlConnection conn = new MySqlConnection(strConn))             //mysql 접속,conn라는 접속변수 선언
            {
                conn.Open();    //접속
                string strSql = "SELECT * FROM login_table";
                //string strSql = "SELECT * FROM login_table WHERE user_id ='" + strId + "'"; //mysql문 사용하여 strid 튜플 확인하는 명령어 선언
                //string strSql = "SELECT column_name FROM information_schema.columns WHERE table_name = 'login_table';";
                MySqlCommand cmd = new MySqlCommand(strSql, conn);  //mysql문 선언변수 cmd 선언 (위에 선언한 튜플확인하는 변수와 오픈변수 사용)
                                                                    //MySqlDataReader reader = cmd.ExecuteReader();   //strsql을 connection에 보내고 sqldatareader를 받는 변수 reader선언

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Console.WriteLine(dt.Rows[i].ItemArray[j]);
                    }
                }
                //Console.ReadKey();
            }

            How_Use_1 hw = new How_Use_1();
            hw.test();
            
        }
    }
}
