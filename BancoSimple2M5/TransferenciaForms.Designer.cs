namespace BancoSimple2M5
{
    partial class TransferenciaForms
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
            lblOrigen = new Label();
            numMonto = new NumericUpDown();
            btnTransferir = new Button();
            lblMonto = new Label();
            lblDestino = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(45, 39);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(50, 20);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "label1";
            // 
            // numMonto
            // 
            numMonto.Location = new Point(216, 86);
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(89, 27);
            numMonto.TabIndex = 1;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(69, 172);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(102, 42);
            btnTransferir.TabIndex = 2;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(45, 86);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(130, 20);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto a Transferir";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(45, 139);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 20);
            lblDestino.TabIndex = 4;
            lblDestino.Text = "label3";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(303, 172);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 42);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TransferenciaForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 298);
            Controls.Add(btnCancelar);
            Controls.Add(lblDestino);
            Controls.Add(lblMonto);
            Controls.Add(btnTransferir);
            Controls.Add(numMonto);
            Controls.Add(lblOrigen);
            Name = "TransferenciaForms";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrigen;
        private NumericUpDown numMonto;
        private Button btnTransferir;
        private Label lblMonto;
        private Label lblDestino;
        private Button btnCancelar;
    }
}