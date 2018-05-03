using System.IO;

namespace PrimeiraClasse
{
    public class CriarArquivos
    {
        //Atributos da classe CriarArquivo
        public string nomearquivo;
        public string extensao;
        public int codigoproduto;
        public string nomeproduto;
        public string marcaproduto;
        public double precoproduto;

        //Funcionalidade da classe, comportamento
        public string salvar()
        {
            /*
            Vamos usar uma classe para nos ajudar a criar um arquivo de texro e escrever dentro desse arquivo.
            Utilizaremos a classe StreamWriter
             */
            StreamWriter ar = new StreamWriter(nomearquivo+"."+extensao, true);
            //Vamos escrever os dados no arquivo
            ar.WriteLine(codigoproduto+";"+nomeproduto+";"+marcaproduto+";"+precoproduto);
            //Fechar o arquivo para salvar e tirar da memória
            ar.Close();
            
            return "Salvo com sucesso";
        }
    }
}