using BancoSimple2M5.Data;
using Microsoft.EntityFrameworkCore;
using BancoSimple2M5.Models ;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BancoSimple2M5
{
    public partial class PaginaPrincipalDelBanco : Form
    {
        private BancoSimple2M5Context _db = new BancoSimple2M5Context();
        public PaginaPrincipalDelBanco()
        {
            InitializeComponent();
            CargarDatos();
            toolTip1.SetToolTip(pictureBoxRefrescar, "Refrescar datagridviews clientes y cuentas");
            toolTip1.SetToolTip(pictureBoxCerrarGroupBoxBuscar1, "Cerrar groupBox");
            toolTip1.SetToolTip(pictureBoxCerrarGroupBoxBuscar2, "Cerrar groupBox");
            toolTip1.SetToolTip(radioButtonSaldo, "Busca saldos mayores o iguales al que escribio");
        }

        // Carga los datos de clientes y cuentas activas al iniciar el formulario en los datagridviews.
        private void CargarDatos()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Abre el formulario AgregarCliente, para agregar un nuevo cliente
        private void btnAgregarCLiente_Click(object sender, EventArgs e)
        {
            var FormAgregarCliente = new AgregarClienteForms();
            if (FormAgregarCliente.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _db.Clientes.Add(FormAgregarCliente.NuevoCliente);
                    _db.SaveChanges();
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       // Evento que se ejecuta al hacer clic en el botón "Agregar Cuenta".
       // Verifica si hay un cliente seleccionado en el DataGridView, abre el formulario para agregar una nueva cuenta
       // y si el usuario confirma la acción, guarda la nueva cuenta en la base de datos.
        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView de clientes.
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;// Si no hay selección, detiene la ejecución.
            }
            // Obtiene el ID del cliente seleccionado desde la celda "ClienteId".
            var clienteId = (int)dgvClientes.SelectedRows[0].Cells["ClienteId"].Value;
        
            // Crea e instancia el formulario para agregar cuentas, pasando el ID del cliente como parámetro.
            var formAgregarCuentas = new AgregarCuentasForm(clienteId);
        
            // Muestra el formulario como un cuadro de diálogo modal.
            if (formAgregarCuentas.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Si el usuario confirmó (OK), agrega la nueva cuenta al contexto de base de datos.
                    _db.Cuentas.Add(formAgregarCuentas.NuevaCuenta);
        
                    // Guarda los cambios en la base de datos.
                    _db.SaveChanges();
        
                    // Recarga los datos visualizados para reflejar los cambios.
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error si ocurre una excepción durante el guardado.
                    MessageBox.Show($"Error inesperado al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Realiza una transferencia entre dos cuentas seleccionadas
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
                    if (cuentaOrigen == null || cuentaDestino == null)
                    {
                        throw new Exception("Una o ambas cuentas no existen.");
                    }
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
                    MessageBox.Show($"Error inesperado al momento de realizar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Abre el formulario TransferenciaForms, para realizar una transferencia entre dos cuentas seleccionadas
        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Desactiva una cuenta seleccionada
        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al desactivar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Muestra el formulario de Transferencias, ya realizadas
        private void btnVerTransferencias_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new VerTransferenciasForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        // Busca un cliente por su nombre, id o identificacion
        private void btnBuscaClienteGroupbox_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonNombreCliente.Checked)
                {
                    if (string.IsNullOrEmpty(txtBuscar.Text))
                    {
                        MessageBox.Show("Ingrese un nombre para buscar");
                        return;
                    }
                    // busqueda con patrones con like
                    var like = txtBuscar.Text;
                    var clientes = _db.Clientes.
                        Where
                        (c => EF.Functions.Like(c.Nombre, $"%{like}%")).
                        ToList();
                    dgvClientes.DataSource = clientes;
                    txtBuscar.Clear();
                    groupBoxBuscarClientes.Visible = false;
                    btnBuscarClientes.Visible = true;
                    // Si no se encuentra ningun cliente, se muestra un mensaje y se cargan los datos de los datagridviews nuevamente
                    if (clientes.Count == 0)
                    {
                        MessageBox.Show($"No se encontraron ningun cliente.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBuscar.Clear();
                        CargarDatos();
                    }
                }
                else if (radioButtonIdentificacionCliente.Checked)
                {
                    if (string.IsNullOrEmpty(txtBuscar.Text))
                    {
                        MessageBox.Show("Ingrese una identificación para buscar");
                        return;
                    }
                    // busqueda con patrones con like
                    var like = txtBuscar.Text;
                    var clientes = _db.Clientes.
                        Where
                        (c => EF.Functions.Like(c.Identificacion, $"%{like}%")).
                        ToList();
                    dgvClientes.DataSource = clientes;
                    txtBuscar.Clear();
                    groupBoxBuscarClientes.Visible = false;
                    btnBuscarClientes.Visible = true;
                    // Si no se encuentra ningun cliente, se muestra un mensaje y se cargan los datos de los datagridviews nuevamente
                    if (clientes.Count == 0)
                    {
                        MessageBox.Show($"No se encontraron ningun cliente.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBuscar.Clear();
                        CargarDatos();
                    }
                }
                else if (radioButtonClienteId.Checked)
                {
                    if (!int.TryParse(txtBuscar.Text, out int id))
                    {
                        MessageBox.Show("Ingrese un ID válido (número entero).");
                        return;
                    }
                    // busqueda con patrones con like
                    var like = txtBuscar.Text;
                    var clientes = _db.Clientes
                            .Where(c => c.ClienteId == id)
                            .ToList();
                    dgvClientes.DataSource = clientes;
                    txtBuscar.Clear();
                    groupBoxBuscarClientes.Visible = false;
                    btnBuscarClientes.Visible = true;
                    // Si no se encuentra ningun cliente, se muestra un mensaje y se cargan los datos de los datagridviews nuevamente
                    if (clientes.Count == 0)
                    {
                        MessageBox.Show($"No se encontraron ningun cliente.", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBuscar.Clear();
                        CargarDatos();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al buscar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Clear();

            }
        }
        // Carga nuevamente los datos en los datagridviews, util cuando haces un busqueda y necesitas ver todos los clientesn nuevamente
        private void PixtureBoxRefrecardgvs_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al refrescar los datagridviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Abre un groupbox para buscar clientes por su nombre, id o identificacion
        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxBuscarClientes.Visible = true;
                btnBuscarClientes.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al abrir el groupbox de busqueda de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // metodo que permite buscar cuentas posus atributos, similar al anterior metodo de busqueda de clientes
        private void btnBuscarEnCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonNumeroDeCuenta.Checked)
                {
                    if (string.IsNullOrEmpty(txtBuscarEnCuentas.Text))
                    {
                        MessageBox.Show("Ingrese un número de cuenta para buscar.");
                        return;
                    }

                    var like = txtBuscarEnCuentas.Text;
                    var cuentas = _db.Cuentas
                        .Include(c => c.Cliente)
                        .Where(c => EF.Functions.Like(c.NumeroCuenta, $"%{like}%"))
                        .Select(c => new {
                            c.CuentaId,
                            c.NumeroCuenta,
                            c.Saldo,
                            c.Activo,
                            c.ClienteId,
                            NombreCliente = c.Cliente.Nombre
                        })
                        .ToList();
                    dgvCuentas.DataSource = cuentas;
                }
                else if (radioButtonCuentaId.Checked)
                {
                    if (!int.TryParse(txtBuscarEnCuentas.Text, out int cuentaId))
                    {
                        MessageBox.Show("Ingrese un ID de cuenta válido (número entero).");
                        return;
                    }

                    var cuentas = _db.Cuentas
                        .Include(c => c.Cliente)
                        .Where(c => c.CuentaId == cuentaId)
                        .Select(c => new {
                            c.CuentaId,
                            c.NumeroCuenta,
                            c.Saldo,
                            c.Activo,
                            c.ClienteId,
                            NombreCliente = c.Cliente.Nombre
                        })
                        .ToList();

                    dgvCuentas.DataSource = cuentas;
                }
                else if (radioButtonClienteId2.Checked)
                {
                    if (!int.TryParse(txtBuscarEnCuentas.Text, out int clienteId))
                    {
                        MessageBox.Show("Ingrese un ID de cliente válido (número entero).");
                        return;
                    }

                    var cuentas = _db.Cuentas
                        .Include(c => c.Cliente)
                        .Where(c => c.ClienteId == clienteId)
                        .Select(c => new {
                            c.CuentaId,
                            c.NumeroCuenta,
                            c.Saldo,
                            c.Activo,
                            c.ClienteId,
                            NombreCliente = c.Cliente.Nombre
                        })
                        .ToList();

                    dgvCuentas.DataSource = cuentas;
                }
                else if (radioButtonNombre2.Checked)
                {
                    if (string.IsNullOrEmpty(txtBuscarEnCuentas.Text))
                    {
                        MessageBox.Show("Ingrese un nombre para buscar.");
                        return;
                    }

                    var like = txtBuscarEnCuentas.Text;
                    var cuentas = _db.Cuentas
                        .Include(c => c.Cliente)
                        .Where(c => EF.Functions.Like(c.Cliente.Nombre, $"%{like}%"))
                        .Select(c => new {
                            c.CuentaId,
                            c.NumeroCuenta,
                            c.Saldo,
                            c.Activo,
                            c.ClienteId,
                            NombreCliente = c.Cliente.Nombre
                        })
                        .ToList();
                    dgvCuentas.DataSource = cuentas;
                }
                else if (radioButtonSaldo.Checked)
                {
                    if (!decimal.TryParse(txtBuscarEnCuentas.Text, out decimal saldo))
                    {
                        MessageBox.Show("Ingrese un valor de saldo válido (número decimal).");
                        return;
                    }
                    var cuentas = _db.Cuentas
                        .Include(c => c.Cliente)
                        .Where(c => c.Saldo >= saldo)
                        .Select(c => new {
                            c.CuentaId,
                            c.NumeroCuenta,
                            c.Saldo,
                            c.Activo,
                            c.ClienteId,
                            NombreCliente = c.Cliente.Nombre
                        })
                        .ToList();
                    dgvCuentas.DataSource = cuentas;
                }

                // Limpiar campos y mensajes si no hay resultados
                if (dgvCuentas.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron cuentas.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos(); // recarga todas las cuentas si ninguna fue encontrada
                }

                txtBuscarEnCuentas.Clear();
                groupBoxBuscarCuenta.Visible = false;
                btnBuscarCuenta.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al buscar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscarEnCuentas.Clear();

            }
        }
        // muestra el gorupbox para buscar cuentas 
        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxBuscarCuenta.Visible = true;
                btnBuscarCuenta.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al abrir el groupbox de busqueda de cuentas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // metodo que permite que un pictureBox cierra el groupbox de busqueda de cuentas y otro el de clientes
        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxBuscarCuenta.Visible = false;
                btnBuscarCuenta.Visible = true;
                txtBuscarEnCuentas.Clear();
                groupBoxBuscarClientes.Visible = false;
                btnBuscarClientes.Visible = true;
                txtBuscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cerrar el groupbox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
