// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>(){
    "U2",
    "Beatles",
    "Calipso"
};

void ExibirLogo()
{
    Console.Clear();
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void RegistrarBanda()
{
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    listaDasBandas.Add(nomeDaBanda);
    Thread.Sleep(2000); // Espera 2 segundos.
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    if (listaDasBandas.Count == 0)
    {
        Console.WriteLine("Não há bandas registradas");
    }

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
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

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // A exclamação proibe retorno de nulo na função.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
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

ExibirLogo();
ExibirOpcoesDoMenu();
