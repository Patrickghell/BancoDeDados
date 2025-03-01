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
using Microsoft.Office.Interop.Excel;

namespace Banco_de_dados_ds
{
    public partial class TurmaProfessorVis : Form
    {
        public TurmaProfessorVis()
        {
            InitializeComponent();
           
            MySqlConnection conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "DESCRIBE aluno_turma";


            MySqlDataReader resultado = consulta.ExecuteReader();

            while (resultado.Read())
            {

                dataGridView1.ColumnCount += 1;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = resultado["Field"].ToString();
                comboBox1.Items.Add(resultado["Field"].ToString());
            }



            resultado.Close();

            dataGridView1.Rows.Clear();


            consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "SELECT professor.nome nome_professor, professor_turma.codigo id, turma.nomet nome_turma FROM professor_turma INNER JOIN professor ON professor.codprof = professor.codprof  INNER JOIN turma ON turma.codturma = professor_turma.codigo";
            resultado = consulta.ExecuteReader();
            while (resultado.Read())
            {
                dataGridView1.Rows.Add(resultado["id"].ToString(),
                                   resultado["nome_professor"].ToString(),
                                resultado["nome_turma"].ToString());
            }



            conectar.Close();

            conectar = new MySqlConnection("SERVER=localhost; DATABASE=dsteste; UID=root; PASSWORD=");
            conectar.Open();
            consulta = new MySqlCommand();
            consulta.Connection = conectar;
            consulta.CommandText = "SELECT professor.nome nome_professor, professor_turma.codigo id, turma.nomet nome_turma FROM professor_turma INNER JOIN professor ON professor.codprof = professor.codprof  INNER JOIN turma ON turma.codturma = professor_turma.codigo";
            resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    dataGridView1.Rows.Add(resultado["id"].ToString(),
                                      resultado["nome_professor"].ToString(),
                                   resultado["nome_turma"].ToString());


                }
            }

            else
            {
                MessageBox.Show("nenhum registro foi encontrado");
            }
            conectar.Close();

        }

        private void TurmaProfessorVis_Load(object sender, EventArgs e)
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
            consulta.CommandText = "SELECT * FROM aaa2 WHERE " + campo + " like '%" + nomecampo + "%'";

            dataGridView1.Rows.Clear();
            MySqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    dataGridView1.Rows.Add(resultado["id"].ToString(),
                                          resultado["nome_professor"].ToString(),
                                       resultado["nome_turma"].ToString());

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
         
            TurmaProfessorCad turalu = new TurmaProfessorCad();
            turalu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string i = textBox2.Text;
            TurmaProfessorAlt excAluno = new TurmaProfessorAlt(i);
            excAluno.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string i = textBox2.Text;
            TurmaProfessorExc excAluno = new TurmaProfessorExc(i);
            excAluno.Show();
        }
    }
}
