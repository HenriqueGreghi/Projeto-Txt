using System;
using System.Collections.Generic;
using System.IO;


namespace EntredaSaidaDate
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatarDatas = new FormatarData();
            formatarDatas.Converter();

            var listaDeExportacao = new List<ILerECriarArquivo>();
            listaDeExportacao.Add(new ImprimirArquivo());

            foreach (var exportacao in listaDeExportacao)
            {
                formatarDatas.Enviar(exportacao);
            }

            var criarArquivos = new List<ILerECriarArquivo>();
            criarArquivos.Add(new CriarArquivo());
            foreach (var arquivo in criarArquivos)
            {
                formatarDatas.Enviar(arquivo);
            }
        }
    }
}