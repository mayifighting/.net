using System;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using Model;
namespace DAL
{
    public class Managers
    {
        public static string login(Manager mag)//判断经理用户名密码是否一致
        {
            string str = "";
            SqlDataReader sqlrd;
            DataBase db = new DataBase();
            string sql = "select tKey from tb_Manager where Name='" + mag.Name + "'";
            sqlrd = db.GetDataReader(sql);
            while (sqlrd.Read())
            {
                str = (string)(sqlrd["tKey"]);
            }
            return str;
        }
    }
}
