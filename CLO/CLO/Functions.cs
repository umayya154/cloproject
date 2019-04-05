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
            return Regex.IsMatch(str, @"^([a-zA-Z ]*?)$"))
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
        /*
        public string status_Name(int status)"^[0-9]+$"@"^[a-zA-Z0-9_]+$
        {
            Database database = new Database();
            string status_ = "";
            string query = @"SELECT LookupId FROM Lookup WHERE Name = '" + status + "';";
            SqlDataReader reader = database.DataReader(query);
            while (reader.Read())   // This is how record is read. Loop through the each record
            {
                status_ = reader["LookupId"].ToString();
            }
            return status_;
        }
        public int status_in_id(string status)
        {
            Database database = new Database();
            string query = @"SELECT LookupId FROM Lookup WHERE Name = '" + status + "';";
            int status_ = database.DataReaderid(query);
            return status_;
        }


        public int addStudent(string firstname, string lastname, string contact, string email, string registration_no, string status)
        {

            try
            {
                //string ConnectionString = @"Data Source=NUMAIR;Initial Catalog=ProjectB;Integrated Security=True";
                Database database = new Database();
                lookup lookupclass = new lookup();
                //db.setConection_string(ConnectionString);
                int status_ = lookupclass.status_in_id(status);
                string query = @"INSERT INTO Student ( FirstName, LastName , Contact , Email , RegistrationNumber ,Status) VALUES ('" + firstname + "', '" + lastname + "', '" + contact + "', '" + email + "', '" + registration_no + "', '" + status_ + "'); ";
                int rows = database.ExecuteQueries(query);
                return rows;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
              //  db.CloseConnection();
            }
        }
        public int deletestd(int id)
        {
            try
            {
                Database database = new Database();
                //string ConnectionString = @"Data Source=NUMAIR;Initial Catalog=ProjectB;Integrated Security=True";
                //database.setConection_string(ConnectionString);
                string query = "DELETE FROM student WHERE Id = " + id + ";";
                int rows = database.ExecuteQueries(query);
                return rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
               // db.CloseConnection();
            }

        }*/
    }
}
