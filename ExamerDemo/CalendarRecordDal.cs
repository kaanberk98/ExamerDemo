using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExamerDemo
{
    public class CalendarRecordDal
    {


        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=EXAMER;integrated security = true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }


        public List<CalendarRecord> GetAll()
        {


            ConnectionControl();
            

            SqlCommand command = new SqlCommand("Select * from CalendarRecord",_connection);

            SqlDataReader reader = command.ExecuteReader();

            List<CalendarRecord> calendarRecords = new List<CalendarRecord>();

            while (reader.Read())
            {

                CalendarRecord calendarRecord = new CalendarRecord {

                    RecordNo = Convert.ToInt32(reader["RecordNo"]),
                    ExamDateTime = reader["ExamDateTime"].ToString(),
                    ExamDurationMinute = Convert.ToInt32(reader["ExamDurationMinute"]),
                    EroomID = reader["EroomID"].ToString(),
                    ExamID= reader["ExamID"].ToString(),


                };

                calendarRecords.Add(calendarRecord);


            }



            reader.Close();
            _connection.Close();
            return calendarRecords;

        }



        public DataTable GetAll2()
        {

            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }

            SqlCommand command = new SqlCommand("Select * from CalendarRecord", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;

        }




        public void Add(CalendarRecord calendarRecord)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into CalendarRecord values(@examDateTime,@examDurationMinute,@eroomID,@examID)",_connection);

            command.Parameters.AddWithValue("@examDateTime", calendarRecord.ExamDateTime);
            command.Parameters.AddWithValue("@examDurationMinute", calendarRecord.ExamDurationMinute);
            command.Parameters.AddWithValue("@eroomID", calendarRecord.EroomID);
            command.Parameters.AddWithValue("@examID", calendarRecord.ExamID);

            command.ExecuteNonQuery();
            _connection.Close();




        }




        public void Update(CalendarRecord calendarRecord)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Update CalendarRecord set ExamDateTime=@examDateTime, ExamDurationMinute=@examDurationMinute where RecordNo=@recordNo", _connection);

            command.Parameters.AddWithValue("@recordNo", calendarRecord.RecordNo);
            command.Parameters.AddWithValue("@examDateTime", calendarRecord.ExamDateTime);
            command.Parameters.AddWithValue("@examDurationMinute", calendarRecord.ExamDurationMinute);
            command.Parameters.AddWithValue("@eroomID", calendarRecord.EroomID);
            command.Parameters.AddWithValue("@examID", calendarRecord.ExamID);

            command.ExecuteNonQuery();
            _connection.Close();




        }




        public void Delete(String RecordNo)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from CalendarRecord where RecordNo=@recordNo", _connection);
            command.Parameters.AddWithValue("@recordNo", RecordNo);


            command.ExecuteNonQuery();
            _connection.Close();




        }
    }
}
