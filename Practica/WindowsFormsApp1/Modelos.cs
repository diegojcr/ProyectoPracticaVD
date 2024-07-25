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
    public partial class Modelos : Form
    {

        CD_Modelo MiModelo = new CD_Modelo();
        CN_Modelo ObjetoModelo = new CN_Modelo();

        public Modelos()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        //Metodo que hace el llamado de los datos en la tabla marcas
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ObjetoModelo.MostrarModelo();
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
                ObjetoModelo.InsertarModelos(textBox1.Text, textBox2.Text);
                MessageBox.Show("El Registro fue Almacenado Correctamente!!!", "PRACTICA T&S");
                MostrarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("El Registro no fue almacenado..." + ex + "PRACTICA T&S");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)//Verifica si la fila de datos contiene datos
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["ID_MODELO"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Inventario T&S");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ObjetoModelo.ActualizarModelos(textBox1.Text, textBox2.Text);
                MessageBox.Show("Modelo Actualizado correctamente...", "Inventarios T&S");
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar un Modelo" + ex + "Inventarios T&S");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["ID_MODELO"].Value.ToString();
                ObjetoModelo.deletearModelos(textBox1.Text);
                MessageBox.Show("Modelo Eliminado Correctamente...", "Inventarios T&S");
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
