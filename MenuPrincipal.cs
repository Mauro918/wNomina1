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
                Forma.MdiParent = this;
                Forma.Show();

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

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
