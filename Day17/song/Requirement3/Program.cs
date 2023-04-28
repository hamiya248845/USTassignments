using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name\t Artist\t SongType\t Rating\t No.Of Downloads\t Date of Download");
            List<Song> ls = SongRepo.GetAllSongs();
            foreach (Song s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("enter the type");
            string type = Console.ReadLine();
            List<Song> songs = new List<Song>();
            List<Song> songbytype = songs.FindSong(ls, type);
            Console.WriteLine(songbytype);

        }
    }
}
