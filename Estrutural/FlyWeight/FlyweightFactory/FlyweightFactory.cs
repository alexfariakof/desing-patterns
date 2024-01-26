namespace Flyweight;

public  class FlyweightFactory
{

    private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();
    public FlyweightFactory(params Car[] args)
    {
        foreach(var elem in args)
        {
            flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.getKey(elem)));
        }
    }

    // Returns FlyWieght's string hash for a given state.
    public string getKey(Car key)
    {
        List<string> elements = new List<string>();

        elements.Add(key.Model);
        elements.Add(key.Color);
        elements.Add(key.Company);

        if (key.Owner != null && key.Number != null)
        {
            elements.Add(key.Owner);
            elements.Add(key.Number);
        }

        elements.Sort();

        return string.Join("_", elements);
    }

    // Returns an existing flyweight with given state or cerate a new one
    public Flyweight GetFlyweight(Car sharedState)
    {
        string key = this.getKey(sharedState);

        if (flyweights.Where(t => t.Item2 == key).Count()  == 0) 
        {
            Console.WriteLine($"FlyweightFactory: Can't find a Flyweight, creating new one.");
            this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine($"FlyweightFactory: Reusing existing flywieght..");
        }
        return flyweights.FirstOrDefault(t => t.Item2 == key).Item1;
    }

    public void ListFlyweights()
    {
        var count = flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights: ");

        foreach( var flyweight in flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}