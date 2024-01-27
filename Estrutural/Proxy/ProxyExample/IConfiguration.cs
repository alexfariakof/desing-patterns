namespace ProxyExample;
public interface IConfiguration
{
    void Initialize();
    void Update();
    void SetConfig(string key, string value);
    string GetConfig(string key);
}