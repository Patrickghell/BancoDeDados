using System;
using System.Windows.Forms;

namespace Banco_de_dados_ds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           

        private void button1_Click_1(object sender, EventArgs e)
        {
            AlunoVisualizar verAluno = new AlunoVisualizar();
            verAluno.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfessorVisualizar verProf = new ProfessorVisualizar();
            verProf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TurmaAlunoVis verFunc = new TurmaAlunoVis();
            verFunc.Show();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            turmaVisualizar verFunc = new turmaVisualizar();
            verFunc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FuncionarioVisualizar verFunc = new FuncionarioVisualizar();
            verFunc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TurmaProfessorVis verFunc = new TurmaProfessorVis();
            verFunc.Show();
        }
    }
    }

