namespace GA_Pokemon.ConsoleApp;

public class Landscape
{
    public string Mountain;
    public string Beach;
    public string Forest;
    Trainer trainer = new Trainer();
        

    public void SearchMountain()
    {
        var PokemonsInstance = new Pokemons();
        Random random = new Random();

        Console.WriteLine("Fjelltoppene er så store og snødekte. Vil du klatre opp for å lete? J/N");
        var MountainAnswer = Console.ReadLine();

        if (MountainAnswer.ToLower() == "j")
        {
            var randomMountainPokemon = PokemonsInstance.ShowRandomPokemon("Mountain");
            Console.WriteLine($"Det er jo {randomMountainPokemon.Name}!");
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine();
            MountainChoices();

            var userChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            RunMountainChoices(userChoice);
        }
        else
        {
            Console.WriteLine("Her er det ingen fjell-Pokemoner i sikte.");
        }
    }

    public void MountainChoices()
    {
        Console.WriteLine("1. Prøve å fange den.");
        Console.WriteLine("2. Slåss mot den.");
        Console.WriteLine("3. Stikk til stranda for å se etter andre Pokemon.");
        Console.WriteLine("4. Stikk til skogs for å se etter andre .");
    }

    public void RunMountainChoices(char userChoice)
    {
        switch (userChoice)
        {
            case '1':
                trainer.CatchAPokemon();
                break;
            case '2':
                trainer.FightAPokemon();
                break;
            case '3':
                trainer.GoToBeach();
                break;
            case '4':
                trainer.GoToForest();
                break;
            default:
                break;
        }
    }

}