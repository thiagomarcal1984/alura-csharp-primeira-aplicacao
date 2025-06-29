# Criando o primeiro programa
## Preparando o ambiente: Windows

Vá para o diretório raiz e crie a solução com o seguinte comando:

```bash
dotnet new solution -n PrimeiroProjeto
```
Vamos criar um novo projeto de console com o nome `PrimeiroProjeto` e acrescentá-lo à solução `PrimeiroProjeto`:

```bash
dotnet new console -n PrimeiroProjeto
dotnet solution add PrimeiroProjeto
```
Para rodar o projeto, execute o seguinte comando na raiz da solução:

```bash
dotnet run --project PrimeiroProjeto
```
Esse comando vai executar o programa `Program.cs`, cujo conteúdo segue:
```CSharp
// PrimeiroProjeto\Program.cs
Console.WriteLine("Hello, World!");
```

## Preparando o ambiente: Visual Studio Code
Alternativamente, podemos executar o código do `Program.cs` entrando no diretório do projeto e executando o com `dotnet run Program.cs`:
```bash
cd PrimeiroProjeto
dotnet run Program.cs
```

## Primeiro programa
C# é uma linguagem fortemente tipada. Assim, temos que declarar o tipo e o nome da variável.

A convenção de escrita no C# é a camelCase (como no Java).

Vamos reescrever o código de `Program.cs`:

```CSharp
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Console.WriteLine(mensagemDeBoasVindas);
```
