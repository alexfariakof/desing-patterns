namespace FuncionarioComposite.Composite
{
    public abstract class Funcionario
    {
        public string Name { get; set; }
        public Funcionario(string _name) 
        { 
            Name = _name;
        }
        public abstract string Operation();

        public virtual void Add(Funcionario component) 
        { 
            throw new NotImplementedException();
        }
        public virtual void Remove(Funcionario component) 
        { 
            throw new NotImplementedException();
        }
        public virtual Funcionario Get(int index)
        {
            throw new NotImplementedException();
        }
    }
}