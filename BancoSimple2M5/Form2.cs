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
    public partial class Form2 : Form
    {
        private BancoSimple2M5Context db = new BancoSimple2M5Context();
        public Form2()
        {
            InitializeComponent();
            CargarTransferencias();
        }

        private void CargarTransferencias()
        {
            dgvTransferencias.DataSource = db.Transacciones.ToList();
        }

        private void dgvTransferencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
