using System;

namespace PIRATASDOVALE
{
    class SteveWozniak : Personagem
    {
        public string especialidade;

        public override void Falar()
        {
            Console.WriteLine(Nome + ": A tecnologia deve ser usada para ajudar os outros para uma evolução.");
        }

        public override void CriarProduto()
        {
            Console.WriteLine(Nome + " está desenvolvendo um novo projeto para melhorar nossas tecnologias" + especialidade);
        }

        public void Programação()
        {
            Console.WriteLine(Nome + " está programando novos codigos e montando novos circuitos.");
        }
    }
}