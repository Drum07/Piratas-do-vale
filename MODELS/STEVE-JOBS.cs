using System;

namespace PIRATASDOVALE
{
    class SteveJobs : Personagem
    {
        public string empresa;

        public override void Falar()
        {
            Console.WriteLine(Nome + ": inovação acontece quando pensamos diferente ou escolhemos ser diferentes.");
        }

        public override void CriarProduto()
        {
            Console.WriteLine(Nome + " está criando um novo produto na empresa uma nova inovação " + empresa);
        }

        public void OprimirAequipe()
        {
            Console.WriteLine(Nome + " está oprimindo a equipe pela ganancia.");
        }
    }
}