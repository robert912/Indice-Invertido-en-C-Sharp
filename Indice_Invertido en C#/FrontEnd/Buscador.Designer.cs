namespace FrontEnd
{
    partial class Buscador
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.radioExact = new System.Windows.Forms.RadioButton();
            this.radioBest = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.listBoxShowDoc = new System.Windows.Forms.ListBox();
            this.buttonShowDoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(55, 113);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 42);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.buttonBuscar);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(42, 41);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(175, 20);
            this.textBuscar.TabIndex = 1;
            // 
            // radioExact
            // 
            this.radioExact.AutoSize = true;
            this.radioExact.Location = new System.Drawing.Point(250, 56);
            this.radioExact.Name = "radioExact";
            this.radioExact.Size = new System.Drawing.Size(85, 17);
            this.radioExact.TabIndex = 2;
            this.radioExact.Text = "Exact Match";
            this.radioExact.UseVisualStyleBackColor = true;
            // 
            // radioBest
            // 
            this.radioBest.AutoSize = true;
            this.radioBest.Checked = true;
            this.radioBest.Location = new System.Drawing.Point(250, 23);
            this.radioBest.Name = "radioBest";
            this.radioBest.Size = new System.Drawing.Size(79, 17);
            this.radioBest.TabIndex = 3;
            this.radioBest.TabStop = true;
            this.radioBest.Text = "Best Match";
            this.radioBest.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(244, 113);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.buttonSalir);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(42, 176);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(281, 69);
            this.listBoxResult.TabIndex = 7;
            // 
            // listBoxShowDoc
            // 
            this.listBoxShowDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxShowDoc.FormattingEnabled = true;
            this.listBoxShowDoc.Location = new System.Drawing.Point(408, 12);
            this.listBoxShowDoc.Name = "listBoxShowDoc";
            this.listBoxShowDoc.Size = new System.Drawing.Size(388, 238);
            this.listBoxShowDoc.TabIndex = 8;
            // 
            // buttonShowDoc
            // 
            this.buttonShowDoc.Location = new System.Drawing.Point(331, 187);
            this.buttonShowDoc.Name = "buttonShowDoc";
            this.buttonShowDoc.Size = new System.Drawing.Size(71, 41);
            this.buttonShowDoc.TabIndex = 9;
            this.buttonShowDoc.Text = "MostrarDoc  ->";
            this.buttonShowDoc.UseVisualStyleBackColor = true;
            this.buttonShowDoc.Click += new System.EventHandler(this.buttonShowDoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Realizar Consulta Palabra ; Palabras";
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowDoc);
            this.Controls.Add(this.listBoxShowDoc);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.radioBest);
            this.Controls.Add(this.radioExact);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Buscador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Buscador_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.RadioButton radioExact;
        private System.Windows.Forms.RadioButton radioBest;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.ListBox listBoxShowDoc;
        private System.Windows.Forms.Button buttonShowDoc;
        private System.Windows.Forms.Label label1;
    }
}