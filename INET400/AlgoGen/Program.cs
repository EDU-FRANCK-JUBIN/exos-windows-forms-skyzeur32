using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;
using GAF.Extensions;
using GAF.Operators;

namespace AlgoGen
{
    class Program
    {
        private static List<City> cities;



        static void Main(string[] args)
        {



            cities = new List<City>
            {
                new City("Birmingham", 52.486125, -1.890507),
                new City("Bristol", 51.460852, -2.588139),
                new City("London", 51.512161, -0.116215),
                new City("Leeds", 53.803895, -1.549931),
                new City("Manchester", 53.478239, -2.258549),
                new City("Liverpool", 53.409532, -3.000126),
                new City("Hull", 53.751959, -0.335941),
                new City("Newcastle", 54.980766, -1.615849),
                new City("Carlisle", 54.892406, -2.923222),
                new City("Edinburgh", 55.958426, -3.186893),
                new City("Glasgow", 55.862982, -4.263554),
                new City("Cardiff", 51.488224, -3.186893),
                new City("Swansea", 51.624837, -3.94495),
                new City("Exeter", 50.726024, -3.543949),
                new City("Falmouth", 50.152266, -5.065556),
                new City("Canterbury", 51.289406, 1.075802)
            };




            var population = new Population();



            //create the chromosomes
            for (var p = 0; p < 100; p++)
            {



                var chromosome = new Chromosome();
                for (var g = 0; g < 16; g++)
                {
                    chromosome.Genes.Add(new Gene(g));
                }
                chromosome.Genes.ShuffleFast();
                population.Solutions.Add(chromosome);
            }

            foreach (Chromosome c in population.Solutions)
            {
                Console.WriteLine(c.Id);
                foreach (Gene g in c.Genes)
                {
                    Console.Write(g.RealValue);
                    Console.Write("  ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

            Elite elite = new Elite(5);
            Crossover c = new Crossover(0.8);
            SwapMutate swap = new SwapMutate(0.02);
            GeneticAlgorithm GA = new GeneticAlgorithm(population,);




        }
    }
}
