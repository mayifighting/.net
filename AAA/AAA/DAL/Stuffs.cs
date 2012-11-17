using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using Model;
namespace DAL
{
    public class Stuffs
    {
        public static string  login(Stuff stf)//判断员工用户名密码是否一致
        {
            string str="";
            SqlDataReader sqlrd;
            DataBase  db = new DataBase();
            string sql = "select tKey from tb_Stuff where Name='" + stf.Name + "'";
            sqlrd=db.GetDataReader(sql);
            while(sqlrd.Read ())
            {
                str = (string)(sqlrd["tKey"]); 
            }
            return str;
        }
    }
}
