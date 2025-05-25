using BancoSimple2M5.Data;
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
    // Definición del formulario que permite ver todas las transferencias registradas
    public partial class VerTransferenciasForm : Form
    {
        // Contexto de base de datos para acceder a las entidades del sistema
        private BancoSimple2M5Context db = new BancoSimple2M5Context();

        // Constructor del formulario
        public VerTransferenciasForm()
        {
            InitializeComponent();      // Inicializa todos los controles visuales del formulario
            CargarTransferencias();     // Carga los datos de las transferencias al iniciar el formulario
        }

        // Método encargado de obtener las transferencias desde la base de datos
        // y mostrarlas en el DataGridView del formulario
        private void CargarTransferencias()
        {
            try
            {
                // Asigna al DataGridView la lista completa de transacciones
                dgvTransferencias.DataSource = db.Transacciones.ToList();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepción al acceder a los datos
                MessageBox.Show(
                    $"Error inesperado al cargar las transferencias: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Evento que se ejecuta cuando el usuario hace clic en el botón "Cerrar"
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establece que el formulario se cerró correctamente
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                // En caso de error al cerrar, se notifica al usuario
                MessageBox.Show(
                    $"Error inesperado al cerrar el formulario: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }

}

