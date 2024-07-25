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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Usuario datauser = new Usuario();
        Usuario_DAO metoduser = new Usuario_DAO();

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            datauser.User1 = textBox1.Text;
            datauser.Contra1 = textBox2.Text;
            datauser = metoduser.Ingresar_Usuario(datauser);
            MessageBox.Show(datauser.MensajeUsuario1, "Login");
            inicio.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
