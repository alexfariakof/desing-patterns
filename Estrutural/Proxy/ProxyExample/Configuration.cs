namespace ProxyExample;
public class Configuration : IConfiguration
{
    public void Initialize()
    {
        Console.WriteLine("Configurações Inicializada!");
    }
    public void Update()
    {
        Console.WriteLine("Configurações Atualizada !");
    }
    public void SetConfig(string key, string value)
    {
        Console.WriteLine($"Configurações registradas => { key }:{value}");
    }
    public string GetConfig(string key)
    {
        Random random = new();
        return $"Valor da Configuração {key} é: {random.NextInt64()}.";
    }
}