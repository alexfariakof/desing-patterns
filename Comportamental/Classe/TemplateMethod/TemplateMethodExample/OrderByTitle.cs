namespace TemplateMethodExample;
public class OrderByTitle : OrdererTemplate
{
    protected override bool IsFirst(Movie movie1, Movie movie2)
    {
        return (movie1.Title.CompareTo(movie2.Title) <= 0);
    }
}
