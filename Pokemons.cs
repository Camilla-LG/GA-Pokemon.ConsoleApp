using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Pokemon.ConsoleApp
{
    internal class Pokemons
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public List<Pokemons> AllPokemons { get; set; }

        public void PokemonCharacters()
        {
            AllPokemons = new List<Pokemons>
            {
                new Pokemons{Name = "Pikachu", Health = 50},
                new Pokemons{Name = "Bulbasaur", Health = 50},
                new Pokemons{Name = "Charmander", Health = 50},
                new Pokemons{Name = "Rattata", Health = 50},
                new Pokemons{Name = "Squirtle", Health = 50},
                new Pokemons{Name = "Butterfree", Health = 50},
            };
        }

        public void ShowPokemons()
        {
            foreach (var pokemon in AllPokemons)
            {
                Console.WriteLine($"{pokemon.Name} - Health: {pokemon.Health}");
            }
        }
    }
}
