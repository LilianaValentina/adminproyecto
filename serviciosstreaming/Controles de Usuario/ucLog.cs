using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using serviciosstreaming;

namespace Elementos
{
    public partial class ucLog : UserControl
    {
        public ucLog()
        {
            InitializeComponent();
            panelParainiciar.Location = new Point(35, 66);
            panelParaRegistrar.Location = new Point(35, 66);
        }
        Consultas query = new Consultas();
        ErrorProvider ep = new ErrorProvider();
        public string id { get; private set; }
        string account, pass;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Consulta para obtener los usuarios
            string consulta = string.Format("SELECT * FROM usuarios WHERE nombreUsuario = '" + txtUsuario.Text.Trim() + "' AND contrasenaUsuario = '" + txtPass.Text.Trim() + "'");

            //Aqui obtenemos la tabla de la consulta
            DataTable dt = query.obtenerTabla(consulta);
            try
            {
                //Sustraemos los datos de la consulta
                id = dt.Rows[0]["idUsuario"].ToString().Trim();
                account = dt.Rows[0]["nombreUsuario"].ToString().Trim();
                pass = dt.Rows[0]["contrasenaUsuario"].ToString().Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos fueron ingresados incorrectamente, vuelta a intentarlo.");
            }
            /* Si los datos almacenados en las variables corresponden a los mismo que los ingresados en
               las cajas de texto entonces nos lanza el formulario principal */
            if (account == txtUsuario.Text.Trim() && pass == txtPass.Text.Trim())
            {
                Principal principal = new Principal(id);
                principal.Show();
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
                MessageBox.Show("Cuenta de usuario añadida.");
                panelParaRegistrar.Visible = false;
                panelParainiciar.Visible = true;
                panelColorRegistra.Visible = false;
                panelColorInicia.Visible = true;
                lblIniciarSesion.ForeColor = Color.FromArgb(69, 123, 157);
                lblRegistrarse.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        #region Complementos para el funcionamiento
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* Para que la casilla donde se ingres ala contraseña pueda ser visible para el usuario */
            if (checkBox1.Checked && txtPassword.PasswordChar == '*') txtPassword.PasswordChar = '\0';
            else if (!checkBox1.Checked && txtPassword.PasswordChar == '\0') txtPassword.PasswordChar = '*';

            /* Para que la casilla donde se ingres ala contraseña pueda ser visible para el usuario */
            if (checkBox1.Checked && txtPasswordC.PasswordChar == '*') txtPasswordC.PasswordChar = '\0';
            else if (!checkBox1.Checked && txtPasswordC.PasswordChar == '\0') txtPasswordC.PasswordChar = '*';
        }
        private bool Validarcampos()
        {
            bool ok = false;
            if (txtUser.Text == "" || txtUser.Text == null || txtUser.Text == "Usuario")
                ep.SetError(txtUser, "Ingrese cuenta");
           else if (txtPassword.Text == "" || txtPassword.Text == null || txtPassword.Text == "Contraseña")
                ep.SetError(txtPassword, "Ingrese contraseña");
            else if (txtPassword.Text != txtPasswordC.Text)
                ep.SetError(txtPasswordC,"Las contraseñas no concuerdan.");
            else 
                ok = true;
            return ok;
        }
        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            /* Para que la casilla donde se ingres ala contraseña pueda ser visible para el usuario */
            if (cbMostrar.Checked && txtPass.PasswordChar == '*') txtPass.PasswordChar = '\0';
            else if (!cbMostrar.Checked && txtPass.PasswordChar == '\0') txtPass.PasswordChar = '*';
        }
        #endregion
        #region Efecto para los botones superiores
        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            panelParainiciar.Visible = true;
            panelParaRegistrar.Visible = false;
            panelColorInicia.Visible = true;
            panelColorRegistra.Visible = false;
            lblIniciarSesion.ForeColor = Color.FromArgb(69, 123, 157);
            panelColorRegistra.Visible = false;
            lblRegistrarse.ForeColor = Color.FromArgb(0, 0, 0);
        }
        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            panelParainiciar.Visible = false;
            panelParaRegistrar.Visible = true;
            panelColorInicia.Visible = false;
            panelColorRegistra.Visible = true;
            lblIniciarSesion.ForeColor = Color.FromArgb(0,0,0);
            panelColorRegistra.Visible = true;
            lblRegistrarse.ForeColor = Color.FromArgb(69, 123, 157);
        }
        #endregion
        #region Inicio de sesión cajas
        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "") txtUsuario.Text = "Usuario";
        }
        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario") txtUsuario.Clear();
        }
        private void txtPass_MouseEnter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.PasswordChar = '*';
                txtPass.Clear();
            }
        }
        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
            if (txtPass.Text == "") 
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Contraseña";
            } 
        }
        #endregion
        #region Registro cajas
        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtUser.Text == "") txtUser.Text = "Usuario";
        }
        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.PasswordChar = '*';
                txtPassword.Clear();
            }
        }
        private void txtPasswordC_MouseLeave(object sender, EventArgs e)
        {
            if (txtPasswordC.Text == "")
            {
                txtPasswordC.PasswordChar = '\0';
                txtPasswordC.Text = "Repetir contraseña";
            }
        }
        private void txtPasswordC_MouseEnter(object sender, EventArgs e)
        {
            if (txtPasswordC.Text == "Repetir contraseña")
            {
                txtPasswordC.PasswordChar = '*';
                txtPasswordC.Clear();
            }
        }
        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Contraseña";
            }
        }
        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario") txtUser.Clear();
        }
        #endregion
    }
}