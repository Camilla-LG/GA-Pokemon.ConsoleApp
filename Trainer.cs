namespace GA_Pokemon.ConsoleApp
{
    internal class Trainer
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
    }
}
