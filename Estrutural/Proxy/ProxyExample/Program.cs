using ProxyExample;

Console.WriteLine("Hello, Proxy !");

ConfigurationProxy proxy = new();

proxy.Initialize();

proxy.SetConfig("Key-001", "Teste-01");

Console.WriteLine(proxy.GetConfig("Key-001"));