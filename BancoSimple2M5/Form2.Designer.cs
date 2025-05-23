namespace BancoSimple2M5
{
    partial class Form2
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).BeginInit();
            SuspendLayout();
            // 
            // dgvTransferencias
            // 
            dgvTransferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferencias.Location = new Point(60, 48);
            dgvTransferencias.Name = "dgvTransferencias";
            dgvTransferencias.RowHeadersWidth = 51;
            dgvTransferencias.Size = new Size(430, 278);
            dgvTransferencias.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(126, 362);
            button1.Name = "button1";
            button1.Size = new Size(92, 44);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dgvTransferencias);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransferencias;
        private Button button1;
    }
}