
namespace Biblioteca_Andrea
{
    partial class Pila
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtentrega = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtprestamo = new System.Windows.Forms.DateTimePicker();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butagregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textcedula = new System.Windows.Forms.TextBox();
            this.textnomblibro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cantidatol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btiniciar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttEliminar = new System.Windows.Forms.Button();
            this.butorde = new System.Windows.Forms.Button();
            this.entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Crimson;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(44, 399);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 34);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtentrega
            // 
            this.dtentrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtentrega.Location = new System.Drawing.Point(451, 112);
            this.dtentrega.Name = "dtentrega";
            this.dtentrega.Size = new System.Drawing.Size(137, 26);
            this.dtentrega.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtentrega);
            this.groupBox2.Controls.Add(this.dtprestamo);
            this.groupBox2.Controls.Add(this.texNombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.butagregar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textcedula);
            this.groupBox2.Controls.Add(this.textnomblibro);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(1, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 202);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // dtprestamo
            // 
            this.dtprestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtprestamo.Location = new System.Drawing.Point(140, 112);
            this.dtprestamo.Name = "dtprestamo";
            this.dtprestamo.Size = new System.Drawing.Size(137, 26);
            this.dtprestamo.TabIndex = 23;
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(176, 35);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(116, 26);
            this.texNombre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Prestamo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(331, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Entrega del libro";
            // 
            // butagregar
            // 
            this.butagregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.butagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butagregar.Location = new System.Drawing.Point(267, 152);
            this.butagregar.Name = "butagregar";
            this.butagregar.Size = new System.Drawing.Size(87, 44);
            this.butagregar.TabIndex = 18;
            this.butagregar.Text = "Agregar";
            this.butagregar.UseVisualStyleBackColor = false;
            this.butagregar.Click += new System.EventHandler(this.butagregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cedula";
            // 
            // textcedula
            // 
            this.textcedula.Location = new System.Drawing.Point(176, 67);
            this.textcedula.Name = "textcedula";
            this.textcedula.Size = new System.Drawing.Size(116, 26);
            this.textcedula.TabIndex = 9;
            // 
            // textnomblibro
            // 
            this.textnomblibro.Location = new System.Drawing.Point(451, 36);
            this.textnomblibro.Name = "textnomblibro";
            this.textnomblibro.Size = new System.Drawing.Size(116, 26);
            this.textnomblibro.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cantidatol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btiniciar);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 51);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bienvenido";
            // 
            // cantidatol
            // 
            this.cantidatol.Location = new System.Drawing.Point(166, 19);
            this.cantidatol.Name = "cantidatol";
            this.cantidatol.Size = new System.Drawing.Size(116, 26);
            this.cantidatol.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Libros";
            // 
            // btiniciar
            // 
            this.btiniciar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btiniciar.Location = new System.Drawing.Point(289, 19);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(87, 23);
            this.btiniciar.TabIndex = 7;
            this.btiniciar.Text = "Iniciar";
            this.btiniciar.UseVisualStyleBackColor = false;
            this.btiniciar.Click += new System.EventHandler(this.btiniciar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(481, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Biblioteca";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(461, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttEliminar
            // 
            this.buttEliminar.BackColor = System.Drawing.Color.Crimson;
            this.buttEliminar.Enabled = false;
            this.buttEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttEliminar.Location = new System.Drawing.Point(283, 399);
            this.buttEliminar.Name = "buttEliminar";
            this.buttEliminar.Size = new System.Drawing.Size(87, 30);
            this.buttEliminar.TabIndex = 26;
            this.buttEliminar.Text = "Eliminar";
            this.buttEliminar.UseVisualStyleBackColor = false;
            this.buttEliminar.Click += new System.EventHandler(this.buttEliminar_Click);
            // 
            // butorde
            // 
            this.butorde.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.butorde.Enabled = false;
            this.butorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butorde.Location = new System.Drawing.Point(160, 398);
            this.butorde.Name = "butorde";
            this.butorde.Size = new System.Drawing.Size(87, 31);
            this.butorde.TabIndex = 25;
            this.butorde.Text = "Ordenar";
            this.butorde.UseVisualStyleBackColor = false;
            this.butorde.Click += new System.EventHandler(this.butorde_Click);
            // 
            // entrega
            // 
            dataGridViewCellStyle11.Format = "d";
            this.entrega.DefaultCellStyle = dataGridViewCellStyle11;
            this.entrega.HeaderText = "Fecha de Entrega";
            this.entrega.Name = "entrega";
            this.entrega.ReadOnly = true;
            // 
            // prestamo
            // 
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.prestamo.DefaultCellStyle = dataGridViewCellStyle12;
            this.prestamo.HeaderText = "Fecha del prestamo";
            this.prestamo.Name = "prestamo";
            this.prestamo.ReadOnly = true;
            // 
            // libro
            // 
            this.libro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.libro.HeaderText = "Titulo del libro";
            this.libro.Name = "libro";
            this.libro.ReadOnly = true;
            // 
            // Ced
            // 
            this.Ced.HeaderText = "Cedula";
            this.Ced.Name = "Ced";
            this.Ced.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Ced,
            this.libro,
            this.prestamo,
            this.entrega});
            this.dataGridView1.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(13, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(535, 116);
            this.dataGridView1.TabIndex = 24;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 75;
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteca_Andrea.Properties.Resources.Los_libros_ocupan_un_lugar_muy_importante_en_la_vida_de_las_personas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttEliminar);
            this.Controls.Add(this.butorde);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Pila";
            this.Text = "BIBLIOTECA ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DateTimePicker dtentrega;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtprestamo;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butagregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textcedula;
        private System.Windows.Forms.TextBox textnomblibro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cantidatol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btiniciar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttEliminar;
        private System.Windows.Forms.Button butorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ced;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}