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
    public partial class VerTransferenciasForm : Form
    {
        private BancoSimple2M5Context db = new BancoSimple2M5Context();
        public VerTransferenciasForm()
        {
            InitializeComponent();
            CargarTransferencias();
        }
        // carga los datos de las transferencias en el datagridview
        private void CargarTransferencias()
        {
            try
            {
                dgvTransferencias.DataSource = db.Transacciones.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cargar las transferencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // cierra el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult = DialogResult.OK; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cerrar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
