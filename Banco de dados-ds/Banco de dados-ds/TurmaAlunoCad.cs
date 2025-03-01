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
    public partial class TurmaAlunoCad : Form
    {
        public TurmaAlunoCad()
        {
            InitializeComponent();
        }

        private void TurmaAlunoCad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = ("SERVER=127.0.0.1; DATABASE=dsteste; UID = root; PASSWORD = ; ");
            conexao.Open();

            string inserir = "INSERT INTO aluno_turma(codigo,codaluno,codturma) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            MySqlCommand comandos = new MySqlCommand(inserir, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


            MessageBox.Show("Turma do Aluno Cadastrada com Sucesso");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
