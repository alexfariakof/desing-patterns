using PlayerAdapter.libs;

namespace PlayerAdapter.Adapters
{
    public class Mp4Adapter : IPlayer
    {
        public void Play(string file)
        {
            Mp4Player player = new Mp4Player(file);
            player.Start();
        }
    }
}