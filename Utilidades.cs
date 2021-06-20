using System.Data;
using System.Data.SqlClient;

namespace Libary
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-560QHQJK;Integrated Security=SSPI;Initial Catalog=PeliculasWeb");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);
            Con.Close();

            return DS;
        }

    }
}
