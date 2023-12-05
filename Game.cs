using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Pokemon.ConsoleApp
{
    internal class Game
    {
        public void PlayGame()
        {
            var PokemonsInstance = new Pokemons();

            Console.WriteLine("Hei, Coach!");
            Console.WriteLine("Hva heter du?");
            string CoachName = Console.ReadLine();

            Console.WriteLine($"Hei, {CoachName}!");
            Console.WriteLine("Hvilken Pokemon vil du starte spillet med?");
            Console.WriteLine();
            PokemonsInstance.PokemonCharacters();
            PokemonsInstance.ShowPokemons();
            Console.WriteLine();
            var StartingPokemon = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Du har valgt å begynne spillet med {StartingPokemon}!");
        }
    }
}
