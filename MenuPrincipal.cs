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

    /// <summary>
    /// Autores: Juan Diego Céspedes, Alen Yair Camargo, Mauricio Gómez Restrepo
    /// Fecha: 22/04/2021
    /// Descripción: Formulario nómina, carga de archivos .CSV
    /// </summary>

    public partial class frmMenuPrincipal : Form
    {

        //Formulario hijo con las propiedades de la clase Nómina
        private  frmNomina formaNomina;

        //Inicializador del formulario

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        //Opción de salir en el Menu Strip

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Condicional que se encarga de inicializar un formulario en caso de que se requiera
            try
            {

                if (formaNomina == null)
                {

                    formaNomina = new frmNomina();
                    formaNomina.FormClosed += new FormClosedEventHandler(Cerrarforma);
                    formaNomina.Show();
                    this.Hide();

                }
                else
                {
                    formaNomina.Activate();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //Método que vacía la forma en caso de que se requiera

        void Cerrarforma(object sender, FormClosedEventArgs e)
        {
            formaNomina = null;        
        }

        //Método que cierra el formulario

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Mensaje de confirmación en caso de que se desee cerrar

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }

            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
