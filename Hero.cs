namespace pair;

public class Hero
{
    public string Name { get; }
    public string Role { get; }
    public int Lvl { get; }
    public int HP { get; }
    public int Money { get; }
    public string State { get; }

    public Hero(string name, string role)
    {
        Name = name;
        Role = role;
        Lvl = new Random().Next(1, 50);
        HP = 100;
        Money = new Random().Next(100, 5000);
        State = "alive";
    }
}