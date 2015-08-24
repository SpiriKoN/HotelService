using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hotel.Entites;

namespace Hotel.Repository
{
    public class SqlServerRepository : IRepository
    {
        private string _connectionString;

        private string _selectAllRoom = "SELECT * FROM [tblHotelRooms]";

        public SqlServerRepository(string stringConnection)
        {
            _connectionString = stringConnection;
        }


        public List<TypeRoom> GetAllType()
        {
                
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = this._connectionString;
                connection.Open();
                using (SqlCommand command = new SqlCommand(_selectAllRoom, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<TypeRoom> rooms = new List<TypeRoom>();
                        while (reader.Read())
                        {
                            TypeRoom Room = new TypeRoom();
                            Room.Id       = (int)reader["Id"];
                            Room.Quentity = (int)reader["Quentity"];
                            Room.Name     = (string)reader["Name"];
                            Room.Price    = (decimal)reader["Price"];
                            rooms.Add(Room);
                        }
                        return rooms;
                    }
                }
            }
        }

        public void ReserverRoom(string[] valueFields)
        {
            string Insert = @"INSERT INTO tblRoomReservations ([FullName], [HotelRoomId], [Phone], [Email]) VALUES (@FullName, @HotelRoomId, @Phone, @Email)";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = this._connectionString;
                connection.Open();
                using (SqlCommand command = new SqlCommand(Insert, connection))
                {
                    command.Parameters.Add("@FullName", SqlDbType.NVarChar, 255).Value = valueFields[0];
                    command.Parameters.Add("@Phone",    SqlDbType.NVarChar, 255).Value = valueFields[1];
                    command.Parameters.Add("@Email",    SqlDbType.NVarChar, 255).Value = valueFields[2];
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

    }
}
