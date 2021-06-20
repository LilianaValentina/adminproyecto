
namespace serviciosstreaming
{
    partial class frmMostrarPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarPelicula));
            this.lblPelicula = new System.Windows.Forms.Label();
            this.richDescripcion = new System.Windows.Forms.RichTextBox();
            this.panelComentarios = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.cbPlataformaPelicula = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDirectorPelicula = new System.Windows.Forms.ComboBox();
            this.cbActorPelicula = new System.Windows.Forms.ComboBox();
            this.cbGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.panelComentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.lblPelicula.Location = new System.Drawing.Point(270, 47);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(113, 21);
            this.lblPelicula.TabIndex = 1;
            this.lblPelicula.Text = "Título película";
            // 
            // richDescripcion
            // 
            this.richDescripcion.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.richDescripcion.Location = new System.Drawing.Point(273, 71);
            this.richDescripcion.Name = "richDescripcion";
            this.richDescripcion.ReadOnly = true;
            this.richDescripcion.Size = new System.Drawing.Size(255, 93);
            this.richDescripcion.TabIndex = 2;
            this.richDescripcion.Text = "";
            // 
            // panelComentarios
            // 
            this.panelComentarios.AutoScroll = true;
            this.panelComentarios.Controls.Add(this.richTextBox1);
            this.panelComentarios.Controls.Add(this.button1);
            this.panelComentarios.Location = new System.Drawing.Point(12, 420);
            this.panelComentarios.Name = "panelComentarios";
            this.panelComentarios.Size = new System.Drawing.Size(516, 251);
            this.panelComentarios.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 48);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(401, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Comentar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbPortada
            // 
            this.pbPortada.Image = global::serviciosstreaming.Properties.Resources.portada;
            this.pbPortada.Location = new System.Drawing.Point(12, 47);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(252, 371);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Película";
            // 
            // logo
            // 
            this.logo.Image = global::serviciosstreaming.Properties.Resources.film_fotografico;
            this.logo.Location = new System.Drawing.Point(4, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(27, 25);
            this.logo.TabIndex = 22;
            this.logo.TabStop = false;
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.ForeColor = System.Drawing.Color.Black;
            this.lblCerrar.Location = new System.Drawing.Point(508, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(14, 13);
            this.lblCerrar.TabIndex = 24;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // cbPlataformaPelicula
            // 
            this.cbPlataformaPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbPlataformaPelicula.FormattingEnabled = true;
            this.cbPlataformaPelicula.Location = new System.Drawing.Point(270, 359);
            this.cbPlataformaPelicula.Name = "cbPlataformaPelicula";
            this.cbPlataformaPelicula.Size = new System.Drawing.Size(252, 29);
            this.cbPlataformaPelicula.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(270, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Plataforma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(270, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Director";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.lblActor.Location = new System.Drawing.Point(270, 223);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(49, 21);
            this.lblActor.TabIndex = 44;
            this.lblActor.Text = "Actor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(270, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Género";
            // 
            // cbDirectorPelicula
            // 
            this.cbDirectorPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbDirectorPelicula.FormattingEnabled = true;
            this.cbDirectorPelicula.Location = new System.Drawing.Point(270, 303);
            this.cbDirectorPelicula.Name = "cbDirectorPelicula";
            this.cbDirectorPelicula.Size = new System.Drawing.Size(252, 29);
            this.cbDirectorPelicula.TabIndex = 42;
            // 
            // cbActorPelicula
            // 
            this.cbActorPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbActorPelicula.FormattingEnabled = true;
            this.cbActorPelicula.Location = new System.Drawing.Point(270, 247);
            this.cbActorPelicula.Name = "cbActorPelicula";
            this.cbActorPelicula.Size = new System.Drawing.Size(252, 29);
            this.cbActorPelicula.TabIndex = 41;
            // 
            // cbGeneroPelicula
            // 
            this.cbGeneroPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbGeneroPelicula.FormattingEnabled = true;
            this.cbGeneroPelicula.Location = new System.Drawing.Point(270, 191);
            this.cbGeneroPelicula.Name = "cbGeneroPelicula";
            this.cbGeneroPelicula.Size = new System.Drawing.Size(252, 29);
            this.cbGeneroPelicula.TabIndex = 40;
            // 
            // frmMostrarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 683);
            this.Controls.Add(this.cbPlataformaPelicula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblActor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDirectorPelicula);
            this.Controls.Add(this.cbActorPelicula);
            this.Controls.Add(this.cbGeneroPelicula);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panelComentarios);
            this.Controls.Add(this.richDescripcion);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.pbPortada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelicula";
            this.panelComentarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.RichTextBox richDescripcion;
        private System.Windows.Forms.FlowLayoutPanel panelComentarios;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.ComboBox cbPlataformaPelicula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDirectorPelicula;
        private System.Windows.Forms.ComboBox cbActorPelicula;
        private System.Windows.Forms.ComboBox cbGeneroPelicula;
    }
}