using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elementos
{
    public partial class ucComentarios : UserControl
    {
        public ucComentarios()
        {
            InitializeComponent();
        }

        [Category("Propiedades")]
        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; lblNombre.Text = value; }
        }

        [Category("Propiedades")]
        private string _Comentario;

        public string Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; txtComentario.Text = value; }
        }
    }
}
