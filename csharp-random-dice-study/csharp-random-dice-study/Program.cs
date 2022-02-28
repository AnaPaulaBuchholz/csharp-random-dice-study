using csharp_random_dice_study;

var tecla = "d";
while (tecla.ToLower() == "d")
{
    Console.WriteLine("Digite a tecla 'D' para lançar os dados ou qualquer outra tecla para sair");
    tecla = Console.ReadLine();

    if (tecla.ToLower() == "d")
        Console.WriteLine(new Dado().Sortear());
    else
    {
        Console.WriteLine("Tem certeza que deseja sair: 'S' para SIM e 'N' para NÃO.");
        var confirmacao = Console.ReadLine();

        if (confirmacao.ToLower() == "n")
            tecla = "d";
    }
}
Console.WriteLine("Obrigado por jogar!");

