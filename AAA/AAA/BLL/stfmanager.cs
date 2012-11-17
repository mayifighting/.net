using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class stfmanager
    {
        public static string login_(Stuff stf)
        {
               string str=Stuffs.login(stf);
               return str;
        }
    }
}
