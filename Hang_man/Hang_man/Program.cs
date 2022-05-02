using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Threading;


namespace Hang_man
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game HangMan \nThis is a test game and you have infinite lives");
            Api.WebApi()
                .Wait();
           

        }
   
    }
}

      