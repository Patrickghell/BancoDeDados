﻿using System;
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
    public partial class FuncionarioExcluir : Form
    {
        public string id = "";
        public FuncionarioExcluir(string i )
        {
            InitializeComponent();
            id = i;

            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "SELECT * FROM funcionario WHERE codfunc = " + id;
            MySqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {

                    textBox1.Text = resultado["nome"].ToString();
                    textBox2.Text = resultado["rg"].ToString();
                    textBox3.Text = resultado["cpf"].ToString();
                    textBox4.Text = resultado["endereco"].ToString();
                    textBox5.Text = resultado["cidade"].ToString();
                    textBox6.Text = resultado["email"].ToString();
                    textBox7.Text = resultado["telefone"].ToString();
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
            string inserir = "DELETE FROM funcionario  WHERE codfunc = '" + id + "';";
            MySqlCommand comandos = new MySqlCommand(inserir, conectar);
            comandos.ExecuteNonQuery();
            MessageBox.Show("Funcionario excluido com sucesso");
            this.Close();
        }
    }
}
