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
    public partial class AgregarCuentasForm : Form
    {
        public Cuenta NuevaCuenta { get; private set; }
        private int _clienteId;
        public AgregarCuentasForm(int clienteId)
        {
            InitializeComponent();
            _clienteId = clienteId;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
