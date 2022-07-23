using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_cSharp_deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            int patika1 = 0;
            string degisken = null;
            Console.WriteLine(deger);
            byte b = 3; // 1 byte
            short s = 4; // 2 byte

            Int16 i16= 5; // 2 byte

            Int32 i32= 6;   
            Int64 i64= 7;   

            uint u = 8;
            long l = 9;

            float f = 10; // 4 byte
            double d = 11;  // 8 byte
            decimal c = 12; // 16 byte



            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            

            object obj = null;  
            object obj1 = "5";


            string ad = "tahsin";
            string soyad = "tayır";
            string tamisim= ad + " " +soyad;
            


            bool bool1 = 10 < 4;
            Console.WriteLine(bool1);


            int sayi = 3;
            string yazi = "5";
            int birlesim = sayi + Convert.ToInt32(yazi);
            Console.WriteLine(birlesim);
            Console.ReadLine();

            string dateTime2 = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
