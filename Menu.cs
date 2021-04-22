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
       
        public frmNomina()
        {
            InitializeComponent();
            

        }
        private Stream myStream;
        int counter = 0;
        string line;


        

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
                

                if (chkAuxilio.Checked == true)
                {
                    Auxilio += 106454;
                    Nomina += Auxilio;

                }

                if (chkComision.Checked == true)
                {
                    
                    if (rdoQuinientos.Checked == true)
                    {
                        Nomina += 500000;
                        Comision = 500000;

                    }
                    else if (rdoOchocientoss.Checked == true)
                    {
                        Nomina += 800000;
                        Comision = 800000;
                    }
                    else if (rdoMillon.Checked == true)
                    {
                        Nomina += 1000000;
                        Comision = 1000000;
                    }
                }

                Salud = Salariobasico * 0.125;
                Pension = Salariobasico * 0.16 ;
                Nomina += Salariobasico + Extra;

                MessageBox.Show("Nombre:        \t$" + txtNombre.Text + "\n" + "Apellido:      \t$" + txtApellido.Text + "\n" +
                    "Documento:           \t$" + txtDocumento.Text + "\n" + "Cargo:         \t$" + cmbCargo.Text + "\n" + "Comision:          \t$" + Comision
                    + "\n" + "Axilio de trasporte:         \t$" + Auxilio + "\n" + "Salud:         \t$" + Salud + "\n" + "Pension:       \t$"
                    + Pension + "\n" + "Valor a pagar        \t$" + Nomina);

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
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }

            chkAuxilio.Visible = false;
            chkAuxilio.Enabled = false;

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
                rdoQuinientos.Enabled = false;
                rdoOchocientoss.Enabled = false;
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

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
          
        }

    }
}
