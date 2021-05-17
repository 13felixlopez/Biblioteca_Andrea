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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void butonConverciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendiente para que tu lo hagas jajaja", "Andrea Celeste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void but_pilas_Click(object sender, EventArgs e)
        {
            Pila form1 = new Pila();
            form1.Show();
            this.Hide();
        }

        private void but_Cola_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendiente para que tu lo hagas jajaja", "Andrea Celeste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
