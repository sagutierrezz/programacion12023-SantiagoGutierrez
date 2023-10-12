using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back.Clases;
using Back.ConexionBD;

namespace Front
{
    public partial class MenuAltaCliente : Form
    {
        Principal principal = new Principal();
        public Cliente ClienteSeleccionado { get; private set; }


        public MenuAltaCliente()
        {
            InitializeComponent();


        }

        private void cuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();


            nuevoCliente.Nombre = textBoxNombre.Text;
            nuevoCliente.Apellido = textBoxApellido.Text;
            nuevoCliente.Dni = textBoxDni.Text;


            // Invoco al método AgregarCliente para agregar el cliente a la base de datos
            principal.AgregarCliente(nuevoCliente);

            // Limpia los campos de texto
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDni.Clear();
            MessageBox.Show("Cliente agregado con éxito.");

            using (var dbContext = new ApplicationDbContext())
            {
                listBoxClientes.DataSource = dbContext.Clientes.ToList();
                listBoxClientes.Refresh();
                listBoxClientes.DisplayMember = "InformacionCliente";

            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            listBoxClientes.DisplayMember = "InformacionCliente";
            listBoxClientes.DataSource = principal.DevolverListaClientes();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                // Obtener el cliente seleccionado
                ClienteSeleccionado = listBoxClientes.SelectedItem as Cliente;
            }
            else
            {
                ClienteSeleccionado = null;
            }
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            principal.EliminarCliente((Cliente)listBoxClientes.SelectedItem);
            MessageBox.Show("Cliente eliminado exitosamente");

            listBoxClientes.DisplayMember = "InformacionCliente";
            listBoxClientes.DataSource = principal.DevolverListaClientes();

        }

        private void crearUnaCuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica que haya un cliente seleccionado
            if (ClienteSeleccionado != null)
            {
                // Abre el formulario de creación de cuenta bancaria y pasa el cliente seleccionado
                AltaCuentaBancaria crearCuentaBancariaForm = new AltaCuentaBancaria(ClienteSeleccionado);
                crearCuentaBancariaForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Selecciona un cliente antes de crear una cuenta bancaria.");
            }


            AltaCuentaBancaria MenuCuentaBancaria = new AltaCuentaBancaria();
            MenuCuentaBancaria.Show();
            //this.Hide();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxClientes.DisplayMember = "InformacionCliente";
            listBoxClientes.DataSource = principal.DevolverListaClientes();
        }
    }
}


