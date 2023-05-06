# Store-Api

## Sobre o projeto

Aplicação com simples intuito de criar uma API em C# .net 6 que seja possível cadastrar um usuário e produtos, possuindo autenticação por JWT para cadastrar, atualizar ou deletar algum produto, migration para que seja gerado a estrutura padrão do banco de dados e alguns padrões de projeto.

## Configurações

Para executar o projeto em sua completude, será necessário ter os seguintes programas e ferramentas instaladas:

- [.net 6 Framework](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio](https://learn.microsoft.com/pt-PT/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
- [Visual Code](https://code.visualstudio.com/)
- C# for Visual Studio Code (Extensão recomendada para o Visual Code)

Como ferramenta adicional, execute ```sh dotnet tool install -g dotnet-ef ``` globalmente no terminal. Essa ferramente será necessária para criar o banco de dados a partir da migration contida no código.

## Preparando o projeto

Após o clone do repositório, o primeiro passo será criar um banco de dados no SQL Server e atualizar a chave de conexão continda no arquivo **appsettings.Development.json** encontrado no caminho **../API/Store.Api.Application**. para que seja possível se conectar ao mesmo.

Com o banco criado, abra o caminho da pasta **../Infrastructure/Data** no terminal e execute o comando ``dotnet ef database update``. Com esse comando, será criado as tabelas User e Product necessários para a aplicação.

Nesse ponto, o banco de dados já deverá estar OK para que a apliacão funcione da forma que deveria.

Para finalizar, execute o comando ``dotnet dev-certs https --trust`` e aceite o certificado para que seja possível executar a API em HTTPS.

## Iniciando a API

Para executar a API, certifique-se que o launcher no Visual Code esteja corretamente selecionado:

![image](https://user-images.githubusercontent.com/49561885/236647714-56c82722-e431-445a-9a02-7e6ea9dfec19.png)

Com isso, basta pressionar F5 e a aplicação estará rodando no link https://localhost:5000/.

Como a API possui integração com a ferramente de documentação Swagger, abra no navegador a seguinte URL: https://localhost:5000/swagger/index.html, com isso você terá acesso a todos os métodos necessários e documentação dos models de request para cada método.

![image](https://user-images.githubusercontent.com/49561885/236647925-72a9c02b-4f4a-40e0-9232-a857d1747936.png)

Primeiramente, crie um usuario usando o método POST de USER, esse usuário será necessário para se autenticar e que seja possível cadastrar, atualizar ou deletar algum produto.

Após a execução do método, utilizer o método Auth/Authenticate com os dados de usuário criado e use o token gerado como resposta para autenticar o usuário.

![image](https://user-images.githubusercontent.com/49561885/236648220-eac10e4d-5551-4a52-abbd-8b7cbb646caa.png)

![image](https://user-images.githubusercontent.com/49561885/236648227-ef62a1ca-b50f-438c-b703-66bf3ac5050c.png)

![image](https://user-images.githubusercontent.com/49561885/236648245-e2b81634-0789-4de9-8b88-0bc66d4da17a.png)

![image](https://user-images.githubusercontent.com/49561885/236648252-70ba1ed6-d908-49ef-a999-997e43eb8ebb.png)

Com isso, todos os métodos serão acessiveis e funcionais.
