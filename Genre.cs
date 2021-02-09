using System.IO;

namespace serendipia_playlist_generator
{
    class Genre
    {
        public string name;
        public string path;

        public Genre(string _name, string _path)
        {
            name = _name;
            path = _path;
        }

        public Genre(string _path)
        {
            name = getNameFromPath(_path);
            path = _path;
        }

        public string getNameFromPath(string _path)
        {
            return new DirectoryInfo(_path).Name;
        }
    }
}
