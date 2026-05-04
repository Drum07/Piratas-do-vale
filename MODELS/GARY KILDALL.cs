using System;

namespace PIRATASDOVALE
{
    class GaryKildall : Personagem
    {
        public string sistema;

        public override void Falar()
        {
            Console.WriteLine(Nome + ": sistemas operacionais são a base o mundo da tecnologia.");
        }

        public override void CriarProduto()
        {
            Console.WriteLine(Nome + " está desenvolvendo um novo sistema chamado " + sistema);
        }

        public void ProgramarSistema()
        {
            Console.WriteLine(Nome + " está programando está aprimorando novos sistemas.");
        }
    }
}