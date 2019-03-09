using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace dbmslab4
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dburl = @"Data Source=DESKTOP-CKQK4QS\SQLEXPRESS;Initial Catalog=NorthWind;Integrated Security=True";
            SqlConnection dbcon = new SqlConnection(dburl);
            dbcon.Open();
            string qry = "select * from Customers;";
            SqlCommand sqlcmd = new SqlCommand(qry, dbcon);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader[0] + ", " + reader[1] + ", " + reader[2]);
            }
            dbcon.Close();
        }
    }
}
