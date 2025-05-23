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
        }
        private void CargarDatosCuentas()
        {
            var cuentaOrigen = db.Cuentas.Include(c => c.Cliente).
                First(c => c.CuentaId == _cuentaOrigenId);
            var cuentaDestino = db.Cuentas.Include(c => c.Cliente).
               First(c => c.CuentaId == _cuentaDestinoId);

            lblOrigen.Text = $"CUENTA ORIGEN: {cuentaOrigen.Cliente.Nombre} - {cuentaOrigen.NumeroCuenta}";
            lblDestino.Text = $"CUENTA Destino: {cuentaDestino.Cliente.Nombre} - {cuentaDestino.NumeroCuenta}";
            lblMonto.Text = $"Saldo disponible: {cuentaOrigen.Saldo}";

        }

        private void btnTransferir_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
