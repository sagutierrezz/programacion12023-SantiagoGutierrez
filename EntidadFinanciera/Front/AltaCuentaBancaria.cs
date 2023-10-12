using Back.Clases;
using Back.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Front
{

    public partial class AltaCuentaBancaria : Form
    {

        Principal principal = new Principal();



        public AltaCuentaBancaria()
        {
            InitializeComponent();

            comboBoxTipoCuenta.Items.Add("CajaAhorro");
            comboBoxTipoCuenta.Items.Add("CuentaCorriente");

            

        }


        public AltaCuentaBancaria(Cliente clienteSeleccionado) : this()
        {
            //Utiliza el cliente seleccionado recibido como argumento
            //para mostrar información o asignarlo a algún control en este formulario.
            if (clienteSeleccionado != null)
            {
                // Por ejemplo, puedes mostrar el nombre del cliente en un label.
                label5.Text = clienteSeleccionado.Nombre;
                label6.Text = clienteSeleccionado.Apellido;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            




            //CuentaBancaria nuevaCuenta = new CuentaBancaria();



                //nuevaCuenta.NumeroCuenta = int.Parse(textBoxNumeroCuenta.Text);
                //nuevaCuenta.Saldo = decimal.Parse(textBoxSaldoCuenta.Text);



                //string tipoCuentaSeleccionada = comboBoxTipoCuenta.SelectedItem.ToString();

                //// Intenta analizar la cadena y convertirla en un valor de la enumeración TipoCuenta
                //if (Enum.TryParse(tipoCuentaSeleccionada, out CuentaBancaria.TipoCuenta tipoCuenta))
                //{
                //    nuevaCuenta.TipoCuentaBancaria = tipoCuenta;
                //}
                //else
                //{
                //    MessageBox.Show("Tipo de cuenta no válido.");
                //    return;
                //}

                //principal.CrearCuentaBancaria(nuevaCuenta);

                //textBoxNumeroCuenta.Clear();
                //textBoxSaldoCuenta.Clear();
                //comboBoxTipoCuenta.SelectedIndex = -1;

                //using (var dbContext = new ApplicationDbContext())
                //{
                //    listBoxCuentasBancarias.DataSource = dbContext.CuentasBancarias.ToList();
                //    listBoxCuentasBancarias.Refresh();
                //    listBoxCuentasBancarias.DisplayMember = "InformacionCuentaBancaria";

                //}

        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuAltaCliente menu1 = new MenuAltaCliente();
            menu1.Show();
            this.Hide();
        }

        private void CuentaBancaria_Load(object sender, EventArgs e)
        {
            listBoxCuentasBancarias.DisplayMember = "InformacionCuentaBancaria";
            listBoxCuentasBancarias.DataSource = principal.DevolverListaCuentaBancaria();
        }

        private void comboBoxTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminarCuenta_Click(object sender, EventArgs e)
        {
            principal.EliminarCuentaBancaria((CuentaBancaria)listBoxCuentasBancarias.SelectedItem);
            MessageBox.Show("Cuenta bancaria eliminada correctamente");
            listBoxCuentasBancarias.DataSource = null;
            listBoxCuentasBancarias.Refresh();
        }
    }
}


