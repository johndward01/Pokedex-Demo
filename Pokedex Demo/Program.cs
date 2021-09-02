using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text.Json;

namespace Pokedex_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            // read the json file into a string
            var pokeFile = File.ReadAllText(@"C:\Users\johnd\Desktop\Repo\Pokedex Demo\Pokedex Demo\pokedex.json");

            var parsedPokeFile = JObject.Parse(pokeFile).GetValue("pokemon");

            foreach (var item in parsedPokeFile)
            {
                var info = JsonSerializer.Deserialize<Pokemon>(item.ToString());
                Console.WriteLine(info.name);
            }

        }
    }
}
