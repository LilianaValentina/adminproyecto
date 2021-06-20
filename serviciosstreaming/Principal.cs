using Elementos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class Principal : Form
    {
        Consultas consultas = new Consultas();
        public Principal(string id)
        {
            InitializeComponent();
            DataTable dt = consultas.obtenerTabla("SELECT nombreUsuario FROM usuarios WHERE idUsuario = '" + id + "'");
            btnUsuarioLogeado.Text = dt.Rows[0]["nombreUsuario"].ToString().Trim();
            Diseno();
        }
        private void Diseno()
        {
            panel2.Visible = false;
        }
        private void hide()
        {
            if(panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
        private void Show(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hide();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Show(panel2);
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = consultas.obtenerTabla("SELECT idPelicula, portadaPelicula FROM peliculas");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Name = dt.Rows[i].ItemArray[0].ToString();
                pb.Size = new Size(134, 182);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Cursor = Cursors.Hand;

                byte[] MisDatos = new byte[0];
                
                MisDatos = (byte[])dt.Rows[i]["portadaPelicula"];
                MemoryStream ms = new MemoryStream(MisDatos);
                pb.Image = Image.FromStream(ms);
                ms.Position = 0;

                pb.Click += new EventHandler(mostrar_click);
                flpPeliculas.Controls.Add(pb);
            }
        }

        private void mostrar_click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            string id = pictureBox.Name.ToString();

            frmMostrarPelicula frmMostrarPelicula = new frmMostrarPelicula(id);
            frmMostrarPelicula.Show();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            frmAgregarPeliculas agregarPeliculas = new frmAgregarPeliculas();
            agregarPeliculas.Show();
        }

        private void btnDirectores_Click(object sender, EventArgs e)
        {
            frmAgregarDirectores agregarDirectores = new frmAgregarDirectores();
            agregarDirectores.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmAgregarGeneros agregarGeneros = new frmAgregarGeneros();
            agregarGeneros.Show();
        }

        private void btnPlataforma_Click(object sender, EventArgs e)
        {
            frmAgregarPlataforma agregarPlataforma = new frmAgregarPlataforma();
            agregarPlataforma.Show();
        }

        private void btnActores_Click(object sender, EventArgs e)
        {
            frmAgregarActores agregarActores = new frmAgregarActores();
            agregarActores.Show();
        }

        private void btnTipos_Click(object sender, EventArgs e)
        {
            frmAgregarTipos agregarTipos = new frmAgregarTipos();
            agregarTipos.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            frmInicio inicio = new frmInicio();
            inicio.Show();
        }
    }
}