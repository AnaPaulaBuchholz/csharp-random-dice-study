using csharp_random_dice_study.Enums;
using System;

namespace csharp_random_dice_study
{
    public class Dado
    {
        public Acoes Dado1 { get; private set; }
        public PartesDoCorpo Dado2 { get; private set; }


        public string Sortear()
        {
            //Obtendo o dado para gerar os valores aleatórios
            var random = new Random();

            //Lançando o dado para obter a ação
            var valorAleatorio = random.Next(1, 6);
            Dado1 = (Acoes)valorAleatorio;

            //Lançando o dado novamente para obter a parte do corpo
            valorAleatorio = random.Next(1, 6);
            Dado2 = (PartesDoCorpo)valorAleatorio;

            //Formando a frase final
            return FormatarFrase(Dado1, Dado2);
        }

        private string FormatarFrase(Acoes acoes, PartesDoCorpo partesDoCorpo)
        {
            var acao = acoes.ToString().ToLower();

            var parteDoCorpo = partesDoCorpo.ToString().ToLower();
            parteDoCorpo = parteDoCorpo.Replace('_', ' ');

            return $"O jogador deverá {acao} o/a {parteDoCorpo} do outro jogador";
        }
    }
}
