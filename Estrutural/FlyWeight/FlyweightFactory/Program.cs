using Flyweight;
using Flyweight.Mock;

var mock = MockCar.CreateCars();
var factory = new FlyweightFactory(
    MockCar.GetFaker(),
    mock[0],
    mock[1],
    mock[3]
);


factory.ListFlyweights();

AddCarToPoliceDatabase(factory, mock[2]);
AddCarToPoliceDatabase(factory, mock[4]);

var newMock  = mock[4];
newMock.Owner = new Guid().ToString();

AddCarToPoliceDatabase(factory, newMock);

factory.ListFlyweights();

static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
{
    Console.WriteLine($"\nClient: Adding a car to database.");

    var flyweight = factory.GetFlyweight( new Car
    {
        Color = car.Color,
        Model = car.Model,
        Company  = car.Company,
    });

    flyweight.Operation(car);
}