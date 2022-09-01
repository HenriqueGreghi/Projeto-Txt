using System;
using System.IO;
namespace EntredaSaidaDate
{
    class Program
    {
        static void Main(string[] args)
        {



            ArquivoTxt txt = new ArquivoTxt();
            txt.LerArquivo();

            txt.CriarArquivo();

            Console.WriteLine(txt.D1);
            Console.WriteLine(txt.D2);
            Console.WriteLine(txt.D3);

        }
    }
}
