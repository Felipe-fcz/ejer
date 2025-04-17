namespace ejer
{
    partial class Form1
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnVerMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(135, 78);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(194, 20);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnVerMensaje
            // 
            this.btnVerMensaje.Location = new System.Drawing.Point(153, 152);
            this.btnVerMensaje.Name = "btnVerMensaje";
            this.btnVerMensaje.Size = new System.Drawing.Size(166, 44);
            this.btnVerMensaje.TabIndex = 1;
            this.btnVerMensaje.Text = "Ver Mensaje";
            this.btnVerMensaje.UseVisualStyleBackColor = true;
            this.btnVerMensaje.Click += new System.EventHandler(this.btnVerMensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 294);
            this.Controls.Add(this.btnVerMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnVerMensaje;
    }
}

