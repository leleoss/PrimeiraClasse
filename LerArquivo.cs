using System;
using System.IO;
using System.Text;

namespace PrimeiraClasse
{
    public class LerArquivo
    {
        public string nomearquivo;
        public string extensao;


        public void ler()
        
    {
        /*
        Para ler o arquivo do usuário vamos utilizar a Classe StreamReader.
        Faremos uma condição para saber se chegamos ao final do arquivo. Caso tenha chegado ao fim do arquivo, o comando ReadLine retornará null; caso contrário ele retornará linha do arquivo
         */
         StreamReader ar = new StreamReader(nomearquivo+"."+extensao,Encoding.UTF8);
         string linha="";
         while((linha=ar.ReadLine())!=null)
         {
             Console.WriteLine(linha);
         }

         ar.Close();

    }
        
    }
}