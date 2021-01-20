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
        
        public List<Structures.User> UserList() //FETCH USER LIST 
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

        public List<Structures.Project> ProjectList()   //FETCH PROJECT LIST 
        {
            try
            {
                List<Structures.Project> projects= new List<Structures.Project>();

                cmd.CommandText = "select * From projects";
                cmd.CommandType = CommandType.Text;
                connect.Open();
                dataR = cmd.ExecuteReader();

                while (dataR.Read())
                {
                    Structures.Project project= new Structures.Project();
                    project.ProjectId = Convert.ToInt32(dataR[0].ToString());
                    project.ProjectName = dataR[1].ToString();
                    project.ProjectImportance = dataR[2].ToString();

                    projects.Add(project);
                }

                connect.Close();
                return projects;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("error!");
                throw;
            }

        }



    }
}
