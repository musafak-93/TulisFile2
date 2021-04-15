using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TulisFile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 x;
            try
            {
                //Buka File
                StreamWriter sw = new StreamWriter("D:\\Tugas\\SEMESTER 6\\Botcamp Pengembangan Aplikasi\\Project\\Test1.txt", true, Encoding.ASCII);
                //Tulis bilangan 0 sampai 9 dalam satu baris
                for (x = 0; x < 10; x++)
                {
                    sw.Write(x);
                }
                //Tutup file nya
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
