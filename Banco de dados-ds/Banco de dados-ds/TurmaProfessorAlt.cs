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
    public partial class TurmaProfessorAlt : Form
    {
        public string id = "";
        public TurmaProfessorAlt(string i)
        {
            InitializeComponent();
        
            id = i;
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "SELECT * FROM professor_turma WHERE codigo = " + id;
            MySqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {

                    
                    textBox2.Text = resultado["codprof"].ToString();
                    textBox3.Text = resultado["codturma"].ToString();

                }


            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado");
            }
        }

        private void TurmaProfessorAlt_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            string inserir = "UPDATE professor_turma SET codprof ='" + textBox2.Text + "', codturma ='" + textBox3.Text + "' WHERE codigo = " + id;
            MySqlCommand comandos = new MySqlCommand(inserir, conectar);
            comandos.ExecuteNonQuery();
            MessageBox.Show("Turma Alterada com sucesso");
            this.Close();
        }
    }
}
