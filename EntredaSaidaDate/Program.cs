using System;
using System.IO;
namespace EntredaSaidaDate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\Projeto\Entrada-de-Data.txt";
            string targetPath1 = @"C:\Projeto\Saida-de-Data1.txt";
            string targetPath2 = @"C:\Projeto\Saida-de-Data2.txt";
            string targetPath3 = @"C:\Projeto\Saida-de-Data3.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr= new StreamReader(fs);
                string line = sr.ReadLine();
                DateTime d = DateTime.Parse(line);
                string d1 = d.ToString("MM/dd/yy");
                string d2 = d.ToString("yy/MM/dd");
                string d3 = d.ToString("dd-MM-yy");
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);

               
                StreamWriter txt1 = new StreamWriter(targetPath1);
                txt1.WriteLine(d1.ToString());
                txt1.Close();
                StreamWriter txt2 = new StreamWriter(targetPath2);
                txt2.WriteLine(d2.ToString());
                txt2.Close();
                StreamWriter txt3 = new StreamWriter(targetPath3);
                txt3.WriteLine(d3.ToString());
                txt3.Close();
            }
            catch (Exception)
            {

                throw;
            }

            

        }
    }
}
