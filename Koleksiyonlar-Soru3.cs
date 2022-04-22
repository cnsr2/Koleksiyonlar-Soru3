using System;
using System.Collections;
using System.Collections.Generic;
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümlenizi Giriniz.");
            string cümle = Console.ReadLine();
            string[] cümledizisi = new string[cümle.Count()];
            //string[] harfler = new string[8];
            ArrayList harfler = new ArrayList();
            foreach (var item in cümle)
            {
                if (item == 'ü' || item == 'u' || item == 'ö' || item == 'o' || item == 'i'|| item == 'ı' || item == 'e'|| item == 'a')
                {
                    harfler.Add(item.ToString());
                }
            }
            harfler.Sort();
            Console.WriteLine("Cümlenizdeki Sesli Harfler : ");
            foreach (var item in harfler)
                {
                    Console.WriteLine(item);
                }
        }
    }
