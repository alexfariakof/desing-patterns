namespace TemplateMethodExample;
public class OrderByAssessment : OrdererTemplate
{
    protected override bool IsFirst(Movie movie1, Movie movie2)
    {
        return movie1.Assessment > movie2.Assessment;
    }
}
