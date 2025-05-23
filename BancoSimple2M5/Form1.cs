using BancoSimple2M5.Data;
using Microsoft.EntityFrameworkCore;
using BancoSimple2M5.Models ;

namespace BancoSimple2M5
{
    public partial class Form1 : Form
    {
        private BancoSimple2M5Context _db = new BancoSimple2M5Context();
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var cuenta = _db.Cuentas.
                Include(c => c.Cliente).
                Where(c => c.Activo).
                Select(c => new
                {
                    c.CuentaId,
                    c.NumeroCuenta,
                    c.Saldo,
                    c.Activo,
                    c.ClienteId,
                    c.Cliente.Nombre
                }


                ).ToList();
            dgvClientes.DataSource = _db.Clientes.ToList();
            dgvCuentas.DataSource = cuenta;
        }

        private void btnAgregarCLiente_Click(object sender, EventArgs e)
        {
            var form = new AgregarClienteForms();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _db.Clientes.Add(form.NuevoCliente);
                _db.SaveChanges();
                CargarDatos();
            }
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero");
                return;
            }
            var clienteId = (int)dgvClientes.SelectedRows[0].Cells["ClienteId"].Value;
            var form = new AgregarCuentasForm(clienteId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _db.Cuentas.Add(form.NuevaCuenta);
                _db.SaveChanges();
                CargarDatos();
            }
        }

        private void RealizarTransfrencia(int origenId, int destinoId, decimal monto)
        {
            //Transacciones
            //Niveles de aislamiento
            using var transaccion = _db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            {
                try
                {
                    var cuentaOrigen = _db.Cuentas.FirstOrDefault(c => c.CuentaId == origenId);
                    var cuentaDestino = _db.Cuentas.FirstOrDefault(c => c.CuentaId == destinoId);

                    if (cuentaOrigen.Saldo < monto)
                    {
                        throw new Exception("Saldo Insuficiente ");
                    }

                    cuentaOrigen.Saldo -= monto;
                    cuentaDestino.Saldo += monto;

                    //Registrar la transaccion
                    _db.Transacciones.Add(new Transaccion
                    {
                        Monto = monto,
                        Fecha = DateTime.Now,
                        Descripcion = "Transferencia",
                        CuentaOrigenId = origenId,
                        CuentaDestinoId = destinoId
                    });
                    _db.SaveChanges();
                    //Transaccion completada
                    transaccion.Commit();
                    MessageBox.Show("Transferencia realizada con exito");
                    CargarDatos();


                }
                catch (Exception ex)
                {
                    //Reversion de transacciones
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione exactamente 2 cuentas");
                return;

            }
            else
            {
                var cuentaOrigenId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
                var cuentaDestinoId = (int)dgvCuentas.SelectedRows[1].Cells["CuentaId"].Value;

                var form = new TransferenciaForms(cuentaOrigenId, cuentaDestinoId);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RealizarTransfrencia(cuentaOrigenId, cuentaDestinoId, form.Monto);
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones una cuenta para desactivar");
            }
            var cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            var cuenta = _db.Cuentas.Find(cuentaId);
            cuenta.Activo = false;
            _db.SaveChanges();
            CargarDatos();
        }

        private void btnVerTransferencias_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // busqueda con patrones con like
            var like = txtBuscar.Text;
            var clientes = _db.Clientes.
                Where
                (c => EF.Functions.Like(c.Nombre, $"%{like}%")).
                ToList();
            dgvClientes.DataSource = clientes;

        }
    }
}
