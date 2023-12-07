namespace GA_Pokemon.ConsoleApp
{
    public class Trainer
    {
        public string TrainerName { get; set; }
        public string? CurrentPokemon { get; set; }
        public List<Pokemons> PokemonCollection { get; set; }
        public int Pokeballs { get; set; }
        public int HealthPotions { get; set; }


        //public void TrainerDescription(string trainerName, Pokemons startingPokemon)
        //{
        //    TrainerName = trainerName;
        //    CurrentPokemon = startingPokemon;
        //    PokemonCollection = new List<Pokemons> { startingPokemon };
        //    Pokeballs = 5;
        //    HealthPotions = 1;
        //}

        public void CatchAPokemon()
        {
            Console.WriteLine("Game stops here for the time being.");
            Console.WriteLine("Come back soon!");
        }

        public void FightAPokemon()
        {
            Random rand = new Random();
            Landscape landscapeInstance = new Landscape();

            Console.WriteLine("Vennligst velg:");
            Console.WriteLine("1. Stein");
            Console.WriteLine("2. Saks");
            Console.WriteLine("3. Papir");
            Console.WriteLine();

            var pokemonChoice = rand.Next(1, 3);
            var userChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string userChoiceText = "";
            string pokemonChoiceText = "";

            userChoiceText = ShowUserChoiceText(userChoice, userChoiceText);

            pokemonChoiceText = ShowPokemonChoiceText(pokemonChoice, pokemonChoiceText);

            Console.WriteLine($"(Trener) {userChoiceText} - {pokemonChoiceText} (Pokemon)");

            if (userChoice == '1' && pokemonChoice == 2 ||
                userChoice == '2' && pokemonChoice == 3 ||
                userChoice == '3' && pokemonChoice == 1)
            {
                Console.WriteLine("Woohoo! Du vant!");
                Console.WriteLine("Vil du prøve igjen? J/N");
                Console.WriteLine();
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "j")
                {
                    FightAPokemon();
                }
            }
            else if (pokemonChoiceText == userChoiceText)
            {
                Console.WriteLine("Uavgjort! Prøv igjen!");
                Console.WriteLine();
                FightAPokemon();
            }
            else
            {
                Console.WriteLine("Du tapte...");
                Console.WriteLine("POFF! Der forsvant Pokemonen også...");
                Console.WriteLine();
            }
        }

        private static string ShowPokemonChoiceText(int pokemonChoice, string pokemonChoiceText)
        {
            switch (pokemonChoice)
            {
                case 1:
                    pokemonChoiceText = "Stein";
                    break;
                case 2:
                    pokemonChoiceText = "Saks";
                    break;
                case 3:
                    pokemonChoiceText = "Papir";
                    break;
                default:
                    break;
            }

            return pokemonChoiceText;
        }

        private string ShowUserChoiceText(char userChoice, string userChoiceText)
        {
            switch (userChoice)
            {
                case '1':
                    userChoiceText = "Stein";
                    break;
                case '2':
                    userChoiceText = "Saks";
                    break;
                case '3':
                    userChoiceText = "Papir";
                    break;
                default:
                    Console.WriteLine("Vennligst velg 1, 2 eller 3.");
                    FightAPokemon();
                    break;
            }

            return userChoiceText;
        }

        public void GoToBeach()
        {
            Console.WriteLine("Game stops here for the time being.");
            Console.WriteLine("Come back soon!");
        }

        public void GoToForest()
        {
            Console.WriteLine("Game stops here for the time being.");
            Console.WriteLine("Come back soon!");
        }
    }
}
