namespace TemplateMethodExample;
public abstract class OrdererTemplate
{
    protected abstract bool IsFirst(Movie movie1, Movie movie2); // Operation()
    
    // Bubble Sort => O(N^2)
    public List<Movie> OrderMovie(List<Movie> movieList) // TemplateMethod()
    {
        for (int i = 0; i < movieList.Count; i++)
        {
            for (int j = i+1; j < movieList.Count; j++)
            {
                if (!IsFirst(movieList[i], movieList[j]))
                {
                    Movie temp = movieList[j];
                    movieList[j] = movieList[i];
                    movieList[i] = temp;
                }
            } 
        }
        return movieList;
    }
}