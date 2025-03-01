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

![image](https://github.com/user-attachments/assets/f8b4c043-8212-45c5-b85c-f99a084cdb0e)

Cadastrar Aluno

![image](https://github.com/user-attachments/assets/f80efe79-58fa-4ddd-8fbc-21e55ffbff63)


alterar

![image](https://github.com/user-attachments/assets/c35e419f-86b3-4ab7-933f-41c02c885cb5)

![image](https://github.com/user-attachments/assets/82b58429-cd07-48b1-bf23-66c56c1974d2)


Excluir Aluno

![image](https://github.com/user-attachments/assets/770be165-5df6-4af7-b63c-0deb84ef6874)


Basicamente todos os outros seguem a mesma formatação.

## 📜 Licença

Este projeto está licenciado sob a licença [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0).

[Leia a documentação completa](./LICENSE.pptx)



##  Requisitos para usar o projeto

Intalar o Visual Studio 2022
[Dowload Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)

**Bibliotecas Visual Studio**

- using MySql.Data.MySqlClient;
- using Microsoft.Office.Interop.Excel;

Instalar o XAMPP
[Dowload XAMPP](https://www.apachefriends.org/pt_br/download.html)

## Como Instalar 

**Visual Studio**

Após intalar em seu computador vai para pasta Downloads e da dois cliks no arquivo.

![image](https://github.com/user-attachments/assets/8357b40b-c5cb-4241-b82e-f879c99e6958)

após aparecer essa tela selecione tudo que tenha C#

![image](https://github.com/user-attachments/assets/9758bc53-3d05-40e9-9b97-65b9fe2f981b)

clique no botão de instalar e espere o fim da instalação.

**XAMPP**
Após intalar em seu computador vai para pasta Downloads e da dois cliks no arquivo.

![image](https://github.com/user-attachments/assets/b7f37876-1016-4c07-abed-860b002c12ad)

após essa tela clique em 'Next'.

![image](https://github.com/user-attachments/assets/5aa96c2a-3a12-4e1c-a8eb-5190ed55c974)


 clique em 'Next' Novamente.
 
![image](https://github.com/user-attachments/assets/59832983-4995-4fa3-866e-a7e08601ae4d)


 Escolha a pasta onde vai ser instalado e clique em 'Next' Novamente.
 
![image](https://github.com/user-attachments/assets/cff5a2d4-080b-49a9-87bf-b047fffe6311)




















 



