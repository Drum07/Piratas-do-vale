using System;

namespace PIRATASDOVALE
{
    class RobertaWilliams : Personagem
    {
        public string jogo;

        public override void Falar()
        {
            Console.WriteLine(Nome + ": jogos podem mudar nossas realidades e nosso ponto de vista.");
        }

        public override void CriarProduto()
        {
            Console.WriteLine(Nome + " está criando um novo jogo com alta perfomace chamado " + jogo);
        }

        public void CriarNarrativa()
        {
            Console.WriteLine(Nome + " está escrevendo puzzles para melhorar a jogabilidade e narrativas interativas com os personagens.");
        }
    }
}