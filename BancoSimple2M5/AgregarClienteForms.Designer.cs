namespace BancoSimple2M5
{
    partial class AgregarClienteForms
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
            txtNombre = new TextBox();
            btnAceptar = new Button();
            txtIdentificacion = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(231, 13);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(28, 146);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(113, 52);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(231, 70);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(168, 27);
            txtIdentificacion.TabIndex = 4;
            txtIdentificacion.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 70);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 3;
            label2.Text = "Identificacion";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(220, 146);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 52);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarClienteForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 210);
            Controls.Add(btnCancelar);
            Controls.Add(txtIdentificacion);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "AgregarClienteForms";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnAceptar;
        private TextBox txtIdentificacion;
        private Label label2;
        private Button btnCancelar;
    }
}