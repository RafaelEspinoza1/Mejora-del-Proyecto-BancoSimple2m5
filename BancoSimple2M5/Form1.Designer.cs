namespace BancoSimple2M5
{
    partial class Form1
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
            dgvClientes = new DataGridView();
            btnAgregarCLiente = new Button();
            dgvCuentas = new DataGridView();
            btnAgregarCuenta = new Button();
            btnTransferencia = new Button();
            btnDesactivar = new Button();
            button1 = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 27);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(353, 202);
            dgvClientes.TabIndex = 0;
            // 
            // btnAgregarCLiente
            // 
            btnAgregarCLiente.Location = new Point(32, 242);
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
            dgvCuentas.Location = new Point(383, 27);
            dgvCuentas.Margin = new Padding(3, 2, 3, 2);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(653, 202);
            dgvCuentas.TabIndex = 2;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Location = new Point(519, 242);
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
            btnTransferencia.Location = new Point(680, 242);
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
            btnDesactivar.Location = new Point(508, 295);
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
            button1.Location = new Point(680, 295);
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
            btnBuscar.Location = new Point(29, 280);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 38);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar Cliente";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(201, 286);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(170, 23);
            txtBuscar.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 338);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(button1);
            Controls.Add(btnDesactivar);
            Controls.Add(btnTransferencia);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(dgvCuentas);
            Controls.Add(btnAgregarCLiente);
            Controls.Add(dgvClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
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
    }
}
