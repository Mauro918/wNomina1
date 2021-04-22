namespace wNomina1
{
    partial class frmNomina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblSalariobasico = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.chkComision = new System.Windows.Forms.CheckBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.grbTotalvendido = new System.Windows.Forms.GroupBox();
            this.rdoMillon = new System.Windows.Forms.RadioButton();
            this.rdoOchocientoss = new System.Windows.Forms.RadioButton();
            this.rdoQuinientos = new System.Windows.Forms.RadioButton();
            this.btnNomina = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtgNomina = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.chkAuxilioTransporte = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTotalvendido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNomina)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(37, 122);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 1;
            this.lblDocumento.Text = "Documento";
            // 
            // lblSalariobasico
            // 
            this.lblSalariobasico.AutoSize = true;
            this.lblSalariobasico.Location = new System.Drawing.Point(37, 165);
            this.lblSalariobasico.Name = "lblSalariobasico";
            this.lblSalariobasico.Size = new System.Drawing.Size(73, 13);
            this.lblSalariobasico.TabIndex = 2;
            this.lblSalariobasico.Text = "Salario basico";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(276, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(276, 125);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(276, 165);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(31, 13);
            this.lblExtra.TabIndex = 5;
            this.lblExtra.Text = "Extra";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(120, 119);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(120, 162);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(332, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(332, 162);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(100, 20);
            this.txtExtra.TabIndex = 13;
            // 
            // chkComision
            // 
            this.chkComision.AutoSize = true;
            this.chkComision.Location = new System.Drawing.Point(40, 311);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(68, 17);
            this.chkComision.TabIndex = 15;
            this.chkComision.Text = "Comision";
            this.chkComision.UseVisualStyleBackColor = true;
            this.chkComision.CheckedChanged += new System.EventHandler(this.chkComision_CheckedChanged);
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(332, 122);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(100, 21);
            this.cmbCargo.TabIndex = 16;
            // 
            // grbTotalvendido
            // 
            this.grbTotalvendido.Controls.Add(this.rdoMillon);
            this.grbTotalvendido.Controls.Add(this.rdoOchocientoss);
            this.grbTotalvendido.Controls.Add(this.rdoQuinientos);
            this.grbTotalvendido.Location = new System.Drawing.Point(206, 311);
            this.grbTotalvendido.Name = "grbTotalvendido";
            this.grbTotalvendido.Size = new System.Drawing.Size(239, 134);
            this.grbTotalvendido.TabIndex = 17;
            this.grbTotalvendido.TabStop = false;
            this.grbTotalvendido.Text = "Total vendido";
            // 
            // rdoMillon
            // 
            this.rdoMillon.AutoSize = true;
            this.rdoMillon.Location = new System.Drawing.Point(28, 89);
            this.rdoMillon.Name = "rdoMillon";
            this.rdoMillon.Size = new System.Drawing.Size(72, 17);
            this.rdoMillon.TabIndex = 18;
            this.rdoMillon.TabStop = true;
            this.rdoMillon.Text = "1\'000.000";
            this.rdoMillon.UseVisualStyleBackColor = true;
            // 
            // rdoOchocientoss
            // 
            this.rdoOchocientoss.AutoSize = true;
            this.rdoOchocientoss.Location = new System.Drawing.Point(28, 66);
            this.rdoOchocientoss.Name = "rdoOchocientoss";
            this.rdoOchocientoss.Size = new System.Drawing.Size(64, 17);
            this.rdoOchocientoss.TabIndex = 18;
            this.rdoOchocientoss.TabStop = true;
            this.rdoOchocientoss.Text = "800.000";
            this.rdoOchocientoss.UseVisualStyleBackColor = true;
            // 
            // rdoQuinientos
            // 
            this.rdoQuinientos.AutoSize = true;
            this.rdoQuinientos.Location = new System.Drawing.Point(28, 43);
            this.rdoQuinientos.Name = "rdoQuinientos";
            this.rdoQuinientos.Size = new System.Drawing.Size(64, 17);
            this.rdoQuinientos.TabIndex = 0;
            this.rdoQuinientos.TabStop = true;
            this.rdoQuinientos.Text = "500.000";
            this.rdoQuinientos.UseVisualStyleBackColor = true;
            // 
            // btnNomina
            // 
            this.btnNomina.Location = new System.Drawing.Point(557, 311);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(215, 46);
            this.btnNomina.TabIndex = 18;
            this.btnNomina.Text = "Generar nomina";
            this.btnNomina.UseVisualStyleBackColor = true;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(557, 421);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(215, 46);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtgNomina
            // 
            this.dtgNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNomina.Location = new System.Drawing.Point(481, 30);
            this.dtgNomina.Name = "dtgNomina";
            this.dtgNomina.Size = new System.Drawing.Size(593, 214);
            this.dtgNomina.TabIndex = 20;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(852, 368);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(169, 46);
            this.btnCargar.TabIndex = 21;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // chkAuxilioTransporte
            // 
            this.chkAuxilioTransporte.AutoSize = true;
            this.chkAuxilioTransporte.Location = new System.Drawing.Point(37, 244);
            this.chkAuxilioTransporte.Name = "chkAuxilioTransporte";
            this.chkAuxilioTransporte.Size = new System.Drawing.Size(115, 17);
            this.chkAuxilioTransporte.TabIndex = 22;
            this.chkAuxilioTransporte.Text = "Auxilio de trasporte";
            this.chkAuxilioTransporte.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 618);
            this.ControlBox = false;
            this.Controls.Add(this.chkAuxilioTransporte);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtgNomina);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnNomina);
            this.Controls.Add(this.grbTotalvendido);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.chkComision);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblSalariobasico);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNomina";
            this.Text = "Nomina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmNomina_Load);
            this.grbTotalvendido.ResumeLayout(false);
            this.grbTotalvendido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNomina)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblSalariobasico;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.CheckBox chkComision;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.GroupBox grbTotalvendido;
        private System.Windows.Forms.RadioButton rdoMillon;
        private System.Windows.Forms.RadioButton rdoOchocientoss;
        private System.Windows.Forms.RadioButton rdoQuinientos;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dtgNomina;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.CheckBox chkAuxilioTransporte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}

