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

    public void Heal(Party party)
    {
        party.Select(hero => hero.HP = 100);
    }
}