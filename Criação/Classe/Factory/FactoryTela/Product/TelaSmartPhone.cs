using System;

namespace desing_patterns.create.FactoryMethod.Product
{
    public class TelaSmartPhone : Tela
    {
        public TelaSmartPhone() : base(ConsoleColor.Blue, "Bem vindo a Smart Phone!")
        {
        }
    }
}