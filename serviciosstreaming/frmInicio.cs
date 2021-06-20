using System;
using System.Windows.Forms;

namespace serviciosstreaming
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Para mover la forma sin borde
        int posicion_x = 0, posicion_y = 0;

        private void frmInicio_MouseMove(object sender, MouseEventArgs e)
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
