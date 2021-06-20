using System;
using System.Windows.Forms;
using Elementos;

namespace serviciosstreaming
{
    public partial class frmAgregarActores : Form
    {
        public frmAgregarActores()
        {
            InitializeComponent();
            mostrarActores();
            label1.Text = this.Text;
        }
        Consultas query = new Consultas();
        private void mostrarActores()
        {
            dgv.DataSource = query.obtenerTabla("SELECT nombreActor 'Nombre del Actor' FROM actores");
            dgv.Columns[0].Width = 180;
        }
        private void btnAgregarActor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarActor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditarActor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarActor_Click(object sender, EventArgs e)
        {
            
        }

        private void txtActor_MouseEnter(object sender, EventArgs e)
        {
            if (txtActor.Text == "Nombre del Actor") txtActor.Clear();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtActor_MouseLeave(object sender, EventArgs e)
        {
            if (txtActor.Text == "") txtActor.Text = "Nombre del Actor";
        }

        //Para mover la forma sin borde
        int posicion_x = 0, posicion_y = 0;
        private void frmAgregarActores_MouseMove(object sender, MouseEventArgs e)
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
