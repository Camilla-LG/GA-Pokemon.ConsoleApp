namespace GA_Pokemon.ConsoleApp;

public class Landscape
{
    public string Mountain;
    public string Beach;
    public string Forest;
        
    

    public void SearchMountain()
    {
        var PokemonsInstance = new Pokemons();
        Random random = new Random();

        Console.WriteLine("Fjelltoppene er så store og snødekte. Vil du klatre opp for å lete? J/N");
        var MountainAnswer = Console.ReadLine();

        if (MountainAnswer.ToLower() == "j")
        {
            var randomMountainPokemon = PokemonsInstance.GetRandomPokemon("Mountain");
            Console.WriteLine($"Det er jo {randomMountainPokemon.Name}!");
        }
    }
}