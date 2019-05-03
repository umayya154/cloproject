using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace CLO
{
    class Functions
    {
        public bool charonly(string str)
        {
            return Regex.IsMatch(str, @"^([a-zA-Z ]*?)$");
        }
        public bool numberonly(string str)
        {
            return Regex.IsMatch(str, @"^(([+]{1}[0-9]{2}|0)[0-9]{9})$");
        }
        public bool mailonly(string str)
        {
            return Regex.IsMatch(str, @"^ (([\w -] +\.) +[\w -] +| ([a - zA - Z]{ 1}|[\w -]{ 2,}))@"
     + @"((([0 - 1]?[0 - 9]{ 1,2}| 25[0 - 5] | 2[0 - 4][0 - 9])\.([0 - 1]?
                              [0 - 9]{ 1,2}| 25[0 - 5] | 2[0 - 4][0 - 9])\."
                               + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                               + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$");
        }
        public bool intonly(string str)
        {
            return Regex.IsMatch(str, @" ^[0-9]+$");
        }
        public bool registrationon(string str)
        {
            return Regex.IsMatch(str, @"^[a - zA - Z0 - 9] + $");
        }
       
    }
}
