using TemplateMethodExample;

Console.WriteLine("Hello, Template Method!");

Movie m1 = MockMovie.GetFaker();
Movie m2 = MockMovie.GetFaker();
Movie m3 = MockMovie.GetFaker();
Movie m4 = MockMovie.GetFaker();

List<Movie> list = new() { m1, m2, m3, m4 };

OrdererTemplate order;

order = new OrderByTitle();
var movies = order.OrderMovie(list);


Console.WriteLine("\nOrdenação por título");
PrintMovies(movies);

order = new OrderByAssessment();
movies = order.OrderMovie(list);

Console.WriteLine("\nOrdenação por Avaliação");
PrintMovies(movies);



void PrintMovies(List<Movie> movies)
{
    foreach (var movie in movies)
        Console.WriteLine($"{movie.Id} - {movie.Title} - {movie.Year} => {movie.Assessment}");
}

