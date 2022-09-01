using System;
using System.IO;

namespace EntredaSaidaDate
{
    class ArquivoTxt
    {
        private DateTime D { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        private string Line { get; set; }

      

        public void LerArquivo()
        {

            FileStream fs = null;
            StreamReader sr = null;

            string path = @"C:\Projeto\Entrada-de-Data.txt";
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);
            Line = sr.ReadLine();
            DateTime d = DateTime.Parse(Line);

            D1 = d.ToString("MM/dd/yy");
            D2 = d.ToString("yy/MM/dd");
            D3 = d.ToString("dd-MM-yy");


        }
        public void CriarArquivo()
        {
            string targetPath1 = @"C:\Projeto\Saida-de-Data1.txt";
            string targetPath2 = @"C:\Projeto\Saida-de-Data2.txt";
            string targetPath3 = @"C:\Projeto\Saida-de-Data3.txt";

            
            StreamWriter txt1 = new StreamWriter(targetPath1);
            txt1.WriteLine(D1.ToString());
            txt1.Close();
            StreamWriter txt2 = new StreamWriter(targetPath2);
            txt2.WriteLine(D2.ToString());
            txt2.Close();
            StreamWriter txt3 = new StreamWriter(targetPath3);
            txt3.WriteLine(D3.ToString());
            txt3.Close();
        }
    }
}
