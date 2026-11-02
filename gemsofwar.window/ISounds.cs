using System.IO;

namespace gemsofwar.window
{
    public interface ISounds
    {
        void Play(string path);
        void Play(string name, Stream stream);
        void PlayMusic(string path, bool repeat);
        void Repeat();
    }
}
