
namespace serviciosstreaming
{
    partial class frmAgregarActores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarActores));
            this.txtActor = new System.Windows.Forms.TextBox();
            this.btnAgregarActor = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnEliminarActor = new System.Windows.Forms.Button();
            this.btnEditarActor = new System.Windows.Forms.Button();
            this.btnBuscarActor = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActor
            // 
            this.txtActor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActor.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.txtActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(141)))));
            this.txtActor.Location = new System.Drawing.Point(13, 51);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(179, 26);
            this.txtActor.TabIndex = 0;
            this.txtActor.Text = "Nombre del Actor";
            this.txtActor.MouseEnter += new System.EventHandler(this.txtActor_MouseEnter);
            this.txtActor.MouseLeave += new System.EventHandler(this.txtActor_MouseLeave);
            // 
            // btnAgregarActor
            // 
            this.btnAgregarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAgregarActor.FlatAppearance.BorderSize = 0;
            this.btnAgregarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarActor.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.btnAgregarActor.Location = new System.Drawing.Point(12, 249);
            this.btnAgregarActor.Name = "btnAgregarActor";
            this.btnAgregarActor.Size = new System.Drawing.Size(114, 39);
            this.btnAgregarActor.TabIndex = 1;
            this.btnAgregarActor.Text = "Agregar";
            this.btnAgregarActor.UseVisualStyleBackColor = false;
            this.btnAgregarActor.Click += new System.EventHandler(this.btnAgregarActor_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.Location = new System.Drawing.Point(12, 93);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 100;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Size = new System.Drawing.Size(234, 150);
            this.dgv.TabIndex = 2;
            // 
            // btnEliminarActor
            // 
            this.btnEliminarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnEliminarActor.FlatAppearance.BorderSize = 0;
            this.btnEliminarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarActor.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.btnEliminarActor.Location = new System.Drawing.Point(132, 249);
            this.btnEliminarActor.Name = "btnEliminarActor";
            this.btnEliminarActor.Size = new System.Drawing.Size(114, 39);
            this.btnEliminarActor.TabIndex = 3;
            this.btnEliminarActor.Text = "Eliminar";
            this.btnEliminarActor.UseVisualStyleBackColor = false;
            this.btnEliminarActor.Click += new System.EventHandler(this.btnEliminarActor_Click);
            // 
            // btnEditarActor
            // 
            this.btnEditarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnEditarActor.FlatAppearance.BorderSize = 0;
            this.btnEditarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarActor.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.btnEditarActor.Location = new System.Drawing.Point(12, 294);
            this.btnEditarActor.Name = "btnEditarActor";
            this.btnEditarActor.Size = new System.Drawing.Size(114, 39);
            this.btnEditarActor.TabIndex = 4;
            this.btnEditarActor.Text = "Editar";
            this.btnEditarActor.UseVisualStyleBackColor = false;
            this.btnEditarActor.Click += new System.EventHandler(this.btnEditarActor_Click);
            // 
            // btnBuscarActor
            // 
            this.btnBuscarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnBuscarActor.FlatAppearance.BorderSize = 0;
            this.btnBuscarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarActor.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.btnBuscarActor.Location = new System.Drawing.Point(132, 294);
            this.btnBuscarActor.Name = "btnBuscarActor";
            this.btnBuscarActor.Size = new System.Drawing.Size(114, 39);
            this.btnBuscarActor.TabIndex = 5;
            this.btnBuscarActor.Text = "Buscar";
            this.btnBuscarActor.UseVisualStyleBackColor = false;
            this.btnBuscarActor.Click += new System.EventHandler(this.btnBuscarActor_Click);
            // 
            // logo
            // 
            this.logo.Image = global::serviciosstreaming.Properties.Resources.film_fotografico;
            this.logo.Location = new System.Drawing.Point(5, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(27, 25);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.ForeColor = System.Drawing.Color.Black;
            this.lblCerrar.Location = new System.Drawing.Point(233, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(14, 13);
            this.lblCerrar.TabIndex = 7;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agregar actores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(220)))));
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 1);
            this.panel1.TabIndex = 39;
            // 
            // frmAgregarActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(259, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnBuscarActor);
            this.Controls.Add(this.btnEditarActor);
            this.Controls.Add(this.btnEliminarActor);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAgregarActor);
            this.Controls.Add(this.txtActor);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarActores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar actores";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAgregarActores_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Button btnAgregarActor;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnEliminarActor;
        private System.Windows.Forms.Button btnEditarActor;
        private System.Windows.Forms.Button btnBuscarActor;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}