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
## Variáveis do tipo texto
Visite o site https://fsymbols.com/ para criar textos com combinações interessantes de caracteres.

O C# permite uma string de múltiplas linhas. Basta prefixar a string com uma arroba (`@`). É o chamado `verbatim literal`.
```CSharp
string textoMultiLinha = @"
    Este
        é
            um
                texto
                    multi
                        linha.
";

Console.WriteLine(textoMultiLinha);
```

Mudanças em `Program.cs`:
```CSharp
// Program.cs
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média");
    Console.WriteLine("Digite -1 para sair");
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
```
## Variáveis do tipo inteiro
Mudança no código de `Program.cs`:
```Csharp
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

// Resto do código

void ExibirOpcoesDoMenu()
{
    // Resto do código

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // A exclamação proibe retorno de nulo na função.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine($"Você digitou a opção {opcaoEscolhida}");
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
```
> Note a exclamação depois de `Console.ReadLine()`: ela serve para parar de destacar o warning na IDE. Ele é chamado de operador de supressão de nulo.

A conversão de variável de string para inteiro é muito simples. Basta usar a função `int.Parse(variavel)`.

## Uso de if/else e switch/case
Sintaxe de switch/case:
```Csharp
    switch (inteiro)
    {
        case 1: 
            Console.WriteLine("Um");
            // Mais linhas de código
            break;
        case 2: 
            Console.WriteLine("Dois");
            // Mais linhas de código
            break;
        default:
            Console.WriteLine("Saída default");
    }
```

Código de `Program.cs` mudado:
```CSharp
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{
    // Resto do código
}

void ExibirOpcoesDoMenu()
{
    // Resto do código
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // A exclamação proibe retorno de nulo na função.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Console.WriteLine($"Você digitou a opção {opcaoEscolhida}");
            break;
        case 2:
            Console.WriteLine($"Você digitou a opção {opcaoEscolhida}");
            break;
        case 3:
            Console.WriteLine($"Você digitou a opção {opcaoEscolhida}");
            break;
        case 4:
            Console.WriteLine($"Você digitou a opção {opcaoEscolhida}");
            break;
        case -1:
            Console.WriteLine($"Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
```
