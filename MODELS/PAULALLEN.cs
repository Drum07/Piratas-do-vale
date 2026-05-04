using System;

namespace PIRATASDOVALE
{
    class PaulAllen : Personagem
    {
        public string projeto;

        public override void Falar()
        {
            Console.WriteLine(Nome + ": Pessoal a tecnologia avança sem parar, e nos devemos evoluir com ela, devemos aprender a usa-la.");
        }

        public override void CriarProduto()
        {
            Console.WriteLine(Nome + " está desenvolvendo um novo software com uma configuração inovadora chamado " + projeto);
        }

        public void InvestirTecnologia()
        {
            Console.WriteLine(Nome + " está investindo em novas ideias de jogos e programas e telas de tecnologias inovadoras.");
        }
    }
}