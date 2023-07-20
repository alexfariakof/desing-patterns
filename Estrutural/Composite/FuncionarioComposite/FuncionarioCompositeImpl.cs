namespace FuncionarioComposite.Composite
{
    public class FuncionarioCompositeImpl : Funcionario
    {
        protected List<Funcionario> _childrem = new();
        public FuncionarioCompositeImpl(string _name) : base(_name)
        {
        }
        public override void Add(Funcionario component)
        {
            this._childrem.Add(component);
        }
        public override void Remove(Funcionario component)
        {
            this._childrem.Remove(component);
        }
        public override string Operation()
        {
            int i = 0;
            string result = $"Liderados de {this.Name} (";
            foreach(Funcionario component in this._childrem)
            {
                result += component.Name;
                if (i != this._childrem.Count - 1)
                {
                    result += ", ";
                }
                i++;
            }
            return result + ")";
        }
    }
}