# Boas-vindas ao repositório do Projeto Inscrições para Universidade 

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Executar o projeto localmente</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project/acc-csharp-0x-project-university-applications.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project/acc-csharp-0x-project-university-applications`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
</details>
  

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

</details>


# O Projeto

Este projeto permitirá que uma pessoa estudante se candidate a várias vagas de universidade ao redor do mundo. 

O projeto integra uma API no sistema, para que os alunos possam encontrar universidades de acordo com o nome e o país.

 
## Realizando a integração com a api Universities 

<details>
  <summary>Interface `../university-applications/Services/IUniversityService.cs` na classe `../university-applications/Services/UniversityService` </summary><br />

Na página do projeto da API [Universities](https://github.com/Hipo/university-domains-list), pode ser visto como é feita a pesquisa pelos endpoints para realizar a integração.

Na interface `IUniversityService` existe o método `FindUniversity` com duas assinaturas diferentes: a primeira busca por uma parte do nome e o país, e a segunda lista apenas as universidades do país informado.

</details>

## 1 - Criando os endpoints para a  API e criando testes unitários

<details>
  <summary>Implementando a interface `../university-applications/Controller/IUniversityController` na classe `../university-applications/Controller/UniversityController` </summary><br />

Na interface `IUniversityController` existe o método `FindUniversity` com duas assinaturas diferentes: a primeira busca por uma parte do nome e o país, e a segunda lista apenas as universidades do país informado.

</details>

<details>
  <summary>Testando as funções em `../university-applications.Test/UniversityServiceTest` </summary><br />

testes unitários da classe `UniversityService`, testando as funções: `ShouldReturnUniversityByCountryAndName` e `ShouldReturnAUniversityByCountry`

</details>

## 2 - Testes de integração na  API

<details>
  <summary>Testando funções em ``../university-applications.Test/UniversityIntegrationTest` </summary><br />

testes unitários da classe `UniversityService` testando as funções: `ShouldFindAUniversityByCountryAndName` e `ShouldFindAUniversityByCountry`

</details>

