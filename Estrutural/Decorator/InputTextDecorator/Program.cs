using InputTextDecorator;
using System.Text;

string filePath = $"{GetRootPath()}\\testDecoratorStream.txt";
Console.WriteLine("Hello, World! Input Text Decorator");
Console.WriteLine("");

using (Stream inputText =
    new LowerCaseInputStream(
    new BufferedStream(
        new FileStream(filePath, FileMode.Open)
        )))
{
    try
    {
        byte[] buffer = new byte[inputText.Length];
        int bytesRead = inputText.Read(buffer, 0, buffer.Length);

        //string fileContent = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim('\uFEFF');
        string isocontent = Encoding.GetEncoding("ISO-8859-1").GetString(buffer, 0, bytesRead);
        byte[] isobytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(isocontent);
        byte[] ubytes = Encoding.Convert(Encoding.GetEncoding("ISO-8859-1"), Encoding.Unicode, isobytes);
        string fileContent = Encoding.Unicode.GetString(ubytes, 0, ubytes.Length);
        Console.WriteLine("File Content:");
        Console.WriteLine(fileContent);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Arquivo não pode ser lido!");

    }
    finally
    {
        inputText.Close();
    }
};

static string GetRootPath()
{
    string currentDirectory = Directory.GetCurrentDirectory();

    while (!File.Exists(Path.Combine(currentDirectory, "InputTextDecorator.csproj")))
    {
        currentDirectory = Directory.GetParent(currentDirectory).FullName;
    }

    return currentDirectory;
}