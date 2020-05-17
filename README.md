## CRUD simples configurado com PostgreSQL

Uma API que faz um CRUD simples em uma tabela de usuário

### Pré requisitos

- Ter [SQL Server](https://www.microsoft.com/pt-br/download/details.aspx?id=55994) instalado
- Ter [dotnet core 3](https://dotnet.microsoft.com/download/dotnet-core/3.1) instalado
- Ter o SQL Server configurado para aceitar conexões http, [este tutorial explica como](https://www.youtube.com/watch?v=5UkHYNwUtCo)

### Executando

1. Altere a string de conexão para o banco de dados nos arquivos **appsettings.json** e **appsettings.Development.json** em **SQLServerConnection** colocando as credencias=is do seu banco de dados
2. Instale a ferramenta ef do dotnet para executar as migrações no banco de dados com o comando `dotnet tool install --global dotnet-ef --version 3.0.0`
3. Para executar as migrations, utilize o comando `dotnet ef database update` no terminal
4. Execute `dotnet run` para rodar a API
