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
    public partial class CuentaBancaria : Form
    {


        private Principal principal;
        public CuentaBancaria()
        {
            InitializeComponent();

            principal = new Principal();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
