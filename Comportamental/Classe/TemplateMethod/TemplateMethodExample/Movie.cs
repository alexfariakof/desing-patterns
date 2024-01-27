namespace TemplateMethodExample;
public class Movie
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public double Assessment { get; set; }

    public Movie() { }
    public Movie(Guid id, string title, int year, double assessment)
    {
        Id = id;
        Title = title;
        Year = year;
        Assessment = assessment;
    }
}