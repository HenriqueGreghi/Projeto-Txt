using System;
using System.IO;

namespace EntredaSaidaDate
{
    class CriarArquivo : ILerECriarArquivo
    {
        public void EnviarResultado(string[] datas)
        {
            var contador = 0;

            foreach (var data in datas)
            {
                contador++;

                using (StreamWriter sw = File.AppendText($@"C:\Projeto\Entrada-de-Data{contador}.txt"))
                {
                    sw.Write(data);
                }
            }
        }
    }
}
