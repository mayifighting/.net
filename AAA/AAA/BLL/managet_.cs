using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class managet_
    {
        public static string login_(Manager stf)
        {
            string str = Managers.login(stf);
            return str;
        }
    }
}
