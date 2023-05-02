using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    class SongBO
    {
        private DateTime date;
        private double rating;

        public SongBO(List<Song> ls, string type)
        {
            Ls = ls;
            Type = type;
        }

        public SongBO(List<Song> ls, DateTime date)
        {
            Ls = ls;
            this.date = date;
        }

        public SongBO(List<Song> ls, double rating)
        {
            Ls = ls;
            this.rating = rating;
        }

        public List<Song> Ls { get; }
        public string Type { get; }

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
