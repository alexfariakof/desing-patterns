using Bogus;

namespace Flyweight.Mock;
public class MockCar
{
    public static Car GetFaker()
    {
        var fakeCar = new Faker<Car>()
            .RuleFor(c => c.Owner, f => f.Person.FullName)
            .RuleFor(c => c.Number, f => f.Random.AlphaNumeric(8))
            .RuleFor(c => c.Company, f => f.Company.CompanyName())
            .RuleFor(c => c.Model, f => f.Vehicle.Model())
            .RuleFor(c => c.Color, f => f.Commerce.Color())
            .Generate();


        return fakeCar ?? null;
    }

    public static List<Car> CreateCars()
    {
        var cars = new List<Car>();

        cars.AddRange(Enumerable.Repeat(CreateCar("Model1", "Company1"), 2));
        cars.AddRange(Enumerable.Repeat(CreateCar("Model2", "Company2", "Color1"), 3));

        return cars;
    }

    private static Car CreateCar(string model, string company, string color = "")
    {
        var car = new Car
        {
            Model = model,
            Company = company,
            Owner = Guid.NewGuid().ToString(), 
            Number = Guid.NewGuid().ToString(),
            Color = color
        };

        return car;
    }
}
