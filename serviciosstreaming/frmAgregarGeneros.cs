using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elementos;

namespace serviciosstreaming
{
    public partial class frmAgregarGeneros : Form
    {
        public frmAgregarGeneros()
        {
            InitializeComponent();
            mostrar();
            label1.Text = this.Text;
        }
        Consultas query = new Consultas();
        private void mostrar()
        {
            dgv.DataSource = query.obtenerTabla("SELECT nombreGenero 'Genero' FROM generos");
            dgv.Columns[0].Width = 180;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTexto_MouseLeave(object sender, EventArgs e)
        {
            if (txtTexto.Text == "") txtTexto.Text = "Genero";
        }

        private void txtTexto_MouseEnter(object sender, EventArgs e)
        {
            if (txtTexto.Text == "Genero") txtTexto.Clear();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Para mover la forma sin borde
        int posicion_x = 0, posicion_y = 0;

        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarGeneros_MouseMove(object sender, MouseEventArgs e)
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
