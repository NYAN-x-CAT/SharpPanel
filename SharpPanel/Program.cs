using System;
using System.Net;
using System.IO;

/* 
       │ Author       : NYAN CAT
       │ Name         : SharpPanel v0.1
       │ Contact Me   : GitHub.com/NYAN-x-CAT

       This program is distributed for educational purposes only.
*/

namespace SharpPanel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "SharpPanel v0.1";

            //check internet connection
            if (!CheckInternet())
            {
                ConsoleHelper.Banner();
                ConsoleHelper.Info();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Please check your internet and try again");
                Console.ReadKey();
                return;
            }

            //check List.txt
            if (!File.Exists("List.txt"))
            {
                File.WriteAllText("List.txt", Properties.Resources.List);
            }

            ConsoleHelper.Banner();
            ConsoleHelper.Info();

            //check args or tell user to enter url
            string url = null;
            if (args.Length == 1)
            {
                url = args[0];
            }
            else
            {
                Console.WriteLine("\nEnter URL:");
                url = Console.ReadLine();
            }

            //check url
            if (string.IsNullOrWhiteSpace(url))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nurl is empty!\n");
                Console.ReadKey();
                return;
            }

            //make url valid
            if (!url.EndsWith("/")) url += "/";
            if (!url.ToLower().StartsWith("http")) url = "http://" + url;
            Console.WriteLine("\n");

            //loop for each line
            foreach (string line in File.ReadAllLines("List.txt"))
            {
                if (UrlIsValid(url + line))
                {
                    Console.WriteLine("press any key to continue..\n");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("End of List.txt");
            Console.ReadKey();
        }

        //check internet connection
        private static bool CheckInternet()
        {
            return UrlIsValid("https://google.com/");
        }

        //check head is OK 200
        private static bool UrlIsValid(string url)
        {
            bool urlExists = false;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 10000;
                request.Method = WebRequestMethods.Http.Head;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK) urlExists = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nURL:{url}    STATUS:FOUND!");
                Console.ResetColor();
            }
            catch
            {
                Console.WriteLine($"URL:{url}    STATUS:NOT FOUND");
            }
            return urlExists;
        }
    }
}
