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
        // Evento que se ejecuta cuando el usuario hace clic en el botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si el campo de número de cuenta está vacío
                if (string.IsNullOrEmpty(txtNumCuenta.Text))
                {
                    MessageBox.Show("Ingrese el número de cuenta");
                    return; // Sale del método sin continuar
                }
                else
                {
                    // Crea una nueva instancia de la clase Cuenta con los datos ingresados
                    NuevaCuenta = new Cuenta
                    {
                        NumeroCuenta = txtNumCuenta.Text, // Obtiene el número desde el TextBox
                        Saldo = numSaldo.Value,           // Obtiene el saldo desde el control numérico
                        ClienteId = _clienteId,           // Asocia la cuenta al cliente recibido en el constructor
                        Activo = true                     // La cuenta se marca como activa por defecto
                    };

                    // Indica que el formulario finalizó correctamente y cierra la ventana
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si algo falla al crear la cuenta
                MessageBox.Show($"Error inesperado al agregar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
