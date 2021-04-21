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
    public partial class frmNomina : Form
    {
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

                Nomina += Salariobasico + Extra;

                MessageBox.Show("Nombre: " + txtNombre.Text + "\n" + "Apellido: " + txtApellido.Text + "\n" +
                    "Documento: " + txtDocumento.Text + "\n" + "Cargo: " + cmbCargo.Text + "\n" + "Comision: " + Comision
                    + "\n" + "Axilio de trasporte: " + Auxilio + "\n" + "Salud: " + Salud + "\n" + "Pension: "
                    + Pension + "\n" + "Valor a pagar " + Nomina);
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

            

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double Salariobasico = double.Parse(txtSalario.Text);
                if (Salariobasico > 902000)
                {

                    chkAuxilio.Enabled = false;

                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }
    }
}
