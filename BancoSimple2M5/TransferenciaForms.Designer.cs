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
            components = new System.ComponentModel.Container();
            lblOrigen = new Label();
            numMonto = new NumericUpDown();
            btnTransferir = new Button();
            lblMonto = new Label();
            lblDestino = new Label();
            btnCancelar = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(39, 29);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(82, 15);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "Cuenta origen";
            // 
            // numMonto
            // 
            numMonto.Cursor = Cursors.Hand;
            numMonto.Location = new Point(180, 56);
            numMonto.Margin = new Padding(3, 2, 3, 2);
            numMonto.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(78, 23);
            numMonto.TabIndex = 1;
            // 
            // btnTransferir
            // 
            btnTransferir.Cursor = Cursors.Hand;
            btnTransferir.Location = new Point(39, 129);
            btnTransferir.Margin = new Padding(3, 2, 3, 2);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(89, 32);
            btnTransferir.TabIndex = 2;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(39, 64);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(104, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto a Transferir";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(39, 99);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(87, 15);
            lblDestino.TabIndex = 4;
            lblDestino.Text = "Cuenta destino";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(180, 129);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TransferenciaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 206);
            Controls.Add(btnCancelar);
            Controls.Add(lblDestino);
            Controls.Add(lblMonto);
            Controls.Add(btnTransferir);
            Controls.Add(numMonto);
            Controls.Add(lblOrigen);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TransferenciaForms";
            Text = "Realizar transferencia";
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
        private ToolTip toolTip1;
    }
}