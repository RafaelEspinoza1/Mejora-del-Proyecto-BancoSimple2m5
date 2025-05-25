namespace BancoSimple2M5
{
    partial class VerTransferenciasForm
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
            dgvTransferencias = new DataGridView();
            btnCerra = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).BeginInit();
            SuspendLayout();
            // 
            // dgvTransferencias
            // 
            dgvTransferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferencias.Cursor = Cursors.Hand;
            dgvTransferencias.Location = new Point(12, 11);
            dgvTransferencias.Margin = new Padding(3, 2, 3, 2);
            dgvTransferencias.Name = "dgvTransferencias";
            dgvTransferencias.RowHeadersWidth = 51;
            dgvTransferencias.Size = new Size(654, 208);
            dgvTransferencias.TabIndex = 0;
            // 
            // btnCerra
            // 
            btnCerra.Cursor = Cursors.Hand;
            btnCerra.Location = new Point(288, 223);
            btnCerra.Margin = new Padding(3, 2, 3, 2);
            btnCerra.Name = "btnCerra";
            btnCerra.Size = new Size(80, 33);
            btnCerra.TabIndex = 1;
            btnCerra.Text = "Cerrar";
            btnCerra.UseVisualStyleBackColor = true;
            btnCerra.Click += btnCerrar_Click;
            // 
            // VerTransferenciasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 263);
            Controls.Add(btnCerra);
            Controls.Add(dgvTransferencias);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VerTransferenciasForm";
            Text = "Tranferencias";
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransferencias;
        private Button btnCerra;
    }
}