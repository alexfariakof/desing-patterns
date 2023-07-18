using System;

namespace desing_patterns.create.FactoryMethod.Product
{
    public class TelaWeb : Tela
    {
        public TelaWeb() : base(ConsoleColor.Green, "Bem vindo!")
        {
        }
    }
}