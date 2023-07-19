namespace PlayerAdapter.libs
{
    public class Mp4Player
    {
        private string? File = "";
        public Mp4Player() { } 
        public Mp4Player(string file)
        {
            this.File = file;
        }
        public void Start()
        {
            Console.WriteLine($"Executando arquivo Mp4: { File }");
        }
    }
}