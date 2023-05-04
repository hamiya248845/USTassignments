using System;
using System.Collections.Generic;


namespace requirement_4
{
    class SongRepo
    {
        static List<Song> _songs = new List<Song>()
        {
            new Song("Shape of you" ,"Edsheeran" ,"Pop" ,4.8,12000,DateTime.Parse("12-04-2017")),
            new Song("Perfect", "Edsheeran" ,"Pop",4.5,120500,DateTime.Parse("06-08-2017")),
            new Song("Mercy" ,"Shawn Mendes" ,"Jazz" ,4.6,50000,DateTime.Parse("03-09-2016")),
            new Song("Something just like this","Coldplay","Melody",4.5,105421,DateTime.Parse("05-07-1997"))
        };

        public static List<Song> GetAllSongs()
        {
            return _songs;
        }

    }
    }

