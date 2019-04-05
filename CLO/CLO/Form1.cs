using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CLO
{
    public partial class fmCLO : Form
    {
        string ConnectionString = "Data Source=NUMAIR;Initial Catalog=ProjectB;Integrated Security=True";
        
        SqlConnection con = new SqlConnection("Data Source=NUMAIR;Initial Catalog=ProjectB;Integrated Security=True");
        public fmCLO()
        {
            InitializeComponent();
        }
        
        /*

        public int ExecuteQueries(string Query_)
        {

            //con = new SqlConnection(connectionString);
            //this.openConnection();
            //con = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand(Query_, con);
            return cmd.ExecuteNonQuery();

        }


        public SqlDataReader DataReader(string Query_)
        {

            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }*/

        public int DataReaderid(string Query_)
        {

            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader reader = null;
            int id = 0;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();

            return id;
        }


        public object ShowDataInGridView(string Query_)
        {

            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];

            return dataum;
        }
        public string status_Name(int status)
        {
            string status_ = "";
            string query = @"SELECT LookupId FROM Lookup WHERE Name = '" + status + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader reader = dr;
            while (reader.Read())   
            {
                status_ = reader["LookupId"].ToString();
            }
            return status_;
        }
        public int status_in_id(string status)
        {

            string query = @"SELECT LookupId FROM Lookup WHERE Name = '" + status + "';";
            int status_ = DataReaderid(query);
            return status_;
        }
        private void btnstdadd_Click(object sender, EventArgs e)
        {
            con.Open();
            Functions function = new Functions();
            int status_ = function.status_in_id(cmbstdstatus.Text);
            string query = @"INSERT INTO Student ( FirstName, LastName , Contact , Email , RegistrationNumber ,Status) VALUES ('" + txtstdfirstname.Text + "', '" + txtstdlastname.Text + "', '" + txtstdcontact.Text + "', '" + txtstdemail.Text + "', '" + txtstdregistrationNo.Text + "', '" + status_ + "'); ";
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                GVStudent.DataSource = ShowDataInGridView("SELECT * FROM Student;");
                lblRecord.Text = "Student Records";
                MessageBox.Show("Student data is successfully save");
            }else
               {
                    MessageBox.Show("somthing wrong");
               }
            con.Close();

        }
        
        
    private void Form1_Load(object sender, EventArgs e)
        {
           
            GVStudent.DataSource = ShowDataInGridView("SELECT * FROM Student;");
            lblRecord.Text = "Student Records";
            //GVStudent.Columns[0].Visible = false;
            //addbutton_gridview("Update", GVStudent);
            //addbutton_gridview("Dalete", GVStudent);
            //db.CloseConnection();
        }
       
        

        private void GVStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(lblRecord == "")
            {

            }
            /*
            Functions student = new Functions();
            //int rows = GVStudent.Rows.Count;
            
            int selectedRow = GVStudent.CurrentCell.RowIndex;
            int cell = GVStudent.CurrentCell.ColumnIndex;
            int id = (int)(GVStudent.Rows[selectedRow].Cells[0].Value);
            string value = GVStudent.Rows[selectedRow].Cells[cell].Value.ToString();
            MessageBox.Show(value);
             if (GVStudent.CurrentRow.HeaderCell.Value.ToString() == "Delete")
            {
                int r = student.deletestd(id);
                MessageBox.Show(r.ToString());
                GVStudent.Rows.RemoveAt(selectedRow);
            }
            //}else
             if (value == "Update")
            {

            }*/
        }

        private void GVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void tabRubriclevel_Click(object sender, EventArgs e)
        {
            GVStudent.DataSource = ShowDataInGridView("SELECT * FROM RublicLevel;");
            lblRecord.Text = "Student Records";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabStudent_Click(object sender, EventArgs e)
        {
            GVStudent.DataSource = ShowDataInGridView("SELECT * FROM Student;");
            lblRecord.Text = "Student Records";
        }

        private void tabclo_Click(object sender, EventArgs e)
        {
            GVStudent.DataSource = ShowDataInGridView("SELECT * FROM Clo;");
            lblRecord.Text = "CLO Records";
        }

        private void tabRubric_Click(object sender, EventArgs e)
        {
            GVStudent.DataSource = ShowDataInGridView("SELECT * FROM Rubric;");
            lblRecord.Text = "Rubic Records";
        }

        private void tabAssessmentComponent_Click(object sender, EventArgs e)
        {
            GVStudent.DataSource = ShowDataInGridView("SELECT * FROM AssessmentComponent;");
            lblRecord.Text = "Assessment Components Records";
        }

        private void tabassessment_Click(object sender, EventArgs e)
        {
            GVStudent.DataSource = ShowDataInGridView("SELECT * FROM Assessment;");
            lblRecord.Text = "Assessment Records";
        }

        private void tabStudentAttendance_Click(object sender, EventArgs e)
        {
            GVStudent.DataSource = ShowDataInGridView("Select Student.RegistrationNumber, Student.FirstName,StudentAttendance.StudentId, StudentAttendance.AttendanceStatus from Student inner join StudentAttendance on Student.Id=StudentAttendance.StudentId;"");
            lblRecord.Text = "StudentAtttendance Records";
        }
    }
}
