using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wNomina1
{
    public partial class frmMenuPrincipal : Form
    {
        private  frmNomina Forma;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Forma == null)
            {
                Forma = new frmNomina();
                Forma.FormClosed += new FormClosedEventHandler(Cerrarforma);
                Forma.Show();
                this.Hide();

            }
            else 
            {
                Forma.Activate();
            }
        }



        void Cerrarforma(object sender, FormClosedEventArgs e)
        {
            Forma = null;        
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void reabrirFormulario()
        {
            this.Show();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }

            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
