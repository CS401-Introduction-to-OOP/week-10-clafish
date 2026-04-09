namespace pair;

public class Hero
{
    public string Name { get; }
    public string Role { get; }
    public int Lvl { get; set; }
    public int HP { get; set; }
    public int Money { get; set; }
    public string State { get; set; }

    public Hero(string name, string role)
    {
        Name = name;
        Role = role;
        Lvl = new Random().Next(1, 50);
        HP = 100;
        Money = new Random().Next(100, 5000);
        State = "alive";
    }

    public override string ToString()
    {
        return $"Name - {Name} " +
               $"Role - {Role}" +
               $"Lvl - {Lvl}" +
               $"HP - {HP}" +
               $"Money - {Money}";
    }
}