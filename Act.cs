using System.Collections.Generic;

namespace milonga_generator
{
    public class Act
    {
        // path of the folder where the songs of the act are
        public string path { get; private set; }

        // name of the folder's act
        public string name { get; private set; }

        public Act (string _path)
        {
            path = _path;
            name = MusicFolder.getLastFolderName(_path);
        }

        public static string parseToString(List<Act> list)
        {
            string parsed = "";

            if (list.Count > 0)
            {
                foreach (Act current in list)
                {
                    // use "?" as delimiter between paths;
                    parsed += current.path + "?";
                }

                // remove the last delimiter
                parsed = parsed.Substring(0, parsed.Length - 1);
            }
            else
            {
                // this will be used when there is no items in the list
                parsed = "?";
            }

            return parsed;
        }

        public static List<Act> parseToList(string parsed)
        {
            List<Act> list = new List<Act>();
            if (parsed != "?")
            {
                foreach (string path in parsed.Split('?'))
                {
                    list.Add(new Act(path));
                }
            }

            return list;
        }
    }
}
