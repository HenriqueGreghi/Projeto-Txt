using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EntredaSaidaDate
{
    class FormatarData
    {
       
        private string[] _datas;
        private  DateTime LerArquivo()
        {

           return DateTime.Parse(File.ReadAllLines( @"C:\Projeto\Entrada-de-Data.txt")[0]);
           
        }
        private string[] ConverterDatas(DateTime data)
        {

            return new string[]
              {
                data.ToString("MM/dd/yy"),
                data.ToString("yy/MM/dd"),
                data.ToString("dd-MM-yy")
            };


        }
        public void Converter()
        {
            var data = LerArquivo();
            _datas = ConverterDatas(data);
        }
        public void Enviar(ILerECriarArquivo lerECriarArquivo)
        {
            lerECriarArquivo.EnviarResultado(_datas);
        }
    }
}
