using System;

namespace PIRATASDOVALE
{
    class BillGates : Personagem
    {
        public string software;

        public override void Falar()
        {
            Console.WriteLine(Nome + ": Nossas tecnologias são o começo da inovação, pessoas iram querer nossos sistemas.");
        }

        public override void CriarProduto()
        {
            Console.WriteLine(Nome + " está desenvolvendo um novo software chamado " + software);
        }

        public void LiderarEmpresa()
        {
            Console.WriteLine(Nome + " está liderando a equipe.");
        }
    }
}