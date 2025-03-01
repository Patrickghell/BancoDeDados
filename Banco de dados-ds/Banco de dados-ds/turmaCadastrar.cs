using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banco_de_dados_ds
{
    public partial class turmaCadastrar : Form
    {
        public turmaCadastrar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = ("SERVER=127.0.0.1; DATABASE=dsteste; UID = root; PASSWORD = ; ");
            conexao.Open();

            string inserir = "INSERT INTO turma(nomet) values('" + textBox1.Text +  "')";
            MySqlCommand comandos = new MySqlCommand(inserir, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
            textBox1.Text = "";
            
            MessageBox.Show("Turma Cadastrada com Sucesso");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
