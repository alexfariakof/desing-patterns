using PlayerAdapter.Adapters;

string? file = Console.ReadLine();

var fileExtension = file.Split(".");

IPlayer player;

switch (fileExtension[1].ToString())
{
    case "mp3":
        {
            player = new Mp3Adapter();
            player.Play(file);
            break;
        }
    case "mp4":
        {
            player = new Mp4Adapter();
            player.Play(file);
            break;
        }
    default:
        {
            Console.WriteLine("Midia incompativél!");
            break;
        }
}