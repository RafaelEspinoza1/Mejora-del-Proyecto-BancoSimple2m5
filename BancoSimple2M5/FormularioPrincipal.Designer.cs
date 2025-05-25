namespace BancoSimple2M5
{
    partial class PaginaPrincipalDelBanco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvClientes = new DataGridView();
            btnAgregarCLiente = new Button();
            dgvCuentas = new DataGridView();
            btnAgregarCuenta = new Button();
            btnTransferencia = new Button();
            btnDesactivar = new Button();
            button1 = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            pictureBoxRefrescar = new PictureBox();
            toolTip1 = new ToolTip(components);
            groupBoxBuscarClientes = new GroupBox();
            pictureBoxCerrarGroupBoxBuscar1 = new PictureBox();
            radioButtonIdentificacionCliente = new RadioButton();
            radioButtonNombreCliente = new RadioButton();
            radioButtonClienteId = new RadioButton();
            btnBuscarClientes = new Button();
            btnBuscarCuenta = new Button();
            groupBoxBuscarCuenta = new GroupBox();
            pictureBoxCerrarGroupBoxBuscar2 = new PictureBox();
            txtBuscarEnCuentas = new TextBox();
            btnBuscarEnCuentas = new Button();
            radioButtonSaldo = new RadioButton();
            radioButtonNumeroDeCuenta = new RadioButton();
            radioButtonCuentaId = new RadioButton();
            radioButtonNombre2 = new RadioButton();
            radioButtonClienteId2 = new RadioButton();
            lblClientes = new Label();
            lblCuentas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefrescar).BeginInit();
            groupBoxBuscarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarGroupBoxBuscar1).BeginInit();
            groupBoxBuscarCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarGroupBoxBuscar2).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Cursor = Cursors.Hand;
            dgvClientes.Location = new Point(12, 42);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(370, 202);
            dgvClientes.TabIndex = 0;
            // 
            // btnAgregarCLiente
            // 
            btnAgregarCLiente.Cursor = Cursors.Hand;
            btnAgregarCLiente.Location = new Point(17, 251);
            btnAgregarCLiente.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCLiente.Name = "btnAgregarCLiente";
            btnAgregarCLiente.Size = new Size(131, 25);
            btnAgregarCLiente.TabIndex = 1;
            btnAgregarCLiente.Text = "Agregar Cliente";
            btnAgregarCLiente.UseVisualStyleBackColor = true;
            btnAgregarCLiente.Click += btnAgregarCLiente_Click;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Cursor = Cursors.Hand;
            dgvCuentas.Location = new Point(393, 42);
            dgvCuentas.Margin = new Padding(3, 2, 3, 2);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(670, 202);
            dgvCuentas.TabIndex = 2;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Cursor = Cursors.Hand;
            btnAgregarCuenta.Location = new Point(403, 251);
            btnAgregarCuenta.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(131, 25);
            btnAgregarCuenta.TabIndex = 3;
            btnAgregarCuenta.Text = "Agregar Cuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += btnAgregarCuenta_Click;
            // 
            // btnTransferencia
            // 
            btnTransferencia.Cursor = Cursors.Hand;
            btnTransferencia.Location = new Point(559, 251);
            btnTransferencia.Margin = new Padding(3, 2, 3, 2);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(131, 25);
            btnTransferencia.TabIndex = 4;
            btnTransferencia.Text = "Transferir";
            btnTransferencia.UseVisualStyleBackColor = true;
            btnTransferencia.Click += btnTransferencia_Click;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Cursor = Cursors.Hand;
            btnDesactivar.Location = new Point(403, 286);
            btnDesactivar.Margin = new Padding(3, 2, 3, 2);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(131, 25);
            btnDesactivar.TabIndex = 5;
            btnDesactivar.Text = "Desactivar cuentar";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(559, 286);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(131, 25);
            button1.TabIndex = 6;
            button1.Text = "Ver transferencias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnVerTransferencias_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(15, 107);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscaClienteGroupbox_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.Location = new Point(123, 107);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(170, 23);
            txtBuscar.TabIndex = 8;
            // 
            // pictureBoxRefrescar
            // 
            pictureBoxRefrescar.Cursor = Cursors.Hand;
            pictureBoxRefrescar.Image = Properties.Resources.reinciar;
            pictureBoxRefrescar.Location = new Point(12, 12);
            pictureBoxRefrescar.Name = "pictureBoxRefrescar";
            pictureBoxRefrescar.Size = new Size(25, 25);
            pictureBoxRefrescar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRefrescar.TabIndex = 9;
            pictureBoxRefrescar.TabStop = false;
            pictureBoxRefrescar.Click += PixtureBoxRefrecardgvs_Click;
            // 
            // groupBoxBuscarClientes
            // 
            groupBoxBuscarClientes.Controls.Add(pictureBoxCerrarGroupBoxBuscar1);
            groupBoxBuscarClientes.Controls.Add(radioButtonIdentificacionCliente);
            groupBoxBuscarClientes.Controls.Add(radioButtonNombreCliente);
            groupBoxBuscarClientes.Controls.Add(radioButtonClienteId);
            groupBoxBuscarClientes.Controls.Add(btnBuscar);
            groupBoxBuscarClientes.Controls.Add(txtBuscar);
            groupBoxBuscarClientes.Location = new Point(17, 290);
            groupBoxBuscarClientes.Name = "groupBoxBuscarClientes";
            groupBoxBuscarClientes.Size = new Size(349, 143);
            groupBoxBuscarClientes.TabIndex = 10;
            groupBoxBuscarClientes.TabStop = false;
            groupBoxBuscarClientes.Text = "Buscar Clientes";
            groupBoxBuscarClientes.Visible = false;
            // 
            // pictureBoxCerrarGroupBoxBuscar1
            // 
            pictureBoxCerrarGroupBoxBuscar1.Cursor = Cursors.Hand;
            pictureBoxCerrarGroupBoxBuscar1.Image = Properties.Resources.cerrar;
            pictureBoxCerrarGroupBoxBuscar1.Location = new Point(318, 16);
            pictureBoxCerrarGroupBoxBuscar1.Name = "pictureBoxCerrarGroupBoxBuscar1";
            pictureBoxCerrarGroupBoxBuscar1.Size = new Size(25, 25);
            pictureBoxCerrarGroupBoxBuscar1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrarGroupBoxBuscar1.TabIndex = 12;
            pictureBoxCerrarGroupBoxBuscar1.TabStop = false;
            pictureBoxCerrarGroupBoxBuscar1.Click += pictureBoxCerrar_Click;
            // 
            // radioButtonIdentificacionCliente
            // 
            radioButtonIdentificacionCliente.AutoSize = true;
            radioButtonIdentificacionCliente.Cursor = Cursors.Hand;
            radioButtonIdentificacionCliente.Location = new Point(15, 72);
            radioButtonIdentificacionCliente.Name = "radioButtonIdentificacionCliente";
            radioButtonIdentificacionCliente.Size = new Size(97, 19);
            radioButtonIdentificacionCliente.TabIndex = 11;
            radioButtonIdentificacionCliente.TabStop = true;
            radioButtonIdentificacionCliente.Text = "Identificación";
            radioButtonIdentificacionCliente.UseVisualStyleBackColor = true;
            // 
            // radioButtonNombreCliente
            // 
            radioButtonNombreCliente.AutoSize = true;
            radioButtonNombreCliente.Cursor = Cursors.Hand;
            radioButtonNombreCliente.Location = new Point(15, 47);
            radioButtonNombreCliente.Name = "radioButtonNombreCliente";
            radioButtonNombreCliente.Size = new Size(69, 19);
            radioButtonNombreCliente.TabIndex = 10;
            radioButtonNombreCliente.TabStop = true;
            radioButtonNombreCliente.Text = "Nombre";
            radioButtonNombreCliente.UseVisualStyleBackColor = true;
            // 
            // radioButtonClienteId
            // 
            radioButtonClienteId.AutoSize = true;
            radioButtonClienteId.Cursor = Cursors.Hand;
            radioButtonClienteId.Location = new Point(15, 22);
            radioButtonClienteId.Name = "radioButtonClienteId";
            radioButtonClienteId.Size = new Size(72, 19);
            radioButtonClienteId.TabIndex = 9;
            radioButtonClienteId.TabStop = true;
            radioButtonClienteId.Text = "ClienteId";
            radioButtonClienteId.UseVisualStyleBackColor = true;
            // 
            // btnBuscarClientes
            // 
            btnBuscarClientes.Cursor = Cursors.Hand;
            btnBuscarClientes.Location = new Point(165, 253);
            btnBuscarClientes.Name = "btnBuscarClientes";
            btnBuscarClientes.Size = new Size(131, 25);
            btnBuscarClientes.TabIndex = 11;
            btnBuscarClientes.Text = "Buscar Clientes";
            btnBuscarClientes.UseVisualStyleBackColor = true;
            btnBuscarClientes.Click += btnBuscarClientes_Click;
            // 
            // btnBuscarCuenta
            // 
            btnBuscarCuenta.Cursor = Cursors.Hand;
            btnBuscarCuenta.Location = new Point(725, 253);
            btnBuscarCuenta.Name = "btnBuscarCuenta";
            btnBuscarCuenta.Size = new Size(124, 23);
            btnBuscarCuenta.TabIndex = 12;
            btnBuscarCuenta.Text = "Buscar cuenta";
            btnBuscarCuenta.UseVisualStyleBackColor = true;
            btnBuscarCuenta.Click += btnBuscarCuenta_Click;
            // 
            // groupBoxBuscarCuenta
            // 
            groupBoxBuscarCuenta.Controls.Add(pictureBoxCerrarGroupBoxBuscar2);
            groupBoxBuscarCuenta.Controls.Add(txtBuscarEnCuentas);
            groupBoxBuscarCuenta.Controls.Add(btnBuscarEnCuentas);
            groupBoxBuscarCuenta.Controls.Add(radioButtonSaldo);
            groupBoxBuscarCuenta.Controls.Add(radioButtonNumeroDeCuenta);
            groupBoxBuscarCuenta.Controls.Add(radioButtonCuentaId);
            groupBoxBuscarCuenta.Controls.Add(radioButtonNombre2);
            groupBoxBuscarCuenta.Controls.Add(radioButtonClienteId2);
            groupBoxBuscarCuenta.Location = new Point(403, 320);
            groupBoxBuscarCuenta.Name = "groupBoxBuscarCuenta";
            groupBoxBuscarCuenta.Size = new Size(515, 100);
            groupBoxBuscarCuenta.TabIndex = 13;
            groupBoxBuscarCuenta.TabStop = false;
            groupBoxBuscarCuenta.Text = "Buscar Cuenta";
            groupBoxBuscarCuenta.Visible = false;
            // 
            // pictureBoxCerrarGroupBoxBuscar2
            // 
            pictureBoxCerrarGroupBoxBuscar2.Cursor = Cursors.Hand;
            pictureBoxCerrarGroupBoxBuscar2.Image = Properties.Resources.cerrar;
            pictureBoxCerrarGroupBoxBuscar2.Location = new Point(484, 16);
            pictureBoxCerrarGroupBoxBuscar2.Name = "pictureBoxCerrarGroupBoxBuscar2";
            pictureBoxCerrarGroupBoxBuscar2.Size = new Size(25, 25);
            pictureBoxCerrarGroupBoxBuscar2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrarGroupBoxBuscar2.TabIndex = 13;
            pictureBoxCerrarGroupBoxBuscar2.TabStop = false;
            pictureBoxCerrarGroupBoxBuscar2.Click += pictureBoxCerrar_Click;
            // 
            // txtBuscarEnCuentas
            // 
            txtBuscarEnCuentas.Cursor = Cursors.IBeam;
            txtBuscarEnCuentas.Location = new Point(322, 68);
            txtBuscarEnCuentas.Name = "txtBuscarEnCuentas";
            txtBuscarEnCuentas.Size = new Size(187, 23);
            txtBuscarEnCuentas.TabIndex = 6;
            // 
            // btnBuscarEnCuentas
            // 
            btnBuscarEnCuentas.Cursor = Cursors.Hand;
            btnBuscarEnCuentas.Location = new Point(241, 67);
            btnBuscarEnCuentas.Name = "btnBuscarEnCuentas";
            btnBuscarEnCuentas.Size = new Size(75, 23);
            btnBuscarEnCuentas.TabIndex = 5;
            btnBuscarEnCuentas.Text = "Buscar";
            btnBuscarEnCuentas.UseVisualStyleBackColor = true;
            btnBuscarEnCuentas.Click += btnBuscarEnCuentas_Click;
            // 
            // radioButtonSaldo
            // 
            radioButtonSaldo.AutoSize = true;
            radioButtonSaldo.Cursor = Cursors.Hand;
            radioButtonSaldo.Location = new Point(6, 72);
            radioButtonSaldo.Name = "radioButtonSaldo";
            radioButtonSaldo.Size = new Size(54, 19);
            radioButtonSaldo.TabIndex = 4;
            radioButtonSaldo.TabStop = true;
            radioButtonSaldo.Text = "Saldo";
            radioButtonSaldo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumeroDeCuenta
            // 
            radioButtonNumeroDeCuenta.AutoSize = true;
            radioButtonNumeroDeCuenta.Cursor = Cursors.Hand;
            radioButtonNumeroDeCuenta.Location = new Point(6, 47);
            radioButtonNumeroDeCuenta.Name = "radioButtonNumeroDeCuenta";
            radioButtonNumeroDeCuenta.Size = new Size(124, 19);
            radioButtonNumeroDeCuenta.TabIndex = 3;
            radioButtonNumeroDeCuenta.TabStop = true;
            radioButtonNumeroDeCuenta.Text = "Numero de cuenta";
            radioButtonNumeroDeCuenta.UseVisualStyleBackColor = true;
            // 
            // radioButtonCuentaId
            // 
            radioButtonCuentaId.AutoSize = true;
            radioButtonCuentaId.Cursor = Cursors.Hand;
            radioButtonCuentaId.Location = new Point(136, 22);
            radioButtonCuentaId.Name = "radioButtonCuentaId";
            radioButtonCuentaId.Size = new Size(73, 19);
            radioButtonCuentaId.TabIndex = 2;
            radioButtonCuentaId.TabStop = true;
            radioButtonCuentaId.Text = "CuentaId";
            radioButtonCuentaId.UseVisualStyleBackColor = true;
            // 
            // radioButtonNombre2
            // 
            radioButtonNombre2.AutoSize = true;
            radioButtonNombre2.Cursor = Cursors.Hand;
            radioButtonNombre2.Location = new Point(136, 47);
            radioButtonNombre2.Name = "radioButtonNombre2";
            radioButtonNombre2.Size = new Size(69, 19);
            radioButtonNombre2.TabIndex = 1;
            radioButtonNombre2.TabStop = true;
            radioButtonNombre2.Text = "Nombre";
            radioButtonNombre2.UseVisualStyleBackColor = true;
            // 
            // radioButtonClienteId2
            // 
            radioButtonClienteId2.AutoSize = true;
            radioButtonClienteId2.Cursor = Cursors.Hand;
            radioButtonClienteId2.Location = new Point(6, 22);
            radioButtonClienteId2.Name = "radioButtonClienteId2";
            radioButtonClienteId2.Size = new Size(72, 19);
            radioButtonClienteId2.TabIndex = 0;
            radioButtonClienteId2.TabStop = true;
            radioButtonClienteId2.Text = "ClienteId";
            radioButtonClienteId2.UseVisualStyleBackColor = true;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(165, 25);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(49, 15);
            lblClientes.TabIndex = 14;
            lblClientes.Text = "Clientes";
            // 
            // lblCuentas
            // 
            lblCuentas.AutoSize = true;
            lblCuentas.Location = new Point(700, 25);
            lblCuentas.Name = "lblCuentas";
            lblCuentas.Size = new Size(50, 15);
            lblCuentas.TabIndex = 15;
            lblCuentas.Text = "Cuentas";
            // 
            // PaginaPrincipalDelBanco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 470);
            Controls.Add(lblClientes);
            Controls.Add(lblCuentas);
            Controls.Add(groupBoxBuscarCuenta);
            Controls.Add(btnBuscarCuenta);
            Controls.Add(btnBuscarClientes);
            Controls.Add(groupBoxBuscarClientes);
            Controls.Add(pictureBoxRefrescar);
            Controls.Add(button1);
            Controls.Add(btnDesactivar);
            Controls.Add(btnTransferencia);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(dgvCuentas);
            Controls.Add(btnAgregarCLiente);
            Controls.Add(dgvClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaginaPrincipalDelBanco";
            Text = "Banco2M5";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefrescar).EndInit();
            groupBoxBuscarClientes.ResumeLayout(false);
            groupBoxBuscarClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarGroupBoxBuscar1).EndInit();
            groupBoxBuscarCuenta.ResumeLayout(false);
            groupBoxBuscarCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarGroupBoxBuscar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnAgregarCLiente;
        private DataGridView dgvCuentas;
        private Button btnAgregarCuenta;
        private Button btnTransferencia;
        private Button btnDesactivar;
        private Button button1;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private PictureBox pictureBoxRefrescar;
        private ToolTip toolTip1;
        private GroupBox groupBoxBuscarClientes;
        private Button btnBuscarClientes;
        private RadioButton radioButtonIdentificacionCliente;
        private RadioButton radioButtonNombreCliente;
        private RadioButton radioButtonClienteId;
        private Button btnBuscarCuenta;
        private GroupBox groupBoxBuscarCuenta;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButtonClienteId2;
        private TextBox txtBuscarEnCuentas;
        private Button btnBuscarEnCuentas;
        private RadioButton radioButtonSaldo;
        private RadioButton radioButtonNumeroDeCuenta;
        private RadioButton radioButtonCuentaId;
        private RadioButton radioButtonNombre2;
        private PictureBox pictureBoxCerrarGroupBoxBuscar1;
        private PictureBox pictureBoxCerrarGroupBoxBuscar2;
        private Label lblClientes;
        private Label lblCuentas;
    }
}
