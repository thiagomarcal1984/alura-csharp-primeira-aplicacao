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
## Faça como eu fiz: primeiro jogo com C#
```CSharp
// Jogo\Program.cs
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 11);

int chute = -1;
do
{
    Console.Write("Adivinhe o número: ");
    try
    {
        chute = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("Escreva um número!");
    }
    if (chute < numeroSecreto)
        Console.WriteLine("O número é maior");
    else if (chute > numeroSecreto)
        Console.WriteLine("O número é menor");
    else
        Console.WriteLine("Você adivinhou!");
} while (chute != numeroSecreto);
```
# Listas e loops no C#
## Criando a lista de músicas
Mudanças no código `Program.cs`:
```CSharp
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirLogo()
{
    Console.Clear();
    // Resto do código
}

void RegistrarBanda()
{
    ExibirLogo();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000); // Espera 2 segundos.
    ExibirOpcoesDoMenu();
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    // Resto do código
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
        // Resto do código
    }
}
ExibirLogo();
ExibirOpcoesDoMenu();
```
> Foco na interpolação de string com `$"String {variavel}"`: veja o exemplo debaixo da declaração da variável `nomeDaBanda` na função `RegistrarBanda()`.

## Adicionando músicas na lista
```CSharp
// Program.cs
// Resto do código
List<string> lista = new List<string>();

// Resto do código
void RegistrarBanda()
{
    // Resto do código
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    lista.Add(nomeDaBanda);
    // Resto do código
}
// Resto do código
```
Agora falta exibir o conteúdo da lista.

## Estrutura de repetição for
```CSharp
// Program.cs
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> lista = new List<string>(){
    "U2",
    "Beatles",
    "Calipso"
};

// Resto do código

void MostrarBandasRegistradas()
{
    ExibirLogo();
    Console.WriteLine();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");
    if (lista.Count == 0)
    {
        Console.WriteLine("Não há bandas registradas");
    }

    for (int i = 0; i < lista.Count; i++)
    {
        Console.WriteLine(lista[i]);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void ExibirOpcoesDoMenu()
{
    // Resto do código
    switch (opcaoEscolhidaNumerica)
    {
        // Resto do código
        case 2:
            MostrarBandasRegistradas();
            break;
    // Resto do código
    }
}
// Resto do código
```
> Note a inicialização da lista como ela mudou: `new List<string>(){ "El1", "El2", "El3"};`.

Neste exemplo, o loop que estamos usando é o for simples:
```CSharp
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}
```
## Foreach para cada música
O comando `foreach` é mais legível do que o `for` normal. Veja:

```CSharp
foreach (string banda in listaDasBandas)
{
    Console.WriteLine($"Banda: {banda}");
}
```
# Dicionários e avaliação de bandas
## Ajustando exibição do título
```CSharp
// Program.cs
// Resto do código
void RegistrarBanda()
{
    ExibirTituloDaOpcao("Registro das bandas");
    // Resto do código
}

void MostrarBandasRegistradas()
{
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    // Resto do código
}

void ExibirTituloDaOpcao(string titulo)
{
    Console.Clear();
    Console.WriteLine();
    string asteriscos = string.Empty.PadLeft(titulo.Length, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine($"{titulo}");
    Console.WriteLine(asteriscos + "\n");
}

// Resto do código
```
> A novidade é a função `PadLeft`, que recebe como parâmetros o comprimento da string resultante e o char que vai preencher a string à esquerda.

## Criando o dicionário / Ajustando para o dicionário
Vamos substituir a lista de bandas por um dicionário cujas chaves são os nomes das bandas e os valores serão listas de notas para cada banda.

```CSharp
// Program.cs
// Resto do código
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>
{
    { "Linkin Park",    new List<int>{10, 8, 6} },
    { "Beatles",        new List<int>() },
};
// Resto do código
```
> Note que é possível instanciar um dicionário sem usar parênteses, mas sim chaves. Cada key-value pair também é acrescentado ao dicionário com chaves.

Vamos substituir o código de operação na lista de bandas por código para operação no dicionário de bandas:
```CSharp
// Program.cs
// Resto do código
void RegistrarBanda()
{
    // Resto do código
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); // Acréscimo de chave/valor.
    // Resto do código
}

void MostrarBandasRegistradas()
{
    // Resto do código
    foreach (string banda in bandasRegistradas.Keys) // Iteramos as chaves, não o dicionário.
    {
        Console.WriteLine($"Banda: {banda}");
    }
    // Resto do código
}
// Resto do código
```
