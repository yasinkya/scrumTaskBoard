using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ScrumTaskBoard.DataBase
{
    abstract class Connection
    {
        SqlConnection Baglanti = new SqlConnection();
        string BaglantiAdresi = "Server=.;Database=Hokumus;User Id=sa;Password=123456;";
        SqlConnection Baglanti = new SqlConnection(BaglantiAdresi);
    }
}
