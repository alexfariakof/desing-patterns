using System;

namespace desing_patterns.create.FactoryMethod.Product
{
    public class TelaSmartTV : Tela
    {
        public TelaSmartTV() : base(ConsoleColor.Yellow, "Bem vindo ;-) a Smart TV!")
        {
        }
    }
}