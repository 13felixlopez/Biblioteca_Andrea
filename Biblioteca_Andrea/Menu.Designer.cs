
namespace Biblioteca_Andrea
{
    partial class Menu
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
            this.Biblioteca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSalir = new System.Windows.Forms.Button();
            this.but_Cola = new System.Windows.Forms.Button();
            this.but_pilas = new System.Windows.Forms.Button();
            this.butonConverciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Biblioteca
            // 
            this.Biblioteca.AutoSize = true;
            this.Biblioteca.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Biblioteca.Location = new System.Drawing.Point(43, 101);
            this.Biblioteca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Biblioteca.Name = "Biblioteca";
            this.Biblioteca.Size = new System.Drawing.Size(128, 38);
            this.Biblioteca.TabIndex = 11;
            this.Biblioteca.Text = "Biblioteca";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca_Andrea.Properties.Resources.b34f0e3e3e5955979814016a01b99344;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // butSalir
            // 
            this.butSalir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butSalir.Location = new System.Drawing.Point(64, 308);
            this.butSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(100, 28);
            this.butSalir.TabIndex = 9;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = true;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // but_Cola
            // 
            this.but_Cola.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_Cola.Location = new System.Drawing.Point(64, 271);
            this.but_Cola.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_Cola.Name = "but_Cola";
            this.but_Cola.Size = new System.Drawing.Size(100, 30);
            this.but_Cola.TabIndex = 8;
            this.but_Cola.Text = "Cola";
            this.but_Cola.UseVisualStyleBackColor = true;
            this.but_Cola.Click += new System.EventHandler(this.but_Cola_Click);
            // 
            // but_pilas
            // 
            this.but_pilas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_pilas.Location = new System.Drawing.Point(64, 222);
            this.but_pilas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_pilas.Name = "but_pilas";
            this.but_pilas.Size = new System.Drawing.Size(100, 28);
            this.but_pilas.TabIndex = 7;
            this.but_pilas.Text = "Pilas";
            this.but_pilas.UseVisualStyleBackColor = true;
            this.but_pilas.Click += new System.EventHandler(this.but_pilas_Click);
            // 
            // butonConverciones
            // 
            this.butonConverciones.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butonConverciones.Location = new System.Drawing.Point(51, 169);
            this.butonConverciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butonConverciones.Name = "butonConverciones";
            this.butonConverciones.Size = new System.Drawing.Size(131, 30);
            this.butonConverciones.TabIndex = 6;
            this.butonConverciones.Text = "Converciones";
            this.butonConverciones.UseVisualStyleBackColor = true;
            this.butonConverciones.Click += new System.EventHandler(this.butonConverciones_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(239, 355);
            this.Controls.Add(this.Biblioteca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.but_Cola);
            this.Controls.Add(this.but_pilas);
            this.Controls.Add(this.butonConverciones);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Biblioteca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.Button but_Cola;
        private System.Windows.Forms.Button but_pilas;
        private System.Windows.Forms.Button butonConverciones;
    }
}