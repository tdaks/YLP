using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 서버_개발
{
    class DBManager
    {
        static String strConn = "Server=localhost;Database=YLP;Uid=root;Pwd=1234;";

        /*
        public void InsertCafeteria(int cafeteria_no, string )
        {
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO CAFETERIA VALUES (1, '성만이네식당', '구로', '010-3167-5265', null)", conn);
            cmd.ExecuteNonQuery();
        }
        */
    }
}
