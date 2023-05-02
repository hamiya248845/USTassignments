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
            string Type = Console.ReadLine();

            SongBO s1=new SongBO(ls,Type);
           
            List<Song> songtype = s1.FindSong(ls, Type);

            Console.WriteLine("SongName\tType");
            foreach (Song s in songtype)
            {
                Console.Write(s.Name+"\t");
                Console.WriteLine(s.SongType);
            }

            Console.WriteLine("enter the DATE");
            DateTime date = DateTime.Parse(Console.ReadLine());

            SongBO s2 = new SongBO(ls, date);

            List<Song> songdate = s2.FindSong(ls, date);

            Console.WriteLine("SongName\tDate");
            foreach (Song s in songdate)
            {
                Console.Write(s.Name + "\t");
                Console.WriteLine(s.DateDownloaded);
            }


            Console.WriteLine("enter the Rating");
            double rating = double.Parse(Console.ReadLine());

            SongBO s3 = new SongBO(ls, rating);

            List<Song> songrating = s3.FindSong(ls, rating);

            Console.WriteLine("SongName\tRating");
            foreach (Song s in songrating)
            {
                Console.Write(s.Name + "\t");
                Console.WriteLine(s.Rating);
            }


        }
    }
}
