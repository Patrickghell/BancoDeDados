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
    public partial class AlunoCadastrar : Form
    {
        public AlunoCadastrar()
        {
            InitializeComponent();
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "SELECT turma.nomet FROM turma WHERE 1";

            MySqlDataReader resultado = consulta.ExecuteReader();

            while (resultado.Read())
            {
                comboBox1.Items.Add(resultado["nomet"].ToString());
            }


            conectar.Close();
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.textBox7.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            textBox3.TextChanged += TextBox3_TextChanged;
            textBox6.TextChanged += TextBox6_TextChanged; 
        }


        private void button1_Click(object sender, EventArgs e)
        {


            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = ("SERVER=127.0.0.1; DATABASE=dsteste; UID = root; PASSWORD = ; ");
            conexao.Open();

            string inserir = "INSERT INTO aluno(nome,rg,ra,endereco,cidade,email,telefone, turma) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.SelectedItem + "')";
            MySqlCommand comandos = new MySqlCommand(inserir, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
            conexao.Open();
            inserir = "INSERT INTO aluno_turma (codaluno, codturma) SELECT aluno.codaluno, turma.codturma FROM aluno JOIN turma ON turma.nomet = '" + comboBox1.Text + "' WHERE aluno.nome = '" + textBox1.Text + "'";
            comandos = new MySqlCommand(inserir, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.SelectedItem = "";

            MessageBox.Show("Aluno Cadastrado com Sucesso");
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string text = textBox.Text;
                textBox.Text = FormatRG(text);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string text = textBox.Text;
                textBox.Text = FormatPhoneNumber(text);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }



        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string text = textBox.Text;
                textBox.Text = FormatRA(text);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string text = textBox.Text;
              
                if (!IsValidEmail(text))
                {
           
                    textBox.BackColor = Color.LightPink; 
                }
                else
                {
                    textBox.BackColor = Color.White; 
                }
            }
        }



        private string FormatRG(string text)
        {
            text = new string(text.Where(char.IsDigit).ToArray());

            if (text.Length > 8)
                text = string.Format("{0}.{1}.{2}-{3}", text.Substring(0, 2), text.Substring(2, 3), text.Substring(5, 3), text.Substring(8, 1));
            else if (text.Length > 5)
                text = string.Format("{0}.{1}.{2}", text.Substring(0, 2), text.Substring(2, 3), text.Substring(5));
            else if (text.Length > 2)
                text = string.Format("{0}.{1}", text.Substring(0, 2), text.Substring(2));
            else
                text = text;

            return text;
        }

        private string FormatPhoneNumber(string text)
        {
            text = new string(text.Where(char.IsDigit).ToArray());

            if (text.Length > 10)
                text = string.Format("({0}) {1}-{2}", text.Substring(0, 2), text.Substring(2, 5), text.Substring(7, Math.Min(text.Length - 7, 4)));
            else if (text.Length > 6)
                text = string.Format("({0}) {1}-{2}", text.Substring(0, 2), text.Substring(2, 4), text.Substring(6));
            else if (text.Length > 2)
                text = string.Format("({0}) {1}", text.Substring(0, 2), text.Substring(2));
            else
                text = string.Format("({0}", text);

            return text;
        }


        private string FormatRA(string text)
        {
            text = new string(text.Where(char.IsDigit).ToArray());

            
            if (text.Length > 4)
                text = string.Format("{0}-{1}", text.Substring(0, 4), text.Substring(4, Math.Min(text.Length - 4, 4)));
            else
                text = text;

            return text;
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    





private void textBox8_TextChanged(object sender, EventArgs e)
        {

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
