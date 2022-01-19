using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamerDemo
{
    public class CourseDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=EXAMER;integrated security = true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        public List<Course> GetAll()
        {


            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Course",_connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Course> Courses = new List<Course>();

            while (reader.Read())
            {
                Course course = new Course
                {
                    CourseID = reader["CourseID"].ToString(),
                    CourseName = reader["CourseName"].ToString(),
                    CourseInfo = reader["CourseInfo"].ToString(),

                };

                Courses.Add(course);

            }

            reader.Close();
            _connection.Close();
            return Courses;
        }

       

        
        public DataTable GetAll2()
        {


            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

            SqlCommand command = new SqlCommand("Select * from Course", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

    

        public void Add(Course course)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Course values(@courseID,@courseName,@courseInfo)", _connection);
            command.Parameters.AddWithValue("@courseID", course.CourseID);
            command.Parameters.AddWithValue("@courseName", course.CourseName);
            command.Parameters.AddWithValue("@courseInfo", course.CourseInfo);

            command.ExecuteNonQuery();
            _connection.Close();
        }




        public void Update(Course course)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Course set CourseName=@courseName, CourseInfo=@courseInfo where CourseID = @courseID", _connection);
            command.Parameters.AddWithValue("@courseID", course.CourseID);
            command.Parameters.AddWithValue("@courseName", course.CourseName);
            command.Parameters.AddWithValue("@courseInfo", course.CourseInfo);

            command.ExecuteNonQuery();
            _connection.Close();
        }



        public void Delete(String CourseID)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Course where CourseID = @courseID", _connection);
            command.Parameters.AddWithValue("@courseID", CourseID);

            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
