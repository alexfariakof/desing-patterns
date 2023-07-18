using System;

namespace desing_patterns.create.FactoryMethod.Product
{
    public class TelaSmartWatch : Tela
    {
        public TelaSmartWatch() : base(ConsoleColor.Red, ";-)")
        {
        }
    }
}