using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            bool isFilling = false;
            Dictionary<string, Trainers> trainerz = new Dictionary<string, Trainers>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Tournament") { 
                    isFilling = true;
                    continue;
                }

                if (!isFilling)
                {
                    string[] informateMe = input
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                    if (!trainerz.Keys.Contains(informateMe[0]))
                    {
                        Trainers trainer = new(informateMe[0]);
                        Pokemon pokemon = new(informateMe[1], informateMe[2], int.Parse(informateMe[3]));
                        trainer.AddPokemonIntoCollection(pokemon);
                        trainerz.Add(informateMe[0],trainer);
                    }
                    else 
                    {
                        Pokemon pokemon = new(informateMe[1], informateMe[2], int.Parse(informateMe[3]));
                        trainerz[informateMe[0]].AddPokemonIntoCollection(pokemon);

                    }
                    
                    

                }

                if (input != "End" && isFilling)
                {
                    foreach (var person in trainerz)
                    {
                        person.Value.Checker(input);
                    }
                    
                }
                if (input == "End")
                {
                    List<Trainers> filtered = new();
                    filtered = trainerz.Values.OrderByDescending(t => t.Badges).ToList();

                    foreach (var person in filtered)
                    {
                        Console.WriteLine($"{person.Name} {person.Badges} {person.Creatures.Count}");
                    }


                    break;
                }

            }



            

        }



    }
}
