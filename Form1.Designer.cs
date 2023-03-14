namespace Inversa
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
            this.textBoxReverse = new System.Windows.Forms.TextBox();
            this.labelReverse = new System.Windows.Forms.Label();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxReverse
            // 
            this.textBoxReverse.Location = new System.Drawing.Point(32, 63);
            this.textBoxReverse.Name = "textBoxReverse";
            this.textBoxReverse.Size = new System.Drawing.Size(100, 20);
            this.textBoxReverse.TabIndex = 0;
            // 
            // labelReverse
            // 
            this.labelReverse.AutoSize = true;
            this.labelReverse.Location = new System.Drawing.Point(29, 104);
            this.labelReverse.Name = "labelReverse";
            this.labelReverse.Size = new System.Drawing.Size(0, 13);
            this.labelReverse.TabIndex = 1;
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(154, 147);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonReverse.TabIndex = 2;
            this.buttonReverse.Text = "Invertir Lista";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(33, 28);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(246, 13);
            this.description.TabIndex = 3;
            this.description.Text = "Escribe una lista de números separados por comas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 182);
            this.Controls.Add(this.description);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.labelReverse);
            this.Controls.Add(this.textBoxReverse);
            this.Name = "Form1";
            this.Text = "Lista Inversa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReverse;
        private System.Windows.Forms.Label labelReverse;
        private System.Windows.Forms.Button buttonReverse;
        public System.Windows.Forms.Label description;
    }
}

