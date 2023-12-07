using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Pokemon.ConsoleApp
{
    public class Pokemons
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public string Type { get; set; }
        public static List<Pokemons> AllPokemons { get; set; } = new List<Pokemons>();
        public static object RandomMountainPokemon { get; internal set; }

        //public Pokemons() 
        //{
        //    AllPokemons = new List<Pokemons>();
        //}

        public void PokemonCharacters()
        {
            AllPokemons = new List<Pokemons>
            {
                new Pokemons{Name = "Pikachu", Health = 50, Type = "Beach"},
                new Pokemons{Name = "Crabby", Health = 50, Type = "Beach"},
                new Pokemons{Name = "Lotad", Health = 50, Type = "Beach"},
                new Pokemons{Name = "Squirtle", Health = 50, Type = "Beach"},
                new Pokemons{Name = "Rattata", Health = 50, Type = "Forest"},
                new Pokemons{Name = "Butterfree", Health = 50, Type = "Forest"},
                new Pokemons{Name = "Kakuna", Health = 50, Type = "Forest"},
                new Pokemons{Name = "Pidgeotto", Health = 50, Type = "Forest"},
                new Pokemons{Name = "Mankey", Health = 50, Type = "Mountain"},
                new Pokemons{Name = "Lucario", Health = 50, Type = "Mountain"},
                new Pokemons{Name = "Sawk", Health = 50, Type = "Mountain"},
            };
        }

        public void ShowPokemons()
        {
            foreach (var pokemon in AllPokemons)
            {
                Console.WriteLine($"{pokemon.Name} - Health: {pokemon.Health}");
            }
        }

        public Pokemons ShowRandomPokemon(string type)
        {
            var random = new Random();
            var PokemonsOfType = AllPokemons.Where(p => p.Type == type).ToList();

            if (PokemonsOfType.Any())
            {
                int randomIndex = random.Next(0, PokemonsOfType.Count);
                return PokemonsOfType[randomIndex];
            } 
            else
            {
                Console.WriteLine("Det ser ikke ut til at det er noen Pokemon som vil vise seg her.");
                return null;
            }
        }
    }
}
