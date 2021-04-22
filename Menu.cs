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

        //Definición de objetos y variables

        private frmMenuPrincipal menuPrincipal;
        private Stream myStream;
        int counter = 0;
        string linea;

        //Condiciones iniciales del programa

        public frmNomina()
        {
            InitializeComponent();            
        }

        //Botón que calcula y envía por medio de un mbox los resultados de los datos ingresados

        private void btnNomina_Click(object sender, EventArgs e)
        {
            try
            {

                #region [Definición de variables]

                double salarioBasico = double.Parse(txtSalario.Text);
                double extra = double.Parse(txtExtra.Text);
                double nomina = 0;
                double comision = 0;
                double salud = 0;
                double pension = 0;
                double auxilioTransporte = 0;
                double ibc = 0;
                double fondoSolidaridad = 0;
                double descuentos;

                #endregion

                //Condicional que agrega el valor

                if (chkAuxilioTransporte.Checked == true)
                {
                    auxilioTransporte += 106454;
                }
                else
                {
                    auxilioTransporte = 0;
                }

                //Suma de valores fijos a la nómina

                nomina = nomina + (salarioBasico + extra + auxilioTransporte);


                //Condicional que opera en caso de que se le agregue una comisión al valor de la nómina

                if (chkComision.Checked == true)
                {

                    if (rdoQuinientos.Checked == true)
                    {
                        comision = 500000;

                    }
                    else if (rdoOchocientoss.Checked == true)
                    {
                        comision = 800000;
                    }
                    else if (rdoMillon.Checked == true)
                    {
                        comision = 1000000;
                    }
                    else
                    {
                        comision = 0;
                    }

                    nomina += comision;

                }

                //Operación que descuenta los valores de descuento de la pensión y la salud

                salud = (nomina * 4) / 100;
                pension = nomina * 0.04;
                descuentos = salud + pension;

                //Mensajes de salida dependiendo del ingreso del empleado

                if (salarioBasico >= 3608000)
                {
                    
                    //Descuento adicional en caso de que se gane más de cuatro salarios mínimos

                    ibc = ((nomina * 40) / 100);
                    fondoSolidaridad = ((ibc * 1) / 100);
                    descuentos += fondoSolidaridad;
                    nomina = nomina - descuentos;

                    MessageBox.Show("Nombre:\t$" + txtNombre.Text + "\n" + "Apellido:\t$" + txtApellido.Text + "\n" +
                    "Documento:\t$" + txtDocumento.Text + "\n" + "Cargo:\t" + cmbCargo.Text + "\nSalario Básico:\t$" + salarioBasico +
                    "\n" + "Comision:\t$" + comision + "\nExtra:\t$" + extra + "\nDescuentos:\t$-" + descuentos
                    + "\n" + "Axilio de trasporte:\t$" + auxilioTransporte + "\n" + "Salud:\t$-" + salud + "\n" + "Pension:\t$-"
                    + pension + "\nFondo Solidaridad:\t$-" + fondoSolidaridad + "\n" + "Valor a pagar:\t$" + nomina);

                }
                else
                {

                    //En caso de que no, se imprime este

                    nomina = nomina - descuentos;

                    MessageBox.Show("Nombre:\t$" + txtNombre.Text + "\n" + "Apellido:\t$" + txtApellido.Text + "\n" +
                    "Documento:\t$" + txtDocumento.Text + "\n" + "Cargo:\t" + cmbCargo.Text + "\nSalario Básico:\t$" + salarioBasico +  
                    "\n" + "Comision:\t$" + comision + "\nExtra:\t$" + extra + "\nDescuentos:\t$-" + descuentos
                    + "\n" + "Axilio de trasporte:\t$" + auxilioTransporte + "\n" + "Salud:\t$-" + salud + "\n" + "Pension:\t$-"
                    + pension + "\n" + "Valor a pagar:\t$" + nomina);

                }

            }
            catch (Exception x)
            {
                 MessageBox.Show(x.Message);
            }



        }

        //Carga de formulario que llena las variables y datos iniciales del mismo

        private void frmNomina_Load(object sender, EventArgs e)
        {
            try
            {
                #region[llenar combo cargo]

                //Llenado de combobox del cargo que desempeña

                cmbCargo.Items.Clear();
                cmbCargo.Items.Add("Secretaria");
                cmbCargo.Items.Add("Conserje");
                cmbCargo.Items.Add("Director ejecutivo");
                cmbCargo.Items.Add("Vicepresidente");
                
                #endregion

                chkAuxilioTransporte.Visible = false;
                chkAuxilioTransporte.Enabled = false;

                chkComision_CheckedChanged(sender, e);

            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }



        }

        //Método que activa o desactiva la checkbox del auxilio de transporte en caso de que el salario cumpla ciertas condiciones

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

            double Salariobasico = 0;

            try
            {
                Salariobasico = double.Parse(txtSalario.Text);



                if (Salariobasico <= 902000 && Salariobasico > 0)
                {
                    chkAuxilioTransporte.Visible = true;
                    chkAuxilioTransporte.Enabled = true;

                }
                else
                {
                    chkAuxilioTransporte.Checked = false;
                    chkAuxilioTransporte.Visible = false;
                    chkAuxilioTransporte.Enabled = false;
                }

            }

            catch
            {
                chkAuxilioTransporte.Checked = false;
                chkAuxilioTransporte.Visible = false;
                chkAuxilioTransporte.Enabled = false;
                Salariobasico = 0;
                txtSalario.Text = "";


            }
        }

        //CheckBox que activa o desactiva radiobuttons en caso de que se seleccione o no

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

        //Botón que limpia todos los datos del formulario cuando esto se requiera

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
                chkAuxilioTransporte.Checked = false;
                chkComision.Checked = false;
                chkAuxilioTransporte.Visible = false;
                chkAuxilioTransporte.Enabled = true;
                dtgNomina.Rows.Clear();
                dtgNomina.Columns.Clear();

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }

        //Botón que carga los datos del archivo .CSV 

        private void btnCargar_Click(object sender, EventArgs e)
        {

            #region [Columnas DataGridView]

            //Limpiado de DataGridView en caso de que se vaya a cargar un archivo nuevo

            dtgNomina.Rows.Clear();
            dtgNomina.Columns.Clear();

            //Llenado de columnas con sus propiedades

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

            //Definición de variables

            char delimitador = ';';
            String[] valores;

            //Carga de archivo .CSV desde el directorio de Windows

            OpenFileDialog cargarArchivo = new OpenFileDialog();
            cargarArchivo.InitialDirectory = Application.StartupPath;
            cargarArchivo.Filter = "Archivos *.CSV | *.csv*";

            try
            {

                //Condicional que verifica si se seleccionó un archivo
                
                if (cargarArchivo.ShowDialog() == DialogResult.OK)
                {

                    //Condicional que verifica si el archivo no está vacío

                    if ((myStream = cargarArchivo.OpenFile()) != null)
                    {

                        //Procedimiento que lee los datos del archivo y los carga a las filas del dtg

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

        //Opción de MenuStrip de cerrado de formulario

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //En caso de que se cierre, instancia el formulario principal y lo vuelve a mostrar

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

        //Método que limpia las propiedades del objeto

        void Cerrarforma(object sender, FormClosedEventArgs e)
        {
            menuPrincipal = null;
        }

        //Mensaje de salida, confirmación de cerrado de formulario

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
