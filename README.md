# MyFinance Web (ASP.NET Core 8.0)

## Sobre:
* MyFinance foi projetado para o gerenciamento de finanças pessoais e controle de gasto, controle de receita e despesas. 
É poossivel cadastrar, editar e excluir as opções financeiras para gerenciar as transações. 

## Arquitetura:

- MVC - Model View Controller

## Tecnologias utilizadas:
- Visual Studio Code (VSC)
- .NET v8.0
- SQL Server.

## Inicialização localmente
Para configurar o ambiente local, siga os passos abaixo:

- 1 - Clonar o repositório

- 2 - Instalar os sistemas necessário 
    - SQL Server
    - Visual Studio Code (VSC)
    - .NET v8.0
  
- 3 - Configurar o banco de dados no SQL Server

- 4 - Utilizar o script fornecido na pasta Docs.

- 5 - Verificar classe de configuração do banco de dados - arquivo MyFinanceDbContext:
    - @"Server=SERVIDOR;Database=BANCO_DE_DADO;Trusted_Connection=true;TrustServerCertificate=True";
