using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.models
{
    public class Persons
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public int FK_TeamID { get; set; }

        public Persons()
        {

        }
        public Persons(string query, OleDbConnection connection)
        {
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PersonID = reader.GetInt32(0);
                Name = reader.GetString(1);
                Email = reader.GetString(2);
                Role = reader.GetString(3);
                PhoneNumber = reader.GetString(4);
                FK_TeamID = reader.GetInt32(5);
            }
        }
    }
}

