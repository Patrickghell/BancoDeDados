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
    public partial class AlunoAlterar : Form
    {
        public string id = "";
        public AlunoAlterar(string i )
        {
            InitializeComponent();
            id = i;
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();

            consulta.Connection = conectar;
            consulta.CommandText = "SELECT * FROM turma ";
            MySqlDataReader resultado = consulta.ExecuteReader();
            while (resultado.Read())
            {
                comboBox1.Items.Add(resultado["nomet"].ToString());
            }
            conectar.Close();

            conectar.Open();




            consulta.CommandText = "SELECT * FROM aluno WHERE codaluno = " + id;
          resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {

                    textBox1.Text = resultado["nome"].ToString();
                    textBox2.Text = resultado["rg"].ToString();
                    textBox3.Text = resultado["ra"].ToString();
                    textBox4.Text = resultado["endereco"].ToString();
                    textBox5.Text = resultado["cidade"].ToString();
                    textBox6.Text = resultado["email"].ToString();
                    textBox7.Text = resultado["telefone"].ToString();
                    comboBox1.SelectedItem = resultado["turma"].ToString();
                }


            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado");
            }
            conectar.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            string inserir = "UPDATE aluno SET nome ='" + textBox1.Text + "', rg ='" + textBox2.Text + "', ra ='" + textBox3.Text + "', endereco ='" + textBox4.Text + "', cidade ='" + textBox5.Text + "', email ='" + textBox6.Text + "', telefone ='" + textBox7.Text  + "',turma ='"+comboBox1.SelectedItem + "' WHERE codaluno = " + id;
            MySqlCommand comandos = new MySqlCommand(inserir, conectar);
            comandos.ExecuteNonQuery();
            MessageBox.Show("Aluno Alterado com sucesso");
            this.Close();
        }
    }
}
