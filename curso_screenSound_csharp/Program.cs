//Screen Sound

//List<string> listaDasBandas = new List<string>{ "U2", "Iron Mainden", "Gojira"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 9});
bandasRegistradas.Add("The Beatles", new List<int>());

void ExbirLogo()
{
    string mensagemDeBoasVindas = "𝙎𝙘𝙧𝙚𝙚𝙣 𝙎𝙤𝙪𝙣𝙙";
    Console.WriteLine(mensagemDeBoasVindas);
}

ExbirLogo();

void ExibirOpcoesDoMenu()
{
    ExbirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("Digite sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica) 
    {
        case 1 : RegistarBanda();
        break;
        case 2 : MostrarBandasRegistradas();
        break;
        case 3 : AvaliarUmaBanda();
        break;
        case 4 : Console.WriteLine("Você escolheu a opção número 4");
        break;
        case -1 : Console.WriteLine("Você escolheu a opção número -1");
        break;
        default : Console.WriteLine("invalida");
        break;
    }


}


void RegistarBanda()
{
    Console.Clear();
    
    ExibirOTituloDaopcao("Registro de Bandas");
    Console.WriteLine("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda foi {nomeDaBanda} registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirOTituloDaopcao("Exibindo todas a badas registradas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
      //  Console.WriteLine($"Banda : {listaDasBandas[i]}");
        
    //}

     foreach (string banda in bandasRegistradas.Keys)
     {
        Console.WriteLine($"Banda : {banda}");
     }

     Console.WriteLine("\nDigite qualquer tecla para sair.");
     Console.ReadKey();
     Console.Clear();
     ExibirOpcoesDoMenu();
}

void ExibirOTituloDaopcao(string titulo) {
   int quantidadeDeTetras = titulo.Length;
   string asteriscos = string.Empty.PadLeft(quantidadeDeTetras, '*');
   Console.WriteLine(asteriscos);
   Console.WriteLine(titulo);
   Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //digie qual banda desja avaliar
    //verificar se a banda exise no dicionario >> atribuir uma nota
    //Se não, voltar para o menu principal
    Console.Clear();
    ExibirOTituloDaopcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

    } else
    {
        Console.WriteLine($"\nA {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu()
    }
}

ExbirLogo();
ExibirOpcoesDoMenu();