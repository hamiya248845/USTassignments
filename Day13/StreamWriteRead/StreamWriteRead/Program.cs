using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriteRead
{
    class Program
    {
        static string file = @"";
        static void Main()
        {
            Write();
            Read();
        }
        static void Write()
        {
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine("dhffncghgj");
            fileStream.WriteLine("hgdfgjhhdc");
            fileStream.Close();
        }
        static void Read()
        {
            StreamReader fileStream = new StreamReader(file);
            string s = null;
            w
        }
    }
}
