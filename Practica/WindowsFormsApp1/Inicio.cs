using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TipoCombustible tipo = new TipoCombustible();
            tipo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modelos modelos = new Modelos();
            modelos.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AlquilerAuto alquiler = new AlquilerAuto();
            alquiler.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
