# MyApiV2 🚀

Este projeto consiste em uma API para gerenciar estudantes e realizar operações relacionadas ao gerenciamento de dados estudantis. Foi construído utilizando ASP.NET Core com Entity Framework para manipulação do banco de dados.

## Estrutura do Projeto 🗂️

- **Data**: Contém a classe `AppDbContext.cs`, que é responsável pela configuração do contexto do banco de dados.
- **Migrations**: Arquivos de migração para gerenciar alterações no esquema do banco.
- **Students**: 
  - `AddStudentRequest.cs`: Estrutura da requisição para adicionar um estudante.
  - `Student.cs`: Modelo do estudante.
  - `StudentsEndpoints.cs`: Endpoints para operações com estudantes. (Sim, sabemos que escrevi "Studant"... às vezes é a pressa, né? 😅)
- **Arquivos de Banco de Dados**: Inclui `app.db` (SQLite) e arquivos auxiliares.
- **Configurações**: Arquivos `appsettings.json` para configurar strings de conexão e ambiente.
- **Program.cs**: Ponto de entrada da aplicação.

## Como Executar o Projeto 🏃

1. **Clone o Repositório**:
   ```sh
   git clone <url_do_repositorio>
   cd MyApiV2
   ```
2. **Restaurar Dependências**:
   ```sh
   dotnet restore
   ```
3. **Aplicar Migrações**:
   ```sh
   dotnet ef database update
   ```
4. **Executar a API**:
   ```sh
   dotnet run
   ```
5. **Testar a API**: Use Postman ou `MyApiV2.http` para testar os endpoints.

## Endpoints Principais 🔗

- **GET /students**: Retorna todos os estudantes.
- **POST /students**: Adiciona um novo estudante (use `AddStudentRequest`).

## Tecnologias Utilizadas 🛠️

- **ASP.NET Core**: Construção de aplicações web/APIs.
- **Entity Framework Core**: ORM para o banco de dados.
- **SQLite**: Banco de dados leve para persistência.

## Banco de Dados 🗄️

Por padrão, utilizamos o SQLite local (`app.db`). Você pode modificar `appsettings.json` para outra configuração de banco.

## Contribuições 💡

Contribuições são bem-vindas! Abra uma issue ou pull request com suas sugestões.

## Licença 📄

Licenciado sob a [Licença MIT](LICENSE).


