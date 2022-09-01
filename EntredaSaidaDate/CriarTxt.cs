using System.IO;

namespace EntredaSaidaDate
{
    class CriarTxt
    {
        public void CriarArquivo()
        {


            string targetPath1 = @"C:\Projeto\Saida-de-Data1.txt";
            string targetPath2 = @"C:\Projeto\Saida-de-Data2.txt";
            string targetPath3 = @"C:\Projeto\Saida-de-Data3.txt";

            ArquivoTxt txt = new ArquivoTxt( );
            StreamWriter txt1 = new StreamWriter(targetPath1);
            txt1.WriteLine(txt.D1);
            txt1.Close();
            StreamWriter txt2 = new StreamWriter(targetPath2);
            txt2.WriteLine(txt.D2);
            txt2.Close();
            StreamWriter txt3 = new StreamWriter(targetPath3);
            txt3.WriteLine(txt.D3);
            txt3.Close();
        }
    }
}
