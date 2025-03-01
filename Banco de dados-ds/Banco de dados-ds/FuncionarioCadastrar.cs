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
    public partial class FuncionarioCadastrar : Form
    {
        public FuncionarioCadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = ("SERVER=127.0.0.1; DATABASE=dsteste; UID = root; PASSWORD = ; ");
            conexao.Open();

            string inserir = "INSERT INTO funcionario(nome,rg,cpf,endereco,cidade,email,telefone) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            MySqlCommand comandos = new MySqlCommand(inserir, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            MessageBox.Show("Funcionario Cadastrado com Sucesso");
        }
    }
}
