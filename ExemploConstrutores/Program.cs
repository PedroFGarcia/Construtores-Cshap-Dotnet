using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            //data.SetMes(13);

            data.Mes = 13;
            System.Console.WriteLine(data.Mes);

            data.ApresentarMes();

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste Instancia";

            // Log log2 = Log.GetInstance();
            // Console.WriteLine(log2.PropriedadeLog);

            // Aluno p1 = new Aluno("Pedro","Garcia","Testes");
            // p1.Apresentar();
        }
    }
}