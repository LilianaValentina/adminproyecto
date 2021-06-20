
namespace serviciosstreaming
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblCerrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucLog1 = new Elementos.ucLog();
            this.SuspendLayout();
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Location = new System.Drawing.Point(305, 6);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(14, 13);
            this.lblCerrar.TabIndex = 1;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "QuéPeli";
            // 
            // ucLog1
            // 
            this.ucLog1.BackColor = System.Drawing.Color.White;
            this.ucLog1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucLog1.Location = new System.Drawing.Point(12, 90);
            this.ucLog1.Name = "ucLog1";
            this.ucLog1.Size = new System.Drawing.Size(299, 376);
            this.ucLog1.TabIndex = 2;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.ucLog1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios streaming";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmInicio_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCerrar;
        private Elementos.ucLog ucLog1;
        private System.Windows.Forms.Label label2;
    }
}

