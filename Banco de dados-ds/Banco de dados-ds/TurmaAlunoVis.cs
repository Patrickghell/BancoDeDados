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
    public partial class TurmaAlunoVis : Form
    {
        public TurmaAlunoVis()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = false;
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "Desc aluno_turma";
            dataGridView1.Rows.Clear();
            MySqlDataReader resultado = consulta.ExecuteReader();

            while (resultado.Read())
            {

                dataGridView1.ColumnCount += 1;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = resultado["Field"].ToString();
                comboBox1.Items.Add(resultado["Field"].ToString());
            }

            resultado.Close();


            consulta.CommandText = "Desc aluno";
            resultado = consulta.ExecuteReader();

            while (resultado.Read())
            {

                dataGridView1.ColumnCount += 1;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = resultado["Field"].ToString();
                comboBox1.Items.Add(resultado["Field"].ToString());
            }

            resultado.Close();
            consulta.CommandText = "Desc turma";
            
            resultado = consulta.ExecuteReader();

            while (resultado.Read())
            {

                dataGridView1.ColumnCount += 1;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = resultado["Field"].ToString();
                comboBox1.Items.Add(resultado["Field"].ToString());
            }


            resultado.Close();

            consulta.CommandText = "SELECT * FROM aluno_turma INNER JOIN aluno ON aluno_turma.codaluno = aluno.codaluno  INNER JOIN  turma ON aluno_turma.codturma = turma.codturma; ";
            resultado = consulta.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    object[] rowValues = new object[dataGridView1.Columns.Count];
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {

                        if (resultado.GetOrdinal(dataGridView1.Columns[i].Name) != -1)
                        {
                            rowValues[i] = resultado.GetValue(resultado.GetOrdinal(dataGridView1.Columns[i].Name));
                        }
                        else
                        {
                            rowValues[i] = DBNull.Value;
                        }
                    }
                    dataGridView1.Rows.Add(rowValues);
                }
                resultado.Close();
            }
            else
            {
                MessageBox.Show("Nenhum registro foi encontrado!");
            }
            conectar.Close();
            dataGridView1.ReadOnly = true;
        }

        private void TurmaAlunoVis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string campo = Convert.ToString(comboBox1.Text);

            string nomecampo = Convert.ToString(textBox1.Text);


            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "SELECT * FROM aaa WHERE " + campo + " like '%" + nomecampo + "%'";

            dataGridView1.Rows.Clear();
            MySqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    dataGridView1.Rows.Add(resultado["nome_turma"].ToString(),
                       resultado["nome_aluno"].ToString());

                }
            }

            else
            {
                MessageBox.Show("nenhum registro foi encontrado");
            }
            conectar.Close();
        }
        Microsoft.Office.Interop.Excel.Application XcellApp = new Microsoft.Office.Interop.Excel.Application();

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                XcellApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    XcellApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        XcellApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                XcellApp.Columns.AutoFit();
                XcellApp.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TurmaAlunoCad profcad = new TurmaAlunoCad();
            profcad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string i = textBox2.Text;
            TurmaAlunoExc turalu = new TurmaAlunoExc(i);
            turalu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string i = textBox2.Text;
            TurmaAlunoAlt turalu = new TurmaAlunoAlt(i);
            turalu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
