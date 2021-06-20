using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Elementos
{
    public partial class ucLog : UserControl
    {
        public ucLog()
        {
            InitializeComponent();
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, 0);
            panel3.Location = new Point(0, 0);

            panel3.Hide();
            panel2.Hide();
        }
        Consultas query = new Consultas();
        ErrorProvider ep = new ErrorProvider();
        public object id { get; private set; }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Consulta para obtener los usuarios
            string consulta = string.Format("SELECT * FROM usuarios WHERE nombreUsuario = '" + txtUsuario.Text.Trim() + "' AND contrasenaUsuario = '" + txtPass.Text.Trim() + "'");

            //Aqui obtenemos la tabla de la consulta
            DataTable dt = query.obtenerTabla(consulta);

            //Sustraemos los datos de la consulta
            id = dt.Rows[0]["idUsuario"].ToString().Trim();
            string account = dt.Rows[0]["nombreUsuario"].ToString().Trim();
            string pass = dt.Rows[0]["contrasenaUsuario"].ToString().Trim();

            /* Si los datos almacenados en las variables corresponden a los mismo que los ingresados en
               las cajas de texto entonces nos lanza el formulario principal */
            if (account == txtUsuario.Text.Trim() && pass == txtPass.Text.Trim())
            {
                MessageBox.Show("Funciona");
            }
            else
            {
                MessageBox.Show("Hubo un error, intentalo de nuevo más tarde.");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validarcampos())
            {
                query.Consulta("CALL insertarUsuario ('" + txtUser.Text + "', '" + txtPassword.Text + "')");
            }
        }

        #region Complementos para el funcionamiento
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* Para que la casilla donde se ingres ala contraseña pueda ser visible 
               para el usuario */
            if (checkBox1.Checked == true)
            {
                if (txtPassword.PasswordChar == '*' && txtPasswordC.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                    txtPasswordC.PasswordChar = '\0';
                }
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPasswordC.PasswordChar = '*';
            }
        }
        private bool Validarcampos()
        {
            bool ok = false;
            if (txtUser.Text == "" || txtUser.Text == null)
                ep.SetError(txtUser, "Ingrese cuenta");
            else if (txtPassword.Text == "" || txtPassword.Text == null)
                ep.SetError(txtPassword, "Ingrese contraseña");
            else if (txtPassword.Text != txtPasswordC.Text)
                ep.SetError(txtPasswordC, "Las contraseñas no concuerdan.");
            else
                ok = true;
            return ok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Registrarse
            panel1.Hide();
            panel2.Show();panel2.Location = new Point(0, 0);
            panel3.Hide();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Iniciar sesion
            panel1.Hide();
            panel2.Hide();
            panel3.Show();panel3.Location = new Point(0, 0);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Patras de registrarse
            panel2.Hide();
            panel1.Show();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Patras de iniciar sesion
            panel3.Hide();
            panel1.Show();
        }
        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            /* Para que la casilla donde se ingres ala contraseña pueda ser visible 
              para el usuario */
            if (cbMostrar.Checked == true)
            {
                if (txtPass.PasswordChar == '*')
                {
                    txtPass.PasswordChar = '\0';
                }
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
        #endregion

        private void lblPreguntaRegistro_Click(object sender, EventArgs e)
        {
            //Ir al inico de sesión
            panel2.Hide();
            panel3.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblPreguntaInicio_Click(object sender, EventArgs e)
        {
            //Ir al registro de usuario
            panel3.Hide();
            panel2.Show();
        }
    }
}