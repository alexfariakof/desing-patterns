namespace ProxyExample;
public class ConfigurationProxy : IConfiguration
{
    private Configuration config = new Configuration();
    public void Initialize()
    {
        config.Initialize();
    }
    void IConfiguration.Update()
    {
        config.Update();
    }
    public void SetConfig(string key, string value)
    {
        config.SetConfig(key, value);
        config.Update();
    }
    public string GetConfig(string key)
    {
        return config.GetConfig(key);
    }
}
