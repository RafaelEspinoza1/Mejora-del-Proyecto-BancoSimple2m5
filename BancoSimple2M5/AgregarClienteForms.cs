using BancoSimple2M5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimple2M5
{
    public partial class AgregarClienteForms : Form
    {
        public Cliente NuevoCliente { get; private set; }
        public AgregarClienteForms()
        {
            InitializeComponent();
            toolTip1.SetToolTip(maskedTextBoxIdentificacion, "deben ser 13 numeros y una letra al final");
        }
        // Agrega un nuevo cliente a la base de datos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(maskedTextBoxIdentificacion.Text))
                {
                    MessageBox.Show("Todos los campos son necesarios");
                    return;
                }
                NuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Identificacion = maskedTextBoxIdentificacion.Text
                };
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al agregar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // Cierra el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cerrar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
