using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wNomina1
{
    public partial class frmNomina : Form
    {

        private frmMenuPrincipal menuPrincipal;
        private Stream myStream;
        int counter = 0;
        string linea;

        public frmNomina()
        {
            InitializeComponent();
            

        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            try
            {

                double Salariobasico = double.Parse(txtSalario.Text);
                double Extra = double.Parse(txtExtra.Text);
                double Nomina = 0;
                double Comision = 0;
                double Salud = 0;
                double Pension = 0;
                double Auxilio = 0;
                double ibc = 0;
                double fondoSolidaridad = 0;
                double descuentos;
                

                if (chkAuxilio.Checked == true)
                {
                    Auxilio += 106454;
                }
                else
                {
                    Auxilio = 0;
                }



                Nomina = Nomina + (Salariobasico + Extra + Auxilio);



                if (chkComision.Checked == true)
                {

                    if (rdoQuinientos.Checked == true)
                    {
                        Comision = 500000;

                    }
                    else if (rdoOchocientoss.Checked == true)
                    {
                        Comision = 800000;
                    }
                    else if (rdoMillon.Checked == true)
                    {
                        Comision = 1000000;
                    }
                    else
                    {
                        Comision = 0;
                    }

                    Nomina += Comision;

                }

                Salud = (Nomina * 4) / 100;
                Pension = Nomina * 0.04;
                descuentos = Salud + Pension;

                if (Salariobasico >= 3608000)
                {

                    ibc = ((Nomina * 40) / 100);
                    fondoSolidaridad = ((ibc * 1) / 100);
                    descuentos += fondoSolidaridad;
                    Nomina = Nomina - descuentos;

                    MessageBox.Show("Nombre:\t$" + txtNombre.Text + "\n" + "Apellido:\t$" + txtApellido.Text + "\n" +
"Documento:\t$" + txtDocumento.Text + "\n" + "Cargo:\t" + cmbCargo.Text + "\nSalario Básico:\t$" + Salariobasico +
"\n" + "Comision:\t$" + Comision + "\nExtra:\t$" + Extra + "\nDescuentos:\t$-" + descuentos
+ "\n" + "Axilio de trasporte:\t$" + Auxilio + "\n" + "Salud:\t$-" + Salud + "\n" + "Pension:\t$-"
+ Pension + "\nFondo Solidaridad:\t$-" + fondoSolidaridad + "\n" + "Valor a pagar:\t$" + Nomina);

                }
                else
                {

                    Nomina = Nomina - descuentos;

                    MessageBox.Show("Nombre:\t$" + txtNombre.Text + "\n" + "Apellido:\t$" + txtApellido.Text + "\n" +
    "Documento:\t$" + txtDocumento.Text + "\n" + "Cargo:\t" + cmbCargo.Text + "\nSalario Básico:\t$" + Salariobasico +  
    "\n" + "Comision:\t$" + Comision + "\nExtra:\t$" + Extra + "\nDescuentos:\t$-" + descuentos
    + "\n" + "Axilio de trasporte:\t$" + Auxilio + "\n" + "Salud:\t$-" + Salud + "\n" + "Pension:\t$-"
    + Pension + "\n" + "Valor a pagar:\t$" + Nomina);

                }

            }
            catch (Exception x)
            {
                 MessageBox.Show(x.Message);
            }



        }

        private void frmNomina_Load(object sender, EventArgs e)
        {
            try
            {
                #region[llenar combo cargo]
                cmbCargo.Items.Clear();
                cmbCargo.Items.Add("Secretaria");
                cmbCargo.Items.Add("Conserge");
                cmbCargo.Items.Add("Director ejecutivo");
                cmbCargo.Items.Add("Visepresidente");
                #endregion

                chkAuxilio.Visible = false;
                chkAuxilio.Enabled = false;

                chkComision_CheckedChanged(sender, e);

            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }



        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

            double Salariobasico = 0;

            try
            {
                Salariobasico = double.Parse(txtSalario.Text);



                if (Salariobasico <= 902000 && Salariobasico > 0)
                {
                    chkAuxilio.Visible = true;
                    chkAuxilio.Enabled = true;

                }
                else
                {
                    chkAuxilio.Checked = false;
                    chkAuxilio.Visible = false;
                    chkAuxilio.Enabled = false;
                }

            }

            catch
            {
                chkAuxilio.Checked = false;
                chkAuxilio.Visible = false;
                chkAuxilio.Enabled = false;
                Salariobasico = 0;
                txtSalario.Text = "";


            }
        }



        private void chkComision_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkComision.Checked == false)
            {
                rdoQuinientos.Checked = false;
                rdoQuinientos.Enabled = false;
                rdoOchocientoss.Checked = false;
                rdoOchocientoss.Enabled = false;
                rdoMillon.Checked = false;
                rdoMillon.Enabled = false;

            }
            else
            {
                rdoQuinientos.Enabled = true;
                rdoOchocientoss.Enabled = true;
                rdoMillon.Enabled = true;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {

                txtNombre.Clear();
                txtApellido.Clear();
                txtDocumento.Clear();
                txtExtra.Clear();
                txtSalario.Clear();
                cmbCargo.Text = "";
                chkAuxilio.Checked = false;
                chkComision.Checked = false;
                chkAuxilio.Visible = false;
                chkAuxilio.Enabled = true;
                dtgNomina.Rows.Clear();
                dtgNomina.Columns.Clear();

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            #region [Columnas DataGridView]

            dtgNomina.Rows.Clear();
            dtgNomina.Columns.Clear();

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Nombre";
            col1.Width = 200;
            col1.ReadOnly = true;
            dtgNomina.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Apellido";
            col2.Width = 200;
            col2.ReadOnly = true;
            dtgNomina.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Documento";
            col3.Width = 200;
            col3.ReadOnly = true;
            dtgNomina.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Cargo";
            col4.Width = 200;
            col4.ReadOnly = true;
            dtgNomina.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Salario Basico";
            col5.Width = 200;
            col5.ReadOnly = true;
            dtgNomina.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Extra";
            col6.Width = 200;
            col6.ReadOnly = true;
            dtgNomina.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Auxilio Transporte";
            col7.Width = 200;
            col7.ReadOnly = true;
            dtgNomina.Columns.Add(col7);

            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Comisión";
            col8.Width = 200;
            col8.ReadOnly = true;
            dtgNomina.Columns.Add(col8);

            #endregion


            char delimitador = ';';
            String[] valores;

            OpenFileDialog cargarArchivo = new OpenFileDialog();
            cargarArchivo.InitialDirectory = Application.StartupPath;
            cargarArchivo.Filter = "Archivos *.CSV | *.csv*";

            try
            {
                
                if (cargarArchivo.ShowDialog() == DialogResult.OK)
                {

                    if ((myStream = cargarArchivo.OpenFile()) != null)
                    {

                        StreamReader archivo = new StreamReader(cargarArchivo.FileName);

                        while ((linea = archivo.ReadLine()) != null)
                        {

                            if (counter >= 1)
                            {
                                valores = linea.Split(delimitador);

                                dtgNomina.Rows.Add(valores.ToArray());
                                counter++;

                            }
                            else
                            {
                                counter++;
                            }

                        }

                    }


                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }



        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuPrincipal == null)
            {
                menuPrincipal = new frmMenuPrincipal();
                menuPrincipal.FormClosed += new FormClosedEventHandler(Cerrarforma);
                menuPrincipal.Show();

            }
            else
            {
                menuPrincipal.Activate();
            }

            this.Close();
        }

        void Cerrarforma(object sender, FormClosedEventArgs e)
        {
            menuPrincipal = null;
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
