namespace pair;

public class Event
{
    public int Move;
    public string Description { get; }
    public string Type { get; }
    public int CharacteristicChange { get; }

    public Event(string description, string type)
    {
        Description = description;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Description}";
    }

    public void Die(Hero hero)
    {
        hero.State = "dead";
    }

    public void Revive(Hero hero)
    {
        hero.State = "alive";
    }

    public void EarnMoney(Hero hero)
    {
        hero.Money += 1000;
    }
}