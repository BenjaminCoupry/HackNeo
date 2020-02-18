using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace HackNeo
{
    class Program
    {
        internal static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Random rnd = new Random();
            string Pct = "0";
            for (int i = 0; i < 100; i++)
            {
                
                Pct = Convert.ToString(i) + "%";
                Console.Clear();Console.WriteLine("Launching System");
                Console.WriteLine(Pct);
                System.Threading.Thread.Sleep(10);
                
            }
            Console.Clear();
            Console.WriteLine("Start Connection");
            for (int i = 0; i < 4; i++)
            {
                Pct = ".";
                Console.Write(Pct);
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine("Get Ellyptic Enteries");
            System.Threading.Thread.Sleep(500);
            
            for (int i = 0; i < 50; i++)
            {
            Console.WriteLine(GetStringSha256Hash(Convert.ToString(rnd.Next(1, 100))));
            System.Threading.Thread.Sleep(60);
            }
            Console.Clear();
            Console.WriteLine("Get Software Keys");
            System.Threading.Thread.Sleep(500);
            for (int i = 0; i < 350; i++)
            {
                Console.Write(Convert.ToString(rnd.Next(1, 1000000000)));
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine("DONE");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Thread Hacking process");
            System.Threading.Thread.Sleep(800); Console.WriteLine("---HFX.P325---");
            for (int i = 300; i > 0; i--)
            {

                Pct = Convert.ToString(i) + " Unloaded";
                Console.WriteLine(Pct);
                System.Threading.Thread.Sleep(1);

            }
            Console.Clear();
            
            System.Threading.Thread.Sleep(500);
            Random rand = new Random();
            for (int i = 50; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine("Redondance_Finding Tester v2.4.9");
                long q = rand.Next(900000000) + rand.Next(900000000) + rand.Next(900000000) + rand.Next(900000000) + rand.Next(900000000) + rand.Next(900000000)+1000000000000000;
                 Console.WriteLine(q);
                 System.Threading.Thread.Sleep(50);
            }
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("New User Crack");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("OK!");
            Console.WriteLine("Open folderKiller");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("OK!");
            Console.WriteLine("Rooting access");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("OK!");
            Console.WriteLine("Inverting Passwords");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("OK!");
            Console.WriteLine("HDM security deletion ...");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Found!");
            Console.WriteLine("MMPS v5");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("OK!");
            Console.WriteLine("MMPS v9.2");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("OK!");
            Console.WriteLine("Ellyptic Decyfrer");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("OK!");
            Console.WriteLine("ORL_qqdr KeyLoaderOn");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("OK!");
            Console.WriteLine("Register Guardian v1.9.9.78");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("OK!");
            System.Threading.Thread.Sleep(550);
            Console.Clear();
            Console.WriteLine("Digitalizer");
            System.Threading.Thread.Sleep(500);
            for (int ii = 0; ii < 10; ii++)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("9");
                }
                Console.Write(Environment.NewLine);
            }
            Random randa = new Random();
            for (int i = 0; i < 100; i++)
            {
                int r1 = randa.Next(20);
                int r2 = randa.Next(10);
                int r3 = randa.Next(9);
                int r = randa.Next(10); Console.SetCursorPosition(r1, r2);
                if (r <8)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine(r3);
                }
                System.Threading.Thread.Sleep(50);
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("DONE");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
        }
    }
}
