using System.Collections;

namespace pair;

public class Party : IEnumerable<Hero>
{
    private List<Hero> party = [];

    public void Add(Hero hero)
    {
        party.Add(hero);
    }

    public void GetAllPlayers()
    {
        Console.WriteLine("All players: ");
        foreach (var hero in party)
        {
            Console.WriteLine(hero.ToString());
        }
    }

    public IEnumerable<Hero> GetAllAlivePlayers()
    {
        foreach (var hero in party.Where(hero => hero.State == "alive"))
        {
            yield return hero;
        }
    }

    public void SortByMoney()
    {
        foreach (var hero in party.OrderBy(hero => hero.Money))
        {
            Console.WriteLine($"{hero.Name} - {hero.Money}");
        }
    }

    public void GetMaxLvlHero()
    {
        var maxlvl = party.Max(hero => hero.Lvl);
        Console.WriteLine($"The max lvl in party is {maxlvl}");
    }
    
    public void GetAverageLvl()
    {
        double averagelvl = party.Average(hero => hero.Lvl);
        Console.WriteLine($"Average lvl in party is {averagelvl}");
    }
    
    public IEnumerator<Hero> GetEnumerator()
    {
        foreach (var hero in party)
        {
            yield return hero;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return party.GetEnumerator();
    }
}