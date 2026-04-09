using pair;

var mage = new Hero("Andrew", "mage");
var archer = new Hero("Pavlo", "archer");

var party = new Party() {mage, archer};
var eventlog = new EventLog();

List<string> possibleEvents = new List<string>() { "kill", "revive", "earnmoney" };

Console.WriteLine("Choose your class: " +
                  " 1. Mage");

if (Console.ReadLine() == "1")
{
    Console.WriteLine("Poor mage entered this world and found his rich friend archer");
    mage.Money = 0;
    archer.Money = 10000;
    mage.Lvl = 10;
    archer.Lvl = 100;
    eventlog.Add(new Event("Mage entered this world", "neutral"));
}

Console.WriteLine("Choose your path: " +
                  " 1. Darkwoods" +
                  " 2. River" +
                  " 3. Church");

var respond = Console.ReadLine();
if (respond == "1")
{
    Console.WriteLine("Mage went to darkwoods and died");
    eventlog.Add(new Event("Mage went to darkwoods and died", "bad"));
    new Event("Mage went to darkwoods and died", "bad").Die(mage);
}
else if (respond == "2")
{
    Console.WriteLine("Mage went to river and found treasure");
    eventlog.Add(new Event("Mage went to river and found treasure", "good"));
    new Event("Mage went to river and found treasure", "good").EarnMoney(mage);
}
else
{
    Console.WriteLine("Mage went to town but was killed by robbers. Citizen brought him to church and he was revived");
    eventlog.Add(new Event("Mage went to town but was killed by robbers. Citizen brought him to church and he was revived", "good"));
    new Event("Mage went to town but was killed by robbers. Citizen brought him to church and he was revived", "good").Revive(mage);
}

Console.WriteLine("Campaign result: ");
Console.WriteLine("Good events: ");
eventlog.GetGoodEvents();
Console.WriteLine();
party.SortByMoney();
party.GetRoles();
