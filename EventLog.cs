using System.Collections;

namespace pair;

public class EventLog : IEnumerable<Event>
{
    private List<Event> eventLog = [];

    public void Add(Event event1)
    {
        eventLog.Add(event1);
    }

    public void GetGoodEvents()
    {
        var goodEvents = eventLog.Where(event1 => event1.Type == "good");
        foreach (var Event in goodEvents)
        {
            Console.WriteLine(Event.ToString());
        }
    }
    
    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var Event in eventLog)
        {
            yield return Event;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return eventLog.GetEnumerator();
    }
}