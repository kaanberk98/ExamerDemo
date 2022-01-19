using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamerDemo
{
    public class ExamDal
    {

        SqlConnection _connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = EXAMER; integrated security = true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        public List<Exam> GetAll()
        {


           ConnectionControl();
                 
           SqlCommand command = new SqlCommand("Select * from Exam",_connection);

           SqlDataReader reader = command.ExecuteReader();

           List<Exam> exams = new List<Exam>();

            while (reader.Read())
            {
                Exam exam = new Exam {

                    ExamID = reader["ExamID"].ToString(),
                    CourseID = reader["CourseID"].ToString(),
                    ExamName = reader["ExamName"].ToString(),
                    ExamInfo = reader["ExamInfo"].ToString(),
                };

                exams.Add(exam);

            }

            reader.Close();
            _connection.Close();
            return exams;
        }



        public DataTable GetAll2()
        {

           
            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();
            }

            SqlCommand command = new SqlCommand("Select * from Exam", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }



        public void Add(Exam exam)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Exam values(@examID,@courseID,@examName,@examInfo)", _connection);

            command.Parameters.AddWithValue("@examID", exam.ExamID);
            command.Parameters.AddWithValue("@courseID", exam.CourseID);
            command.Parameters.AddWithValue("@examName", exam.ExamName);
            command.Parameters.AddWithValue("@examInfo", exam.ExamInfo);


            command.ExecuteNonQuery();
            _connection.Close();


        }




        public void Update(Exam exam)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Update Exam set ExamName=@examName, ExamInfo=@examInfo where ExamID=@examID", _connection);

            command.Parameters.AddWithValue("@examID", exam.ExamID);
            command.Parameters.AddWithValue("@courseID", exam.CourseID);
            command.Parameters.AddWithValue("@examName", exam.ExamName);
            command.Parameters.AddWithValue("@examInfo", exam.ExamInfo);


            command.ExecuteNonQuery();
            _connection.Close();


        }


        public void Delete(String ExamID)
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete from Exam where ExamID = @examID", _connection);

            command.Parameters.AddWithValue("@examID", ExamID);
            


            command.ExecuteNonQuery();
            _connection.Close();


        }
    }
}
