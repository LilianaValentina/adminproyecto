using Elementos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class frmEditarPelicula : Form
    {
        public frmEditarPelicula()
        {
            InitializeComponent();
            cargarElementos();
        }
        Consultas consultas = new Consultas();
        void cargarElementos()
        {
            DataTable dt = consultas.obtenerTabla("SELECT nombrePelicula FROM peliculas");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPeliculas.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = consultas.obtenerTabla("SELECT nombreGenero FROM generos");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneros.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = consultas.obtenerTabla("SELECT nombreActor FROM actores");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbActores.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = consultas.obtenerTabla("SELECT nombreDirector FROM directores");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbDirectores.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            dt = consultas.obtenerTabla("SELECT nombrePlataforma FROM plataformas");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void cbPeliculas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.SelectedItem.ToString() + "'");
            string idPelicula = dt.Rows[0]["idPelicula"].ToString().Trim();

            cbGeneroPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarGeneros(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneroPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            cbActorPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarActores(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbActorPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            cbPlataformaPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarPlataformas(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformaPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            cbDirectorPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarDirectores(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbDirectorPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void btnAgregarGenero_Click(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.Text + "'");
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            dt = consultas.obtenerTabla("SELECT idGenero FROM generos WHERE nombreGenero = '" + cbGeneros.Text + "'");
            string idGenero = dt.Rows[0].ItemArray[0].ToString().Trim();

            consultas.Consulta("CALL insertarCategoria(" + idPelicula + "," + idGenero + ")");

            cbGeneroPelicula.Items.Clear();

            cbGeneroPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarGeneros(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneroPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void btnAgregarActor_Click(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.Text + "'");
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            dt = consultas.obtenerTabla("SELECT idActor FROM actores WHERE nombreActor = '" + cbActores.Text + "'");
            string idActor = dt.Rows[0].ItemArray[0].ToString().Trim();

            consultas.Consulta("CALL insertarInterpretes(" + idActor + "," + idPelicula + ")");

            cbActorPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarActores(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbActorPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void btnAgregarDirectore_Click(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.Text + "'");
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            dt = consultas.obtenerTabla("SELECT idDirector FROM directores WHERE nombreDirector = '" + cbDirectores.Text + "'");
            string idDirector = dt.Rows[0].ItemArray[0].ToString().Trim();

            consultas.Consulta("CALL insertarCordinadores(" + idPelicula + "," + idDirector + ")");

            cbDirectorPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarDirectores(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbDirectorPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void btnAgregarPlataforma_Click(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.Text + "'");
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            dt = consultas.obtenerTabla("SELECT idPlataforma FROM plataformas WHERE nombrePlataforma = '" + cbPlataformas.Text + "'");
            string idPlataforma = dt.Rows[0].ItemArray[0].ToString().Trim();

            consultas.Consulta("CALL insertarContiene(" + idPelicula + "," + idPlataforma + ")");

            cbPlataformaPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarPlataformas(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformaPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void btnEliminarGenero_Click(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.Text + "'");
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            dt = consultas.obtenerTabla("SELECT idGenero FROM generos WHERE nombreGenero = '" + cbGeneroPelicula.Text + "'");
            string idGenero = dt.Rows[0].ItemArray[0].ToString().Trim();

            consultas.Consulta("DELETE FROM categorias WHERE idPelicula = '" + idPelicula + "' AND idGenero = '" + idGenero + "'");

            cbGeneroPelicula.Items.Clear();

            cbGeneroPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarGeneros(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbGeneroPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            cbGeneroPelicula.Text = "";
        }

        private void btnEliminarActor_Click(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.Text + "'");
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            dt = consultas.obtenerTabla("SELECT idActor FROM actores WHERE nombreActor = '" + cbActorPelicula.Text + "'");
            string idActor = dt.Rows[0].ItemArray[0].ToString().Trim();

            consultas.Consulta("DELETE FROM interpretes WHERE idPelicula = '" + idPelicula + "' AND idActor = '" + idActor + "'");

            cbActorPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarActores(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbActorPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            cbActores.Text = "";
        }

        private void btnEliminarDirector_Click(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.Text + "'");
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            dt = consultas.obtenerTabla("SELECT idDirector FROM directores WHERE nombreDirector = '" + cbDirectorPelicula.Text + "'");
            string idDirector = dt.Rows[0].ItemArray[0].ToString().Trim();

            consultas.Consulta("DELETE FROM cordinadores WHERE idPelicula = '" + idPelicula + "' AND idDirector = '" + idDirector + "'");

            cbDirectorPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarDirectores(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbDirectorPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            cbDirectorPelicula.Text = "";
        }

        private void btnEliminarPlataforma_Click(object sender, EventArgs e)
        {
            DataTable dt = consultas.obtenerTabla("SELECT idPelicula FROM peliculas WHERE nombrePelicula = '" + cbPeliculas.Text + "'");
            string idPelicula = dt.Rows[0].ItemArray[0].ToString().Trim();

            dt = consultas.obtenerTabla("SELECT idPlataforma FROM plataformas WHERE nombrePlataforma = '" + cbPlataformaPelicula.Text + "'");
            string idPlataforma = dt.Rows[0].ItemArray[0].ToString().Trim();

            consultas.Consulta("DELETE FROM contiene WHERE idPelicula = '" + idPelicula + "' AND idPlataforma = '" + idPlataforma + "'");

            cbPlataformaPelicula.Items.Clear();
            dt = consultas.obtenerTabla("CALL mostrarPlataformas(" + idPelicula + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPlataformaPelicula.Items.Add(dt.Rows[i].ItemArray[0].ToString());

            cbPlataformaPelicula.Text = "";
        }
        //Para mover la forma sin borde
        int posicion_x = 0, posicion_y = 0;

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditarPelicula_MouseMove(object sender, MouseEventArgs e)
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
