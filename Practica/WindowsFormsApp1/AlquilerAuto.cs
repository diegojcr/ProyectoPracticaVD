using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MODEL;
using CONTROLLER;

namespace WindowsFormsApp1
{
    public partial class AlquilerAuto : Form
    {

        CD_Alquiler MiAlquiler = new CD_Alquiler();
        CN_Alquiler ObjetoAlquiler = new CN_Alquiler();

        public AlquilerAuto()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        //Metodo que hace el llamado de los datos en la tabla marcas
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ObjetoAlquiler.MostrarAlquileres();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ObjetoAlquiler.InsertarAlquileres(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("El Registro fue Almacenado Correctamente!!!", "PRACTICA T&S");
                MostrarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("El Registro no fue almacenado..." + ex + "PRACTICA T&S");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ObjetoAlquiler.ActualizarAlquiler(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Tipo Actualizado correctamente...", "Inventarios T&S");
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar un Tipo" + ex + "Inventarios T&S");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)//Verifica si la fila de datos contiene datos
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["PLACA"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["MONTOPAGAR"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["DEPOSITODAÑOS"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Inventario T&S");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["PLACA"].Value.ToString();
                ObjetoAlquiler.deletearAlquiler(textBox1.Text);
                MessageBox.Show("Tipo Eliminado Correctamente...", "Inventarios T&S");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Inventarios T&S");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
