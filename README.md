TarefasApp

📌 Sobre o Projeto

O TarefasApp é uma aplicação web desenvolvida como prova técnica para a vaga de Analista Junior na Accenture. 
O objetivo é fornecer uma plataforma para gerenciamento de tarefas, permitindo a criação, edição e exclusão de tarefas de forma intuitiva.

🛠 Tecnologias Utilizadas

O projeto foi construído com as seguintes tecnologias:

Blazor - Framework para desenvolvimento de aplicações web interativas com C# e .NET.

ASP.NET Core - Framework para desenvolvimento web moderno e escalável.

Entity Framework Core - ORM para acesso ao banco de dados.

SQL Server - Banco de dados relacional utilizado na aplicação.

Docker - Utilizado para facilitar a execução do projeto em ambientes isolados.

FluentValidation - Biblioteca para validação de dados.


⚙️ Configuração e Execução do projeto

Pré-requisitos

Antes de iniciar, certifique-se de ter os seguintes requisitos instalados:

.NET 8 SDK

Docker e Docker Compose

SQL Server ou utilize a versão em container via Docker

🚀 Executando o Projeto

Clone o repositório:
Primeiro, faça o download no GitHub do código-fonte do projeto em seu computador.

Acesse o terminal ou prompt de comando e execute:
git clone https://github.com/Yume7/TarefasApp

Em seguida, entre na pasta do projeto:
cd TarefasApp

Configure o banco de dados:
Rodar o seguinte comando para criar e iniciar o contêiner do banco de dados:

docker-compose up -d

Credenciais para login:
Usuário: sa
Senha: Admin@123



Execute as migrações do banco de dados:
Para garantir que todas as tabelas e estrutura do banco de dados estejam corretamente criadas, rode o comando:

dotnet ef database update

Este comando aplicará as migrações no banco de dados configurado.

Inicie manualmente a API e a aplicação Blazor executando:
dotnet run --project src/TarefasApp.Server (Ou basta clicar em iniciar no Visual Studio)

Acesse a aplicação:
Após iniciar a aplicação, ela estará disponível nos seguintes endereços:

A API pode ser acessada em: https://localhost:7175
A aplicação Blazor pode ser acessada em: https://localhost:7121


🗄️ Banco de Dados

A aplicação utiliza Entity Framework Core para gerenciar o banco de dados SQL Server. As entidades são validadas utilizando FluentValidation, garantindo que os dados estejam corretos antes de serem persistidos.

📄 Licença

Este projeto é apenas para fins de avaliação técnica.

Caso tenha dúvidas, sinta-se à vontade para entrar em contato. 🚀