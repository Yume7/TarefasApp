# TarefasApp

**TarefasApp** é uma aplicação web desenvolvida como parte de um desafio técnico para a Accenture. 
O sistema tem como objetivo o gerenciamento de tarefas, aplicando princípios modernos de desenvolvimento como DDD (Domain-Driven Design), boas práticas SOLID, e arquitetura limpa.

---

## 🚀 Tecnologias Utilizadas

- ASP.NET Core
- Blazor Server
- Entity Framework Core (Code First)
- SQL Server
- Docker
- FluentValidation
- Arquitetura baseada em DDD
- Princípios SOLID

---

## 🔧 Pré-requisitos

Antes de executar o projeto, certifique-se de ter os seguintes itens instalados em sua máquina:

- [Git Bash](https://gitforwindows.org/) – para executar comandos dentro da pasta do projeto
- [Docker](https://www.docker.com/get-started) e [Docker Compose](https://docs.docker.com/compose/install/) – para rodar o SQL Server no contêiner
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) – com a **.NET SDK** instalada
- [.NET 7.0+ SDK](https://dotnet.microsoft.com/download/dotnet) – necessário para rodar a aplicação

---

## ⚙️ Configuração e Execução

### 🔄 Clonando o repositório

git clone https://github.com/Yume7/TarefasApp
cd TarefasApp

### 🐳 Subindo o Banco de Dados com Docker

Este projeto utiliza Docker apenas para o banco de dados (SQL Server). Para iniciar o contêiner, siga os passos:

1. Abra a pasta do projeto
2. Clique com o botão direito e selecione **"Git Bash Here"**
3. Execute o comando:

   docker-compose up -d

Certifique-se de que o contêiner do SQL Server está em execução antes de iniciar a aplicação.

###🔹 Configurar o Visual Studio para rodar múltiplos projetos

No Gerenciador de Soluções, clique com o botão direito na Solução (TarefasApp) e selecione "Definir Projetos de Inicialização".
Escolha a opção "Vários Projetos de Inicialização".
Para os projetos TarefasApp.API e TarefasApp.UI (Blazor), defina a Ação como "Iniciar".
Clique em OK.

🚀 Executando a Aplicação
Após configurar o banco de dados, inicie a aplicação normalmente pelo Visual Studio ou CLI:

Blazor Server: https://localhost:7121
API: https://localhost:7175/api/

---

## 🧪 Banco de Dados

A conexão com o banco de dados está definida no `DataContext` via Code First:

User Id = sa
Password = Admin@123;

---

## 📁 Estrutura do Projeto

A estrutura segue o padrão DDD com separação clara por camadas:

TarefasApp/
1 - Presentation/      # Camada responsável pela interface do usuário (Blazor)
2 - Application/       # Contém os serviços da aplicação (API, Controllers)
3 - Domain/            # Representa o núcleo do sistema com entidades e regras de negócio
4 - InfraStructure/    # Camada de persistência e comunicação com o banco de dados
Itens de Solução/      # Contém o arquivo docker-compose.yml

## ✅ Funcionalidades

- Criar, editar, excluir e listar tarefas
- Validações robustas com FluentValidation
- Interface dinâmica com Blazor
- Organização por responsabilidades (DDD)
- Persistência com EF Core Code First

---

## 

📄 Licença

Este projeto é apenas para fins de avaliação técnica.

Desenvolvido por Ingridy Sousa (https://github.com/Yume7) para avaliação técnica da **Accenture**.
