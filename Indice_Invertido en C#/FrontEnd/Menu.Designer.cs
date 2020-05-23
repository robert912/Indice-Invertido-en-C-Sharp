namespace FrontEnd
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonSW = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSW
            // 
            this.buttonSW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSW.Image = ((System.Drawing.Image)(resources.GetObject("buttonSW.Image")));
            this.buttonSW.Location = new System.Drawing.Point(89, 43);
            this.buttonSW.Name = "buttonSW";
            this.buttonSW.Size = new System.Drawing.Size(115, 37);
            this.buttonSW.TabIndex = 0;
            this.buttonSW.Text = "Cargar StopWords";
            this.buttonSW.UseVisualStyleBackColor = true;
            this.buttonSW.Click += new System.EventHandler(this.buttonStopWords);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(89, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cargar Documnetos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDocumentos);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBuscador
            // 
            this.btnBuscador.Location = new System.Drawing.Point(90, 159);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(114, 35);
            this.btnBuscador.TabIndex = 2;
            this.btnBuscador.Text = "Buscador";
            this.btnBuscador.UseVisualStyleBackColor = true;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSW);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Documentos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSW;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBuscador;
    }
}

