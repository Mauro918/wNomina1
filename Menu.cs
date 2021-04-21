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

                    chkAuxilio.Visible = false;
                    chkAuxilio.Enabled = false;
                }

            }
            catch 
            {
                txtSalario.Text = "";
                Salariobasico = 0;
                
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            #region[crear columnas]
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Nombre";
            col1.Width = 200;
            col1.ReadOnly = true;
            dtgNomina.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Apillido";
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
            col5.HeaderText = "Comiccion";
            col5.Width = 200;
            col5.ReadOnly = true;
            dtgNomina.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Axilio de trasporte";
            col6.Width = 200;
            col6.ReadOnly = true;
            dtgNomina.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Salud";
            col7.Width = 200;
            col7.ReadOnly = true;
            dtgNomina.Columns.Add(col7);

            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Pension";
            col8.Width = 200;
            col8.ReadOnly = true;
            dtgNomina.Columns.Add(col8);

            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
            col9.HeaderText = "Valor a pagar";
            col9.Width = 200;
            col9.ReadOnly = true;
            dtgNomina.Columns.Add(col9);
            #endregion

            dtgNomina.Rows.Add();
            dtgNomina[0, 0].Value = txtNombre.Text;
            dtgNomina[1, 0].Value = txtApellido.Text;
            dtgNomina[2, 0].Value = txtDocumento.Text;
            dtgNomina[3, 0].Value = cmbCargo.Text;
            dtgNomina[4, 0].Value = txtNombre.Text;
            dtgNomina[7, 0].Value = txtNombre.Text; 
            dtgNomina[5, 0].Value = txtNombre.Text;
            dtgNomina[6, 0].Value = txtNombre.Text;
            dtgNomina[8, 0].Value = txtNombre.Text;

        }

        
    }
}
