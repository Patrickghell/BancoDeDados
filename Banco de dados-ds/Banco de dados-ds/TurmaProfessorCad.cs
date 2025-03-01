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
    public partial class TurmaProfessorCad : Form
    {
        public TurmaProfessorCad()
        {
            InitializeComponent();
        }

        private void TurmaProfessorCad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = ("SERVER=127.0.0.1; DATABASE=dsteste; UID = root; PASSWORD = ; ");
            conexao.Open();

            string inserir = "INSERT INTO professor_turma(codprof,codturma) values('" + textBox2.Text +"','"+textBox3.Text+ "')";
            MySqlCommand comandos = new MySqlCommand(inserir, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Turma Cadastrada com Sucesso");
        }
    }
}
