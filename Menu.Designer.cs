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
            this.chkAuxilio = new System.Windows.Forms.CheckBox();
            this.grbTotalvendido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.UseWaitCursor = true;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(45, 75);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 1;
            this.lblDocumento.Text = "Documento";
            this.lblDocumento.UseWaitCursor = true;
            // 
            // lblSalariobasico
            // 
            this.lblSalariobasico.AutoSize = true;
            this.lblSalariobasico.Location = new System.Drawing.Point(45, 118);
            this.lblSalariobasico.Name = "lblSalariobasico";
            this.lblSalariobasico.Size = new System.Drawing.Size(73, 13);
            this.lblSalariobasico.TabIndex = 2;
            this.lblSalariobasico.Text = "Salario basico";
            this.lblSalariobasico.UseWaitCursor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(284, 33);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.UseWaitCursor = true;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(284, 78);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.UseWaitCursor = true;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(284, 118);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(31, 13);
            this.lblExtra.TabIndex = 5;
            this.lblExtra.Text = "Extra";
            this.lblExtra.UseWaitCursor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.UseWaitCursor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(128, 78);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 9;
            this.txtDocumento.UseWaitCursor = true;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(128, 115);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.UseWaitCursor = true;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(340, 30);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.UseWaitCursor = true;
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(340, 118);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(100, 20);
            this.txtExtra.TabIndex = 13;
            this.txtExtra.UseWaitCursor = true;
            // 
            // chkComision
            // 
            this.chkComision.AutoSize = true;
            this.chkComision.Checked = true;
            this.chkComision.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkComision.Location = new System.Drawing.Point(48, 250);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(68, 17);
            this.chkComision.TabIndex = 15;
            this.chkComision.Text = "Comision";
            this.chkComision.UseVisualStyleBackColor = true;
            this.chkComision.UseWaitCursor = true;
            this.chkComision.CheckedChanged += new System.EventHandler(this.chkComision_CheckedChanged);
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(340, 70);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(121, 21);
            this.cmbCargo.TabIndex = 16;
            this.cmbCargo.UseWaitCursor = true;
            // 
            // grbTotalvendido
            // 
            this.grbTotalvendido.Controls.Add(this.rdoMillon);
            this.grbTotalvendido.Controls.Add(this.rdoOchocientoss);
            this.grbTotalvendido.Controls.Add(this.rdoQuinientos);
            this.grbTotalvendido.Location = new System.Drawing.Point(211, 250);
            this.grbTotalvendido.Name = "grbTotalvendido";
            this.grbTotalvendido.Size = new System.Drawing.Size(200, 100);
            this.grbTotalvendido.TabIndex = 17;
            this.grbTotalvendido.TabStop = false;
            this.grbTotalvendido.Text = "Total vendido";
            this.grbTotalvendido.UseWaitCursor = true;
            // 
            // rdoMillon
            // 
            this.rdoMillon.AutoSize = true;
            this.rdoMillon.Location = new System.Drawing.Point(16, 66);
            this.rdoMillon.Name = "rdoMillon";
            this.rdoMillon.Size = new System.Drawing.Size(72, 17);
            this.rdoMillon.TabIndex = 18;
            this.rdoMillon.TabStop = true;
            this.rdoMillon.Text = "1\'000.000";
            this.rdoMillon.UseVisualStyleBackColor = true;
            this.rdoMillon.UseWaitCursor = true;
            // 
            // rdoOchocientoss
            // 
            this.rdoOchocientoss.AutoSize = true;
            this.rdoOchocientoss.Location = new System.Drawing.Point(16, 43);
            this.rdoOchocientoss.Name = "rdoOchocientoss";
            this.rdoOchocientoss.Size = new System.Drawing.Size(64, 17);
            this.rdoOchocientoss.TabIndex = 18;
            this.rdoOchocientoss.TabStop = true;
            this.rdoOchocientoss.Text = "800.000";
            this.rdoOchocientoss.UseVisualStyleBackColor = true;
            this.rdoOchocientoss.UseWaitCursor = true;
            // 
            // rdoQuinientos
            // 
            this.rdoQuinientos.AutoSize = true;
            this.rdoQuinientos.Location = new System.Drawing.Point(16, 20);
            this.rdoQuinientos.Name = "rdoQuinientos";
            this.rdoQuinientos.Size = new System.Drawing.Size(64, 17);
            this.rdoQuinientos.TabIndex = 0;
            this.rdoQuinientos.TabStop = true;
            this.rdoQuinientos.Text = "500.000";
            this.rdoQuinientos.UseVisualStyleBackColor = true;
            this.rdoQuinientos.UseWaitCursor = true;
            // 
            // btnNomina
            // 
            this.btnNomina.Location = new System.Drawing.Point(432, 250);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(121, 23);
            this.btnNomina.TabIndex = 18;
            this.btnNomina.Text = "Generar nomina";
            this.btnNomina.UseVisualStyleBackColor = true;
            this.btnNomina.UseWaitCursor = true;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(432, 327);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.UseWaitCursor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtgNomina
            // 
            this.dtgNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNomina.Location = new System.Drawing.Point(504, 30);
            this.dtgNomina.Name = "dtgNomina";
            this.dtgNomina.Size = new System.Drawing.Size(303, 123);
            this.dtgNomina.TabIndex = 20;
            this.dtgNomina.UseWaitCursor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(604, 287);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 21;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.UseWaitCursor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // chkAuxilio
            // 
            this.chkAuxilio.AutoSize = true;
            this.chkAuxilio.Location = new System.Drawing.Point(45, 200);
            this.chkAuxilio.Name = "chkAuxilio";
            this.chkAuxilio.Size = new System.Drawing.Size(115, 17);
            this.chkAuxilio.TabIndex = 22;
            this.chkAuxilio.Text = "Auxilio de trasporte";
            this.chkAuxilio.UseVisualStyleBackColor = true;
            this.chkAuxilio.UseWaitCursor = true;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.chkAuxilio);
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
            this.DoubleBuffered = true;
            this.Name = "frmNomina";
            this.Text = "Nomina";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmNomina_Load);
            this.grbTotalvendido.ResumeLayout(false);
            this.grbTotalvendido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNomina)).EndInit();
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
        private System.Windows.Forms.CheckBox chkAuxilio;
    }
}

