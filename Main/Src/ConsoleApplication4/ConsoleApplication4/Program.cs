using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
using System.Net.Mail;

namespace ConsoleApplication4
{
   
    class Program
    {
        private static ConcurrentDictionary<Guid, object> LockDic = new ConcurrentDictionary<Guid, object>();
        static void Main(string[] args)
        {

            //string a = "1";
            //string[] b = a.Split(',');

            //Console.WriteLine(b[0]);

            //Console.WriteLine("bug Fix11");
            //Console.WriteLine("bug Fix12");


            //Console.WriteLine("bug Fix13");
            //Console.WriteLine("bug Fix12");
            //Console.WriteLine("test");

            //Console.ReadLine();
            
            //This is a test
            string print = Console.ReadLine();
            Console.WriteLine(print);
            Console.WriteLine("Hello World");
            Console.WriteLine("string");
			
			//Hi
			//Yo
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }

    }
}
