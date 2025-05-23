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
            label1 = new Label();
            txtNumCuenta = new TextBox();
            numSaldo = new NumericUpDown();
            btnAceptar = new Button();
            label2 = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numSaldo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero Cuenta";
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.Location = new Point(241, 23);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(135, 27);
            txtNumCuenta.TabIndex = 1;
            // 
            // numSaldo
            // 
            numSaldo.Location = new Point(241, 79);
            numSaldo.Name = "numSaldo";
            numSaldo.Size = new Size(146, 27);
            numSaldo.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(121, 183);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(124, 33);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 86);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Saldo Incial";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(308, 183);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 33);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarCuentasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 250);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(numSaldo);
            Controls.Add(txtNumCuenta);
            Controls.Add(label1);
            Name = "AgregarCuentasForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numSaldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumCuenta;
        private NumericUpDown numSaldo;
        private Button btnAceptar;
        private Label label2;
        private Button btnCancelar;
    }
}