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
    public partial class Menu : Form
    {
        private Principal principal;
        public Menu()
        {
            InitializeComponent();

            principal = new Principal();
        }

        private void cuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            //string nombre = textBoxNombre.Text;
            //string apellido = textBoxApellido.Text;
            //string dni = textBoxDni.Text;

            //principal.AgregarCliente(nombre, apellido, dni);

            //textBoxIDCliente.Clear();
            //textBoxNombre.Clear();
            //textBoxApellido.Clear();
            //textBoxDni.Clear();
            //MessageBox.Show("Cliente agregado con éxito.");

            //using (var dbContext = new ApplicationDbContext())
            //{
            //    listBoxClientes.DataSource = dbContext.Clientes.ToList();
            //    listBoxClientes.Refresh();
            //}
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //using (var dbContext = new ApplicationDbContext())
            //{
            //    listBoxClientes.DataSource = dbContext.Clientes.ToList();
            //    listBoxClientes.DisplayMember = "InformacionCliente"; //Como lo hicimos en clase, propiedad que tiene get
            //}
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
           
            
        }

        private void crearUnaCuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaBancaria MenuCuentaBancaria = new CuentaBancaria();
            MenuCuentaBancaria.Show();
            this.Hide();
        }
    }
}


