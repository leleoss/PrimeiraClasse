using System;

namespace PrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // int codigo;
            // string nome;
            // string marca;
            // double preco;

            // //Limpar a tela de console
            // Console.Clear();

            // Console.WriteLine("Digite o código do produto");
            // codigo = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o nome do produto");
            // nome = Console.ReadLine();

            // Console.WriteLine("Digite o nome da marca");
            // marca = Console.ReadLine();

            // Console.WriteLine("Digite o preco do produto");
            // preco = double.Parse(Console.ReadLine());
            
            
            // //Instância da classe CriarArquivo
            // CriarArquivos ca = new CriarArquivos();
            // ca.nomearquivo = "Produtos";
            // ca.extensao = ".csv" .Replace(".", "");
            // ca.codigoproduto = codigo;
            // ca.nomeproduto = nome;
            // ca.marcaproduto = marca;
            // ca.precoproduto = preco;
            // Console.WriteLine(ca.salvar());



            LerArquivo la = new LerArquivo();
            la.nomearquivo = "produtos";
            la.extensao = "csv";
            la.ler();

        }
    }
}
