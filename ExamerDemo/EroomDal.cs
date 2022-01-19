using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamerDemo
{
    public class EroomDal
    {

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=EXAMER;integrated security = true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }




        public List<Eroom> GetAll()
        {



            ConnectionControl();


            SqlCommand command = new SqlCommand("Select * from Eroom",_connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Eroom> erooms = new List<Eroom>();

            while (reader.Read())
            {
                Eroom eroom = new Eroom {

                    EroomID = reader["EroomID"].ToString(),
                    EroomCapacity = Convert.ToInt32(reader["EroomCapacity"]),
                    EroomInfo = reader["EroomInfo"].ToString(),
                
                };

                erooms.Add(eroom);

            }

            reader.Close();
            _connection.Close();
            return erooms;

        }




        public DataTable GetAll2()
        {


            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }


            SqlCommand command = new SqlCommand("Select * from Eroom", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;

        }




        public void Add(Eroom eroom)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Eroom values(@eroomID,@eroomCapacity,@eroomInfo)", _connection);
            command.Parameters.AddWithValue("@eroomID", eroom.EroomID);
            command.Parameters.AddWithValue("@eroomCapacity", eroom.EroomCapacity);
            command.Parameters.AddWithValue("@eroomInfo", eroom.EroomInfo);

            command.ExecuteNonQuery();
            _connection.Close();




        }





        public void Update(Eroom eroom)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Eroom set EroomCapacity=@eroomCapacity,EroomInfo=@eroomInfo where EroomID=@eroomID", _connection);
            command.Parameters.AddWithValue("@eroomID", eroom.EroomID);
            command.Parameters.AddWithValue("@eroomCapacity", eroom.EroomCapacity);
            command.Parameters.AddWithValue("@eroomInfo", eroom.EroomInfo);

            command.ExecuteNonQuery();
            _connection.Close();




        }



        public void Delete(String EroomID)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Eroom where EroomID=@eroomID", _connection);
            command.Parameters.AddWithValue("@eroomID", EroomID);
            

            command.ExecuteNonQuery();
            _connection.Close();




        }
    }
}
