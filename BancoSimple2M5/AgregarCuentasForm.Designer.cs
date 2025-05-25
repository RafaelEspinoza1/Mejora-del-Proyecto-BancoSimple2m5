namespace BancoSimple2M5
{
    partial class AgregarCuentasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            txtNumCuenta = new TextBox();
            numSaldo = new NumericUpDown();
            btnAceptar = new Button();
            lblSaldo = new Label();
            btnCancelar = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numSaldo).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(92, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Numero Cuenta";
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.Cursor = Cursors.IBeam;
            txtNumCuenta.Location = new Point(147, 14);
            txtNumCuenta.Margin = new Padding(3, 2, 3, 2);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(119, 23);
            txtNumCuenta.TabIndex = 1;
            // 
            // numSaldo
            // 
            numSaldo.Cursor = Cursors.Hand;
            numSaldo.Location = new Point(147, 56);
            numSaldo.Margin = new Padding(3, 2, 3, 2);
            numSaldo.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numSaldo.Name = "numSaldo";
            numSaldo.Size = new Size(67, 23);
            numSaldo.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(25, 107);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 25);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(25, 64);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(67, 15);
            lblSaldo.TabIndex = 4;
            lblSaldo.Text = "Saldo Incial";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(172, 107);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 25);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarCuentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 160);
            Controls.Add(btnCancelar);
            Controls.Add(lblSaldo);
            Controls.Add(btnAceptar);
            Controls.Add(numSaldo);
            Controls.Add(txtNumCuenta);
            Controls.Add(lblNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarCuentasForm";
            Text = "Agregar cuenta";
            ((System.ComponentModel.ISupportInitialize)numSaldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNumCuenta;
        private NumericUpDown numSaldo;
        private Button btnAceptar;
        private Label lblSaldo;
        private Button btnCancelar;
        private ToolTip toolTip1;
    }
}