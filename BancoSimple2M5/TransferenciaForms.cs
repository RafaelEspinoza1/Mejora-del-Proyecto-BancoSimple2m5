using BancoSimple2M5.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class TransferenciaForms : Form
    {
        public int _cuentaOrigenId;
        public int _cuentaDestinoId;
        public decimal Monto { get; private set; }
        private BancoSimple2M5Context db;
        public TransferenciaForms(int cuentaOrigenId, int cuentaDestinoId)
        {
            InitializeComponent();
            _cuentaDestinoId = cuentaDestinoId;
            _cuentaOrigenId = cuentaOrigenId;
            db = new BancoSimple2M5Context();
            CargarDatosCuentas();
            toolTip1.SetToolTip(numMonto, "Transferencia maxima de 200 dolares");
        }
        // Carga los datos de las cuentas origen y destino en los labels
        private void CargarDatosCuentas()
        {
            try
            {
                var cuentaOrigen = db.Cuentas.Include(c => c.Cliente).
                First(c => c.CuentaId == _cuentaOrigenId);
                var cuentaDestino = db.Cuentas.Include(c => c.Cliente).
                   First(c => c.CuentaId == _cuentaDestinoId);

                lblOrigen.Text = $"CUENTA ORIGEN: {cuentaOrigen.Cliente.Nombre} - {cuentaOrigen.NumeroCuenta}";
                lblDestino.Text = $"CUENTA Destino: {cuentaDestino.Cliente.Nombre} - {cuentaDestino.NumeroCuenta}";
                lblMonto.Text = $"Saldo disponible: {cuentaOrigen.Saldo}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inerperado al cargar los datos de las cuentas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        // Metodo que permite realizar la transferencia de dinero entre cuentas
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                if (numMonto.Value > 0)
                {
                    Monto = numMonto.Value;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ingrese un mnot valido mayor a 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al realizar la transferencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // Cierra el formulario sin realizar la transferencia
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
