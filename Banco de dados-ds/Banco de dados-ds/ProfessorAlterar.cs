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
    public partial class ProfessorAlterar : Form
    {
        public string id = "";
        public ProfessorAlterar(string i )
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




            consulta.Connection = conectar;
            consulta.CommandText = "SELECT * FROM professor WHERE codprof = "+id;
             resultado = consulta.ExecuteReader();
            if (resultado.Read())
                {

                    textBox1.Text = resultado["nome"].ToString();
                    textBox2.Text = resultado["rg"].ToString();
                    textBox3.Text = resultado["cpf"].ToString();
                    textBox4.Text = resultado["endereco"].ToString();
                    textBox5.Text = resultado["cidade"].ToString();
                    textBox6.Text = resultado["email"].ToString();
                    textBox7.Text = resultado["telefone"].ToString();
                    comboBox1.SelectedItem = resultado["turma"].ToString();
                


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
            string inserir = "UPDATE professor SET nome ='"+textBox1.Text + "', rg ='" + textBox2.Text + "', cpf ='" + textBox3.Text +"', endereco ='" + textBox4.Text + "', cidade ='" + textBox5.Text + "', email ='" + textBox6.Text + "', telefone ='" + textBox7.Text +"',turma ='"+ comboBox1.SelectedItem + "' WHERE codprof = "+id;
            MySqlCommand comandos = new MySqlCommand(inserir, conectar);
            comandos.ExecuteNonQuery();
            MessageBox.Show("Professor Cadastrado com sucesso");
            this.Close();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
