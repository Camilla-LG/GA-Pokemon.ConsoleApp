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
            var TrainerInstance = new Trainer();
            var ProgramInstance = new Program();

            Console.WriteLine("Hei, Coach!");
            Console.WriteLine("Hva heter du?");
            TrainerInstance.TrainerName = Console.ReadLine();

            Console.WriteLine($"Hei, {TrainerInstance.TrainerName}!");
            Console.WriteLine("Hvilken Pokemon vil du starte spillet med?");
            Console.WriteLine();
            PokemonsInstance.PokemonCharacters();
            PokemonsInstance.ShowPokemons();
            Console.WriteLine();
            TrainerInstance.CurrentPokemon = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Du har valgt å begynne spillet med {TrainerInstance.CurrentPokemon}!");
        }
    }
}
