using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 서버_개발
{
    class DBManager
    {
        static String strConn = "Server=localhost;Database=YLP;Uid=root;Pwd=1234;";
        MySqlConnection conn;

        public DBManager()
        {
            conn = new MySqlConnection(strConn);
        }

        public string InsertCafeteria(string pk, string name, string number, string address)
        {
            try
            {
                conn.Open();
                string cmdtext = string.Format("INSERT INTO CAFETERIA VALUES('{0}', '{1}', '{2}', '{3}')", pk, name, number, address);
                MySqlCommand cmd = new MySqlCommand(cmdtext, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return "";
        }
        
        public List<Cafeteria> ViewAllCafeteria()
        {
            List<Cafeteria> cafeterias = new List<Cafeteria>();

            //MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이터 가져오기
            DataSet ds = new DataSet();
            //string sql = "SELECT * FROM Cafeteria";
            string sql = "SELECT * FROM Cafe";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "Cafeteria");

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Cafeteria cafe = new Cafeteria((string)row[0], (string)row[1], (string)row[2], (string)row[3], (string)row[4]);
                cafeterias.Add(cafe);                
            }

            return cafeterias;
        }
        public Cafeteria GetCafeteria(string primaryKey)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT * FROM Menu WHERE ID={0}", primaryKey); // View Cafe 불러옴
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "Menu");

            List<string> menuList = new List<string>();
            string pk = "";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                pk = (string)row[0];
                string menu = (string)row[1] + (string)row[2];

                menuList.Add(menu);
            }
            Cafeteria cafe = new Cafeteria(pk, menuList);

            return cafe;
        }
    }
}
