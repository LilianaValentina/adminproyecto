
namespace serviciosstreaming
{
    partial class frmEditarPelicula
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cbPeliculas = new System.Windows.Forms.ComboBox();
            this.btnAgregarDirectore = new System.Windows.Forms.Button();
            this.cbDirectores = new System.Windows.Forms.ComboBox();
            this.cbDirectorPelicula = new System.Windows.Forms.ComboBox();
            this.btnAgregarActor = new System.Windows.Forms.Button();
            this.cbActores = new System.Windows.Forms.ComboBox();
            this.cbActorPelicula = new System.Windows.Forms.ComboBox();
            this.btnAgregarGenero = new System.Windows.Forms.Button();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.cbGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarPlataforma = new System.Windows.Forms.Button();
            this.cbPlataformas = new System.Windows.Forms.ComboBox();
            this.cbPlataformaPelicula = new System.Windows.Forms.ComboBox();
            this.btnEliminarPlataforma = new System.Windows.Forms.Button();
            this.btnEliminarDirector = new System.Windows.Forms.Button();
            this.btnEliminarActor = new System.Windows.Forms.Button();
            this.btnEliminarGenero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pelicula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Editar película";
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.ForeColor = System.Drawing.Color.Black;
            this.lblCerrar.Location = new System.Drawing.Point(352, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(12, 13);
            this.lblCerrar.TabIndex = 23;
            this.lblCerrar.Text = "x";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // logo
            // 
            this.logo.Image = global::serviciosstreaming.Properties.Resources.film_fotografico;
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(27, 25);
            this.logo.TabIndex = 22;
            this.logo.TabStop = false;
            // 
            // cbPeliculas
            // 
            this.cbPeliculas.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbPeliculas.FormattingEnabled = true;
            this.cbPeliculas.Location = new System.Drawing.Point(16, 69);
            this.cbPeliculas.Name = "cbPeliculas";
            this.cbPeliculas.Size = new System.Drawing.Size(344, 29);
            this.cbPeliculas.TabIndex = 25;
            this.cbPeliculas.SelectionChangeCommitted += new System.EventHandler(this.cbPeliculas_SelectionChangeCommitted);
            // 
            // btnAgregarDirectore
            // 
            this.btnAgregarDirectore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAgregarDirectore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDirectore.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDirectore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarDirectore.Location = new System.Drawing.Point(154, 236);
            this.btnAgregarDirectore.Name = "btnAgregarDirectore";
            this.btnAgregarDirectore.Size = new System.Drawing.Size(31, 29);
            this.btnAgregarDirectore.TabIndex = 34;
            this.btnAgregarDirectore.Text = "+";
            this.btnAgregarDirectore.UseVisualStyleBackColor = false;
            this.btnAgregarDirectore.Click += new System.EventHandler(this.btnAgregarDirectore_Click);
            // 
            // cbDirectores
            // 
            this.cbDirectores.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbDirectores.FormattingEnabled = true;
            this.cbDirectores.Location = new System.Drawing.Point(228, 236);
            this.cbDirectores.Name = "cbDirectores";
            this.cbDirectores.Size = new System.Drawing.Size(132, 29);
            this.cbDirectores.TabIndex = 33;
            // 
            // cbDirectorPelicula
            // 
            this.cbDirectorPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbDirectorPelicula.FormattingEnabled = true;
            this.cbDirectorPelicula.Location = new System.Drawing.Point(16, 237);
            this.cbDirectorPelicula.Name = "cbDirectorPelicula";
            this.cbDirectorPelicula.Size = new System.Drawing.Size(132, 29);
            this.cbDirectorPelicula.TabIndex = 32;
            // 
            // btnAgregarActor
            // 
            this.btnAgregarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAgregarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarActor.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarActor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarActor.Location = new System.Drawing.Point(154, 180);
            this.btnAgregarActor.Name = "btnAgregarActor";
            this.btnAgregarActor.Size = new System.Drawing.Size(31, 29);
            this.btnAgregarActor.TabIndex = 31;
            this.btnAgregarActor.Text = "+";
            this.btnAgregarActor.UseVisualStyleBackColor = false;
            this.btnAgregarActor.Click += new System.EventHandler(this.btnAgregarActor_Click);
            // 
            // cbActores
            // 
            this.cbActores.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbActores.FormattingEnabled = true;
            this.cbActores.Location = new System.Drawing.Point(228, 181);
            this.cbActores.Name = "cbActores";
            this.cbActores.Size = new System.Drawing.Size(132, 29);
            this.cbActores.TabIndex = 30;
            // 
            // cbActorPelicula
            // 
            this.cbActorPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbActorPelicula.FormattingEnabled = true;
            this.cbActorPelicula.Location = new System.Drawing.Point(16, 181);
            this.cbActorPelicula.Name = "cbActorPelicula";
            this.cbActorPelicula.Size = new System.Drawing.Size(132, 29);
            this.cbActorPelicula.TabIndex = 29;
            // 
            // btnAgregarGenero
            // 
            this.btnAgregarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAgregarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGenero.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarGenero.Location = new System.Drawing.Point(154, 125);
            this.btnAgregarGenero.Name = "btnAgregarGenero";
            this.btnAgregarGenero.Size = new System.Drawing.Size(31, 29);
            this.btnAgregarGenero.TabIndex = 28;
            this.btnAgregarGenero.Text = "+";
            this.btnAgregarGenero.UseVisualStyleBackColor = false;
            this.btnAgregarGenero.Click += new System.EventHandler(this.btnAgregarGenero_Click);
            // 
            // cbGeneros
            // 
            this.cbGeneros.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Location = new System.Drawing.Point(228, 125);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(132, 29);
            this.cbGeneros.TabIndex = 27;
            // 
            // cbGeneroPelicula
            // 
            this.cbGeneroPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbGeneroPelicula.FormattingEnabled = true;
            this.cbGeneroPelicula.Location = new System.Drawing.Point(16, 125);
            this.cbGeneroPelicula.Name = "cbGeneroPelicula";
            this.cbGeneroPelicula.Size = new System.Drawing.Size(132, 29);
            this.cbGeneroPelicula.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Genero";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.lblActor.Location = new System.Drawing.Point(16, 157);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(49, 21);
            this.lblActor.TabIndex = 36;
            this.lblActor.Text = "Actor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(16, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(16, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Plataforma";
            // 
            // btnAgregarPlataforma
            // 
            this.btnAgregarPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAgregarPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPlataforma.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlataforma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPlataforma.Location = new System.Drawing.Point(154, 292);
            this.btnAgregarPlataforma.Name = "btnAgregarPlataforma";
            this.btnAgregarPlataforma.Size = new System.Drawing.Size(31, 29);
            this.btnAgregarPlataforma.TabIndex = 41;
            this.btnAgregarPlataforma.Text = "+";
            this.btnAgregarPlataforma.UseVisualStyleBackColor = false;
            this.btnAgregarPlataforma.Click += new System.EventHandler(this.btnAgregarPlataforma_Click);
            // 
            // cbPlataformas
            // 
            this.cbPlataformas.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbPlataformas.FormattingEnabled = true;
            this.cbPlataformas.Location = new System.Drawing.Point(228, 292);
            this.cbPlataformas.Name = "cbPlataformas";
            this.cbPlataformas.Size = new System.Drawing.Size(132, 29);
            this.cbPlataformas.TabIndex = 40;
            // 
            // cbPlataformaPelicula
            // 
            this.cbPlataformaPelicula.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.cbPlataformaPelicula.FormattingEnabled = true;
            this.cbPlataformaPelicula.Location = new System.Drawing.Point(16, 293);
            this.cbPlataformaPelicula.Name = "cbPlataformaPelicula";
            this.cbPlataformaPelicula.Size = new System.Drawing.Size(132, 29);
            this.cbPlataformaPelicula.TabIndex = 39;
            // 
            // btnEliminarPlataforma
            // 
            this.btnEliminarPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnEliminarPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPlataforma.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlataforma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPlataforma.Location = new System.Drawing.Point(191, 292);
            this.btnEliminarPlataforma.Name = "btnEliminarPlataforma";
            this.btnEliminarPlataforma.Size = new System.Drawing.Size(31, 29);
            this.btnEliminarPlataforma.TabIndex = 45;
            this.btnEliminarPlataforma.Text = "-";
            this.btnEliminarPlataforma.UseVisualStyleBackColor = false;
            this.btnEliminarPlataforma.Click += new System.EventHandler(this.btnEliminarPlataforma_Click);
            // 
            // btnEliminarDirector
            // 
            this.btnEliminarDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnEliminarDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDirector.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDirector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarDirector.Location = new System.Drawing.Point(191, 236);
            this.btnEliminarDirector.Name = "btnEliminarDirector";
            this.btnEliminarDirector.Size = new System.Drawing.Size(31, 29);
            this.btnEliminarDirector.TabIndex = 44;
            this.btnEliminarDirector.Text = "-";
            this.btnEliminarDirector.UseVisualStyleBackColor = false;
            this.btnEliminarDirector.Click += new System.EventHandler(this.btnEliminarDirector_Click);
            // 
            // btnEliminarActor
            // 
            this.btnEliminarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnEliminarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarActor.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarActor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarActor.Location = new System.Drawing.Point(191, 180);
            this.btnEliminarActor.Name = "btnEliminarActor";
            this.btnEliminarActor.Size = new System.Drawing.Size(31, 29);
            this.btnEliminarActor.TabIndex = 43;
            this.btnEliminarActor.Text = "-";
            this.btnEliminarActor.UseVisualStyleBackColor = false;
            this.btnEliminarActor.Click += new System.EventHandler(this.btnEliminarActor_Click);
            // 
            // btnEliminarGenero
            // 
            this.btnEliminarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnEliminarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGenero.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarGenero.Location = new System.Drawing.Point(191, 125);
            this.btnEliminarGenero.Name = "btnEliminarGenero";
            this.btnEliminarGenero.Size = new System.Drawing.Size(31, 29);
            this.btnEliminarGenero.TabIndex = 42;
            this.btnEliminarGenero.Text = "-";
            this.btnEliminarGenero.UseVisualStyleBackColor = false;
            this.btnEliminarGenero.Click += new System.EventHandler(this.btnEliminarGenero_Click);
            // 
            // frmEditarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(378, 341);
            this.Controls.Add(this.btnEliminarPlataforma);
            this.Controls.Add(this.btnEliminarDirector);
            this.Controls.Add(this.btnEliminarActor);
            this.Controls.Add(this.btnEliminarGenero);
            this.Controls.Add(this.btnAgregarPlataforma);
            this.Controls.Add(this.cbPlataformas);
            this.Controls.Add(this.cbPlataformaPelicula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblActor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarDirectore);
            this.Controls.Add(this.cbDirectores);
            this.Controls.Add(this.cbDirectorPelicula);
            this.Controls.Add(this.btnAgregarActor);
            this.Controls.Add(this.cbActores);
            this.Controls.Add(this.cbActorPelicula);
            this.Controls.Add(this.btnAgregarGenero);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.cbGeneroPelicula);
            this.Controls.Add(this.cbPeliculas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarPelicula";
            this.Text = "frmEditarPelicula";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEditarPelicula_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ComboBox cbPeliculas;
        private System.Windows.Forms.Button btnAgregarDirectore;
        private System.Windows.Forms.ComboBox cbDirectores;
        private System.Windows.Forms.ComboBox cbDirectorPelicula;
        private System.Windows.Forms.Button btnAgregarActor;
        private System.Windows.Forms.ComboBox cbActores;
        private System.Windows.Forms.ComboBox cbActorPelicula;
        private System.Windows.Forms.Button btnAgregarGenero;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.ComboBox cbGeneroPelicula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarPlataforma;
        private System.Windows.Forms.ComboBox cbPlataformas;
        private System.Windows.Forms.ComboBox cbPlataformaPelicula;
        private System.Windows.Forms.Button btnEliminarPlataforma;
        private System.Windows.Forms.Button btnEliminarDirector;
        private System.Windows.Forms.Button btnEliminarActor;
        private System.Windows.Forms.Button btnEliminarGenero;
    }
}