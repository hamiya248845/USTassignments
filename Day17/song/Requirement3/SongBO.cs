using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    class SongBO
    {
        public List<Song> FindSong(List<Song> SongList, string type)
        {
            List<Song> fs = new List<Song>();
            foreach (Song s in SongList)
            {
                if (s.SongType == type)
                {
                    fs.Add(s);
                }
            }
            return fs;
        }
        public List<Song> FindSong(List<Song> SongList, DateTime dateCreated)
        {
            List<Song> fs1 = new List<Song>();
            foreach (Song s in SongList)
            {
                if (s.DateDownloaded == dateCreated)
                {
                    fs1.Add(s);
                }
            }
            return fs1;
        }
        public List<Song> FindSong(List<Song> SongList, double rating)
        {
            List<Song> fs2 = new List<Song>();
            foreach (Song s in SongList)
            {
                if (s.Rating == rating)
                {
                    fs2.Add(s);
                }
            }
            return fs2;
        }
    }
}
