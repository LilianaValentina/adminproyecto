using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elementos
{

    public class Consultas
    {

        public MySqlConnection cn = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();
        private DataTable dt;
        private MySqlDataAdapter da;
        
        /// <summary> 
        /// Realiza una conexion a la tabla
        /// </summary>
        public Consultas()
        {
            try
            {
                cn = new MySqlConnection("server=usla641.gamedata.io; database=ni5508816_1_DB; Uid=ni5508816_1_DB; pwd=y0GuL29g; ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se logro acceder a la base de datos" + ex);
            }
        }

        /// <summary> 
        /// Recibe solo 1 parametro, para consulta sobre insertar, borrar o modificar
        /// </summary>
        public void Consulta(string consulta)
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(consulta, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro insertar:" + ex);
            }
        }
        /// <summary>
        /// Sirve para mostrar una consulta como SELECT entero o individual
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns>Una tabla</returns>
        public DataTable obtenerTabla(string consulta)
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(consulta, cn);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se obtener:" + ex);
                return null;
            }
        }
    }
}
