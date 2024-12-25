//Screen Sound

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
        case 2 : Console.WriteLine("Você escolheu a opção número 2");
        break;
        case 3 : Console.WriteLine("Você escolheu a opção número 3");
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
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda foi {nomeDaBanda} registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExbirLogo();
ExibirOpcoesDoMenu();