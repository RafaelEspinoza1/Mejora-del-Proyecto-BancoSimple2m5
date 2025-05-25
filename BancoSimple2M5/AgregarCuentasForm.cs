using BancoSimple2M5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimple2M5
{
    public partial class AgregarCuentasForm : Form
    {
        public Cuenta NuevaCuenta { get; private set; }
        private int _clienteId;
        public AgregarCuentasForm(int clienteId)
        {
            InitializeComponent();
            _clienteId = clienteId;
            toolTip1.SetToolTip(numSaldo, "Saldo maximo a ingresar de 500 dolares");
        }
        // metodo que permite agregar una nueva cuenta a la base de datos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNumCuenta.Text))
                {
                    MessageBox.Show("Ingrese el numero de cuenta");
                    return;
                }
                else
                {
                    NuevaCuenta = new Cuenta
                    {
                        NumeroCuenta = txtNumCuenta.Text,
                        Saldo = numSaldo.Value,
                        ClienteId = _clienteId,
                        Activo = true
                    };
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al agregar la cuenta:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cierra el formulario
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
