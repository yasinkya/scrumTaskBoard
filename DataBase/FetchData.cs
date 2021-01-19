using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.DataBase
{
    class FetchData:Connection
    {
        public List<Structures.User> UserList()
        {
            try
            {
                List<Structures.User> users = new List<Structures.User>();

                cmd.CommandText = "select * From users";
                cmd.CommandType = CommandType.Text;
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Structures.User user = new Structures.User();
                    user.UserName = reader[0].ToString();
                    user.Password = reader[1].ToString();
                    user.Name = reader[2].ToString();
                    user.Surname = reader[3].ToString();
                    user.Email = reader[4].ToString();
                    user.Status = reader[5].ToString();

                    users.Add(user);
                }

                connect.Close();
                return users;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("error!");
                throw;
            }
            
        }
    }
}
