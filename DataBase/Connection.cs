using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ScrumTaskBoard.DataBase
{
    abstract class Connection
    {
        public SqlConnection connect;
        public SqlCommand cmd;
        public SqlDataReader dataR;

        public Connection()
        {
            
            Connect();
        }

        public void Connect()
        {
            connect = new SqlConnection("server=KAYA; Initial Catalog=ScrumTaskBoard;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = connect;
        }

        
    }
}
