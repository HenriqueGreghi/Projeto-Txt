using System;
using System.Collections.Generic;
using System.Text;

namespace EntredaSaidaDate
{
    class ImprimirArquivo : ILerECriarArquivo
    {
        public void EnviarResultado(string[] datas)
        {
            foreach (var data in datas)
            {
                Console.WriteLine(data);
            }
        }
    }
}
