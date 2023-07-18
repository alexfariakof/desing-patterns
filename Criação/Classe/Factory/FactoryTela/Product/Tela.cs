using System;

namespace desing_patterns.create.FactoryMethod.Product
{
    public abstract class Tela
    {
        public ConsoleColor ForegroundColor { get; }
        private readonly string Message;
        
        public  Tela(ConsoleColor foregroundColor, string message)
        {
            ForegroundColor = foregroundColor;
            Message = message;
        }
        public string GetMessage()
        {
            return Message;
        }
    }
}
