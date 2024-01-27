using Bogus;

namespace TemplateMethodExample;
public class MockMovie
{
    public static Movie GetFaker()
    {
        var faker = new Faker<Movie>()
            .RuleFor(m => m.Id, f => f.Random.Guid())
            .RuleFor(m => m.Title, f => f.Random.Word())
            .RuleFor(m => m.Year, f => f.Random.Number(1900, 2024))
            .RuleFor(m => m.Assessment, f => f.Random.Double(1, 10));

        return faker.Generate();
    }
}
