using Newtonsoft.Json;

namespace Flyweight;

// The Flyweight stores a common portion of the state (also called intrisic state)
// that belogns to multiple real business entities. The Flyweight accepts 
// the rest of the state (extrinsic state, unique for each entity ) via its methos parameters.

public class Flyweight
{

    private Car _sharedState;
    public Flyweight(Car sharedState)
    {
        _sharedState = sharedState;
    }
    public void Operation(Car uniqueState)
    {
        string s = JsonConvert.SerializeObject(this._sharedState);
        string u = JsonConvert.SerializeObject(uniqueState);
        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state. ");
    }
}