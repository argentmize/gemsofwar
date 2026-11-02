namespace gemsofwar.window
{
    public interface IImage
    {
        IGraphics Graphics { get;  }
        int Height { get; }
        int Width { get; }

        void MakeTransparent(RGBA color);
        void Save(string path);
    }
}
