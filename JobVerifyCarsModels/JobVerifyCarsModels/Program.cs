using System;
using System.Linq;

namespace JobVerifyCarsModels
{
    class Program
    {
        static void Main(string[] args)
        {
            Context.Context context = new Context.Context();

            var listCarros = context.Carros.ToList();
            var i = 0;

            Console.WriteLine("Job iniciado, por favor, aguarde ... ");

            foreach (var carro in listCarros)
            {
                var listModels = context.AnoModeloCarros.Where(x => x.CarroId == carro.CarroId).ToList();

                if (listModels.Count == 0)
                {
                    Console.WriteLine("ID: {0}, Carro: {1}", carro.CarroId, carro.Nome);
                    i++;
                }
            }

            Console.WriteLine("Há {0} carros sem modelo/ano em seu banco de dados", i);
            Console.ReadLine();
        }
    }
}