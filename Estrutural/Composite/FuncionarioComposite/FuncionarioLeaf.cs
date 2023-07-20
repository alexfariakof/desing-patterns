namespace FuncionarioComposite.Composite
{
    public class FuncionarioLeaf : Funcionario
    {
        public FuncionarioLeaf(string _name) : base(_name) { }
        public override string Operation()
        {
            return "Leaf";
        }
    }
}