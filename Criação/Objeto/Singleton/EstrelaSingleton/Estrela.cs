namespace EstrelaSingleton
{
    public class Estrela
    {
        private static Estrela? Instance;

        private Estrela() { }

        public static Estrela GetInstance
        {
            get
            {
                return Instance == null ? new() : Instance;
            }
        }
        public void PrintEstrela()
        {
            Console.WriteLine("O Sol é uma Estrala.");
        }
    }
}