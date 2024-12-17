MyFinance Web (ASP.NET Core 8.0)
O MyFinance Web é uma aplicação desenvolvida em ASP.NET Core 8.0, projetada para facilitar o gerenciamento de finanças pessoais. O sistema visa oferecer uma interface simples e eficiente para acompanhar receitas, despesas e saldo de contas, ajudando os usuários a manterem suas finanças em ordem.

Pontos Importantes
Banco de Dados: A aplicação foi configurada para utilizar o SQL Server como banco de dados.

Configuração de Conexão: O arquivo responsável pela configuração de conexão com o banco de dados é o MyFinanceDbContext.cs, localizado em myfinance-web-dotnet/Infrastructure/. Você precisará ajustar esse arquivo conforme as configurações do seu ambiente local para garantir que a conexão com o banco funcione corretamente.

Script SQL: O script para criação da base de dados, incluindo alguns dados iniciais, está disponível no arquivo myfinance-web-dotnet/Docs/myfinance.sql. Esse script facilita a instalação da estrutura inicial do banco para começar a utilizar o sistema.
