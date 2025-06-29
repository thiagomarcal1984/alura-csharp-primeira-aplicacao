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
# Tipos e funções no C#
## Isolando o código com funções
Nomes de função no C# são escritos no padrão PascalCase (diferente do camelCase nos nomes de variáveis locais).

Como declarar funções no C#:
1. escreva o tipo de retorno da função;
2. escreva o nome da função;
3. escreva o corpo da função entre chaves; e
4. caso a função retorne alguma coisa, use `return` e o objeto que será retornado.

Código de `Program.cs` modificado:
```CSharp
// Program.cs
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("***************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("***************************");
}

ExibirMensagemDeBoasVindas();
```
