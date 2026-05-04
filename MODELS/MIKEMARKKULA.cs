using System;

namespace PIRATASDOVALE
{
    class MikeMarkkula : Personagem
    {
        public string estrategia;

        public override void Falar()
        {
            Console.WriteLine(Nome + ": Devemos pensar no futuro, devemos investir em nossas tecnologias para avançarmos na vida e vencer  os desafios.");
        }

        public override void CriarProduto()
        {
            Console.WriteLine(Nome + " O produto deve ser ideal para os clientes amarem, por isso a estrategia de " + estrategia);
        }

        public void Investir()
        {
            Console.WriteLine(Nome + " Nossos investimentos em inovação é essencial para que possamos criar soluções que impactem positivamente na vida das pessoas.");
        }
    }
}