using Elementos;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class frmMostrarPelicula : Form
    {
        DataTable dt;
        Consultas consultas = new Consultas();
        public frmMostrarPelicula(string idPelicula)
        {
            InitializeComponent();
            cargarPortada(idPelicula);
            cargarComentarios(idPelicula);
            cargarDatos(idPelicula);
        }
        Consultas query = new Consultas();
        void cargarPortada(string id)
        {
            dt = query.obtenerTabla("SELECT idPelicula, portadaPelicula FROM peliculas WHERE idPelicula ="+ id);
            pbPortada.Name = id;
            
            byte[] MisDatos = (byte[])dt.Rows[0]["portadaPelicula"];
            MemoryStream ms = new MemoryStream(MisDatos);
            pbPortada.Image = Image.FromStream(ms);
        }
        void cargarComentarios(string id)
        {
            //Obtenemos la tabla
            DataTable dt = query.obtenerTabla("SELECT *FROM comentarios WHERE idPelicula = " + id);
            //Usamos la cantidad de renglones en contador para asi imprimir uno por uno
            int contador = dt.Rows.Count;
            //Comenzamos a imprimir los comentarios
            for (int i = 0; i < contador; i++)
            {
                //declaramos un comentario nuevo
                //Asi no usamos uno solo para estar sobreescribiendo
                ucComentarios comentario = new ucComentarios();
                //obtenemos la tabla para imprimir el primer comentario
                dt = query.obtenerTabla("SELECT *FROM comentarios WHERE idPelicula = " + id);
                //asignamos el primer comentario al atributo comentario de nuestro control
                comentario.Comentario = dt.Rows[i]["comentario"].ToString();

                //obtenemos la tabla del usuario que comento
                dt = query.obtenerTabla("SELECT *FROM usuarios WHERE idUsuario =" + dt.Rows[i]["idUsuario"].ToString());
                //aqui usamos un ciclo aparte porque la tabla de usuario siempre tendra 1 solo valor porque es el que comento 1 por el id
                for (int j = 0; j < 1; j++)
                {
                    //obtenemos el unico valor de la tabla en el atributo usuario
                    comentario.Usuario = dt.Rows[j]["nombreUsuario"].ToString();
                }
                //Agregar el control (comentario)
                panelComentarios.Controls.Add(comentario);
            }
        }
        void cargarDatos(string id)
        {
            dt = consultas.obtenerTabla("CALL mostrarGeneros(" + id + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneroPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = consultas.obtenerTabla("CALL mostrarActores(" + id + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbActorPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = consultas.obtenerTabla("CALL mostrarDirectores(" + id + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbDirectorPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = consultas.obtenerTabla("CALL mostrarPlataformas(" + id + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformaPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = query.obtenerTabla("SELECT nombrePelicula, descripcionPelicula FROM peliculas WHERE idPelicula =" + id);
            lblPelicula.Text = dt.Rows[0]["nombrePelicula"].ToString();
            richDescripcion.Text = dt.Rows[0]["descripcionPelicula"].ToString();
        }

        private void lblCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //este sirve para realizar el comentario
        }
    }
}