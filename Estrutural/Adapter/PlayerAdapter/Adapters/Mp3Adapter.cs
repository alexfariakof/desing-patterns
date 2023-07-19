using PlayerAdapter.libs;

namespace PlayerAdapter.Adapters
{
    public class Mp3Adapter : IPlayer
    {
        public void Play(string file)
        {
            Mp3Player player = new Mp3Player(file);
            player.Run();
        }
    }
}