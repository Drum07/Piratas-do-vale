using System;
using PIRATASDOVALE;

namespace PIRATASDOVALE
{
    class Program
    {
        static void Main(string[] args)
        {
            SteveJobs jobs = new SteveJobs();
            jobs.Nome = "Steve Jobs";
            jobs.empresa = "Apple";
            jobs.Falar();
            jobs.CriarProduto();

            SteveWozniak woz = new SteveWozniak();
            woz.Nome = "Steve Wozniak";
            woz.especialidade = "Hardware";
            woz.Falar();
            woz.CriarProduto();

            RobertaWilliams roberta = new RobertaWilliams();
            roberta.Nome = "Roberta Williams";
            roberta.jogo = "King's Quest";
            roberta.Falar();
            roberta.CriarProduto();

            PaulAllen paul = new PaulAllen();
            paul.Nome = "Paul Allen";
            paul.projeto = "Sistema Empresarial";
            paul.Falar();
            paul.CriarProduto();

            MikeMarkkula mike = new MikeMarkkula();
            mike.Nome = "Mike Markkula";
            mike.estrategia = "Marketing";
            mike.Falar();
            mike.CriarProduto();

            GaryKildall gary = new GaryKildall();
            gary.Nome = "Gary Kildall";
            gary.sistema = "CP/M";
            gary.Falar();
            gary.CriarProduto();

            BillGates bill = new BillGates();
            bill.Nome = "Bill Gates";
            bill.software = "Windows";
            bill.Falar();
            bill.CriarProduto();
        }
    }

    class SteveJobs
    {
        public string Nome { get; set; }
        public string empresa { get; set; }
        public void Falar()
        {
            Console.WriteLine("Olá, eu sou " + Nome);
        }
        public void CriarProduto()
        {
            Console.WriteLine("Criei a empresa " + empresa);
        }
    }

    class SteveWozniak
    {
        public string Nome { get; set; }
        public string especialidade { get; set; }
        public void Falar()
        {
            Console.WriteLine("Olá, eu sou " + Nome);
        }
        public void CriarProduto()
        {
            Console.WriteLine("Minha especialidade é " + especialidade);
        }
    }

    class RobertaWilliams
    {
        public string Nome { get; set; }
        public string jogo { get; set; }
        public void Falar()
        {
            Console.WriteLine("Olá, eu sou " + Nome);
        }
        public void CriarProduto()
        {
            Console.WriteLine("Criei o jogo " + jogo);
        }
    }

    class PaulAllen
    {
        public string Nome { get; set; }
        public string projeto { get; set; }
        public void Falar()
        {
            Console.WriteLine("Olá, eu sou " + Nome);
        }
        public void CriarProduto()
        {
            Console.WriteLine("Trabalhei no projeto " + projeto);
        }
    }

    class MikeMarkkula
    {
        public string Nome { get; set; }
        public string estrategia { get; set; }
        public void Falar()
        {
            Console.WriteLine("Olá, eu sou " + Nome);
        }
        public void CriarProduto()
        {
            Console.WriteLine("Minha estratégia é " + estrategia);
        }
    }

    class GaryKildall
    {
        public string Nome { get; set; }
        public string sistema { get; set; }
        public void Falar()
        {
            Console.WriteLine("Olá, eu sou " + Nome);
        }
        public void CriarProduto()
        {
            Console.WriteLine("Criei o sistema " + sistema);
        }
    }

    class BillGates
    {
        public string Nome { get; set; }
        public string software { get; set; }
        public void Falar()
        {
            Console.WriteLine("Olá, eu sou " + Nome);
        }
        public void CriarProduto()
        {
            Console.WriteLine("Criei o software " + software);
        }
    }
}