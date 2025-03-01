📌 Gestão de Pessoas - C# e Banco de Dados
Este projeto é uma aplicação em C# com acesso a banco de dados que permite o cadastro, edição, exclusão e filtragem de professores, alunos, turmas e funcionários.

🚀 Funcionalidades
✅ Cadastro de professores, alunos, turmas e funcionários.
✅ Edição e atualização de cadastros existentes.
✅ Exclusão de registros.
✅ Filtragem e pesquisa para localizar cadastros rapidamente.
✅ Exportação para planilha no Excel


📂 Tecnologias Utilizadas
Linguagem: C#
Banco de Dados: MySQL (via MySql.Data.MySqlClient)
Exportação para Excel: Microsoft Office Interop (Excel)
Frameworks/Libraries:
MySql.Data.MySqlClient para conexão e manipulação do banco de dados MySQL via ADO.NET.
Microsoft.Office.Interop.Excel para exportação de dados para o Excel e manipulação de planilhas diretamente no Excel.

📄 Exemplo de Uso
Aqui está um exemplo simples de como exportar dados para uma planilha do Excel usando o Microsoft.Office.Interop.Excel:

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


📸 Demonstração


Tela Incial

![image](https://github.com/user-attachments/assets/4b6fd99e-829d-4e52-a885-d9c8b74745a1)





Tela da tabela Alunos

![image](https://github.com/user-attachments/assets/bc7acd27-6e12-4061-b9a1-63452930cc40)
 



