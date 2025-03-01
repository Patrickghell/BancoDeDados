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
    public partial class turmaAlterar : Form
    {
        public string id = "";
        public turmaAlterar(string i)
        {
            InitializeComponent();
            id = i;
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "SELECT * FROM turma WHERE codturma = " + id;
            MySqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {

                    textBox1.Text = resultado["codturma"].ToString();
                    textBox2.Text = resultado["nomet"].ToString();

                }


            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand(); 
            string inserir = "UPDATE aluno SET nome ='" + textBox1.Text + "', codturma ='"  + "' WHERE codigo = " + id;
            MySqlCommand comandos = new MySqlCommand(inserir, conectar);
            comandos.ExecuteNonQuery();
            MessageBox.Show("Aluno Alterado com sucesso");
            this.Close();
        }
    }
}
