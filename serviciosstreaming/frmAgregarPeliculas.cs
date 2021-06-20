using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Elementos;
using MySql.Data.MySqlClient;

namespace serviciosstreaming
{
    public partial class frmAgregarPeliculas : Form
    {
        Consultas consultas = new Consultas();
        DataTable dt;
        public frmAgregarPeliculas()
        {
            InitializeComponent();
            //Carga categorias, actores, directores
            cargarElementos();
            label1.Text = this.Text;
        }
        Consultas query = new Consultas();
        void cargarElementos()
        {
            dgv.DataSource = consultas.obtenerTabla("SELECT nombrePelicula 'Pelicula', descripcionPelicula 'Descripcion' FROM peliculas");
        }
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            //textodeformato(*.formato) | *.formato | otroformato(*.formato2 *) | *.formato2
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Archivos jpg(*.jpg)|*.jpg| Archivos png(*.png)|*.png";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ptbFotoPelicula.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                consultas.cmd.Connection = consultas.cn;
                MemoryStream ms = new MemoryStream();
                //Insertamos
                consultas.cmd.CommandText = "CALL insertarPelicula ('" + txtPelicula.Text + "','" + richDescripcion.Text + "',@portada)";
                ptbFotoPelicula.Image.Save(ms, ImageFormat.Jpeg);
                consultas.cmd.Parameters.Add(new MySqlParameter("@portada", ms.GetBuffer()));
                consultas.cn.Open();
                consultas.cmd.ExecuteNonQuery();
                consultas.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la pelicula " + ex);
            }
            finally
            {
                MessageBox.Show("Se logro insertar la pelicula");
                txtPelicula.Clear();
                richDescripcion.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            query.Consulta("DELETE FROM peliculas WHERE nombrePelicula = '" + dgv.CurrentCell.Value + "'");
            cargarElementos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            query.Consulta("UPDATE peliculas set nombrePelicula = '" + txtPelicula.Text + "', descripcionPelicula = '" + richDescripcion.Text + "' WHERE nombrePelicula ='" + dgv.CurrentCell.Value + "'");
            cargarElementos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = consultas.obtenerTabla("SELECT nombrePelicula 'Pelicula', descripcionPelicula 'Descripcion' FROM peliculas WHERE nombrePelicula = '"+txtPelicula.Text+"'");
        }
        //Para mover la forma sin borde
        int posicion_x = 0, posicion_y = 0;

        private void btnMás_Click(object sender, EventArgs e)
        {
            frmEditarPelicula frmEditarPelicula = new frmEditarPelicula();
            frmEditarPelicula.Show();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarPeliculas_MouseMove(object sender, MouseEventArgs e)
        {
            //Si Boton izquierdo esta activo
            if (e.Button != MouseButtons.Left)
            {
                //Posicion del boton se mandara a posicion de la ventana respecto a la pantalla
                posicion_x = e.X;
                posicion_y = e.Y;
            }
            else
            {
                Left = Left + (e.X - posicion_x);
                Top = Top + (e.Y - posicion_y);
            }
        }
    }
}