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
    public partial class Clientes : Form
    {

        CD_Clientes MiCliente = new CD_Clientes();
        CN_Clientes ObjetoCliente = new CN_Clientes();

        public Clientes()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.button2, "Nuevo");
            toolTip1.SetToolTip(this.button3, "Editar");
            toolTip1.SetToolTip(this.button4, "Eliminar");
            toolTip1.SetToolTip(this.button6, "Guardar");
            groupBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                ObjetoCliente.InsertarClientes(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
                ObjetoCliente.deletearCliente(textBox1.Text);
                MessageBox.Show("Cliente Eliminado Correctamente...", "Inventarios T&S");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Inventarios T&S");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)//Verifica si la fila de datos contiene datos
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["NIT"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["DIRECCION"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Inventario T&S");
            }
        }

        //Metodo que hace el llamado de los datos en la tabla marcas
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ObjetoCliente.MostrarClientes();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ObjetoCliente.ActualizarCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("Cliente Actualizado correctamente...", "Inventarios T&S");
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar un cliente" + ex + "Inventarios T&S");
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
