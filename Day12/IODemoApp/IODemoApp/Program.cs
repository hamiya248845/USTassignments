using System;
using System.IO;

namespace IODemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dif= new DirectoryInfo(@"D:\dotnet\Day12\FileDemo");


            //Console.WriteLine("***** Directory Info *****\n");

            //DirectoryInfo dir = new DirectoryInfo(@"D:\dotnet\Day12\FileDemo");

            //Console.WriteLine("FullName: {0}", dir.FullName);

            //Console.WriteLine("Name: {0}", dir.Name);

            //Console.WriteLine("Parent: {0}", dir.Parent);

            //Console.WriteLine("Creation: {0}", dir.CreationTime);

            //Console.WriteLine("Attributes: {0}", dir.Attributes);

            //Console.WriteLine("Root: {0}", dir.Root);

            //Console.WriteLine("**************************\n");

            //make a new file on the E drive


            FileInfo f2 = new FileInfo(@"D:\dotnet\Day12\FileDemo\Test.dat");
            FileStream f=f2.Create();


            //DriveInfo[] myDrives=DriveInfo.GetDrives();
        }
    }
}
