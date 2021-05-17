using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Andrea
{
    public partial class Pila : Form
    {
        public Pila()
        {
            InitializeComponent();
        }
        //declaracion de variables simples
        int max, tope = 0;

        struct datos_libro
        {
            // registro
            //agregue las variables nombre y cedula al arreglo para que se visualizaran en el datagriview
            public string nombre_Libro, nombre, cedula;
            //Cambie el tipo de variable a la fecha y elimine la fecha de entrega porque no se utiliza
            public DateTime fechaprestamo;
        }
        //declaracion de arreglo de registro
        datos_libro[] libros;

        private void btiniciar_Click(object sender, EventArgs e)
        {
            //Valide desde el boton de inicio
            if (string.IsNullOrWhiteSpace(cantidatol.Text) || int.Parse(cantidatol.Text) <= 0)
            {
                MessageBox.Show("Ingrese un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cantidatol.Clear();
                cantidatol.Focus();
            }
            else
            {
                max = int.Parse(cantidatol.Text);
                libros = new datos_libro[max];
                //POR DEFECTO DEJE QUE LOS BOTONES ELIMINAR Y ORDENAR ESTEN DESABILITADOS
                //ACA SE HABILITAN PERO REALMENTE SE DEBERIAN DE HABILITAR HASTA AGREGAR EL PRIMER REGISTRO
                buttEliminar.Enabled = true;
                butorde.Enabled = true;
                //DESHABILITO EL GROUPBOX1 Y HABILITO EL 2 PARA LLENAR LOS DATOS
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
            //Esto lo se utiliza o al menos no en este lugar
            //nombre = texNombre.Text;
            //cedula = textcedula.Text;
            //texNombre.Clear();
            //textcedula.Clear();
            //cantidatol.Focus();
        }
        //ELIMINE ESTE BOTON ERA INNECESARIO
        //private void Btseg_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(cantidatol.Text) || int.Parse(cantidatol.Text) <= 0) 
        //    {
        //        MessageBox.Show("Ingrese un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        cantidatol.Clear();
        //        cantidatol.Focus();
        //    }
        //    else
        //    {
        //        max = int.Parse(cantidatol.Text);
        //        libros = new datos_libro[max];

        //        buttEliminar.Enabled = true;
        //        butorde.Enabled = true;
        //        textnomblibro.Focus();
        //    }
        //}
        private void butagregar_Click(object sender, EventArgs e)
        {
            Pila_llena();
        }
        private void buttEliminar_Click(object sender, EventArgs e)
        {
            Pila_vacia();
        }
        private void Pila_llena()
        {
            if (tope < max)
            {
                if (this.validar())
                {
                    //AGREGUE NOMBRE Y CEDULA PARA MOSTRARLOS EN EL DATAGRIVIEW
                    libros[tope].nombre = texNombre.Text;
                    libros[tope].cedula = textcedula.Text;
                    libros[tope].nombre_Libro = textnomblibro.Text;
                    //ACA CONVERTI LAS VARIABLES DE TIPO FECHA
                    libros[tope].fechaprestamo = Convert.ToDateTime(dtprestamo.Text);
                    libros[tope].fechaprestamo = Convert.ToDateTime(dtentrega.Text);
                    //AGREGADOS AL DATAGRIVIEW
                    dataGridView1.Rows.Add(libros[tope].nombre, libros[tope].cedula, libros[tope].nombre_Libro, libros[tope].fechaprestamo,
                        libros[tope].fechaprestamo);
                    tope++;
                    MessageBox.Show(" Se agrego un dato a la pila", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("Existen campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //INABILITE EL GROUPBOX2 PARA QUE NO SE PUDIERA UTILIZAR SI LA PILA ESTA LLENA
                groupBox2.Enabled = false;
                MessageBox.Show("Pila LLena", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void Pila_vacia()
        {
            int i = 0;
            if (tope > 0)
            {
                tope--;
                dataGridView1.Rows.RemoveAt(tope);
                MessageBox.Show("Se ha eliminado un dato de la pila", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (libros[i].fechaprestamo < libros[tope].fechaprestamo)
                {
                    libros[tope].fechaprestamo = libros[tope].fechaprestamo;
                    i++;
                    dataGridView1.Rows.Add("", 0, libros[tope].fechaprestamo);
                    dataGridView1.Rows.RemoveAt(tope);
                }
            }
            if (tope == 0)
            {
                //SI LA PILA ESTA VACIA SE PUEDE VOLVER AGREGAR REGISTROS POR ESO SE VUELVE HA AHBILITAR EL GROUPBOX2
                groupBox2.Enabled = true;
                MessageBox.Show("Pila Vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butorde_Click(object sender, EventArgs e)
        {
            //FUNCION DE ORDENAR POR NOMBRE UNICAMENTE
            //REALMENTE ASI NO LO PIDE LA PROFE GUISS, PERO ES LO MAS FACIL PARA HACER JAJAJA
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
        private void limpiar()
        {
            //SOLO LIMPIA LOS TEXTBOX
            texNombre.Clear();
            textcedula.Clear();
            textnomblibro.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //PARA REGRESAR AL FORMULARIO DEL MENU
            Menu pilas = new Menu();
            pilas.Show();
            this.Close();
        }

        private bool validar()
        {
            //ESTA PARTE ES SOLO EN CASO DE QUE UTILICES ENTEROS 
            //double entero;
            //if (!double.TryParse(dtprestamo.Text, out entero)|| !double.TryParse(textfechaentrega.Text, out entero))
            //{
            //    return false;
            //}
            //VALIDA QUE NO ESTEN VACIOS
            return !(textnomblibro.Text == "" || texNombre.Text == "" || textcedula.Text == "");
        }
    }
}
