using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class SchoolDal
    {
        SqlConnection _con = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Education; integrated security=true");
        private void Connection()
        {
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
        }
        public List<School> GetAll()
        {
            Connection();
            SqlCommand command = new SqlCommand("Select * from Schools", _con);

            SqlDataReader reader = command.ExecuteReader();

            List<School> schools = new List<School>();
            while (reader.Read())
            {
                School school = new School
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    City = reader["City"].ToString(),
                    District = reader["District"].ToString(),
                    Type = reader["Type"].ToString()
                };
                schools.Add(school);
            }
            reader.Close();
            _con.Close();
            return schools;

        }

        public DataTable GetAll2()
        {
            SqlConnection _con = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Education; integrated security=true");
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Schools", _con);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _con.Close();
            return dataTable;

        }

        public void Add(School school)
        {
            Connection();
            SqlCommand command = new SqlCommand("Insert into Schools values(@name,@city,@district,@type)",_con);
            command.Parameters.AddWithValue("@name", school.Name);
            command.Parameters.AddWithValue("@city", school.City);
            command.Parameters.AddWithValue("@district", school.District);
            command.Parameters.AddWithValue("@type", school.Type);

            command.ExecuteNonQuery();
            _con.Close();
        }

        public void Update(School school)
        {
            Connection();
            SqlCommand command = new SqlCommand
                ("Update Schools set Name=@name,City=@city,District=@district,Type=@type where Id=@id", _con);
            command.Parameters.AddWithValue("@name", school.Name);
            command.Parameters.AddWithValue("@city", school.City);
            command.Parameters.AddWithValue("@district", school.District);
            command.Parameters.AddWithValue("@type", school.Type);
            command.Parameters.AddWithValue("@id", school.Id);

            command.ExecuteNonQuery();
            _con.Close();
        }

        public void Delete(int id)
        {
            Connection();
            SqlCommand command = new SqlCommand
                ("Delete from Schools where Id=@id", _con);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            _con.Close();
        }
    }
}
