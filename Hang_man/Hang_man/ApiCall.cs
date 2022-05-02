using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Threading;

namespace Hang_man
{
    public class Api
    {
        public static async Task WebApi()
        {
            using (var client = new HttpClient())
            {
                //Settting BaseURI and Headers
                client.BaseAddress = new Uri("https://random-word-api.herokuapp.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                var stringTask = client.GetStringAsync("/word");
                var word = await stringTask;

                //Print word
                var charsToRemove = new string[] { "[", "]", "\"" };
                foreach (var c in charsToRemove)
                {
                    word = word.Replace(c, string.Empty);                   
                }
                //User Guesses and Convert word to *
                char[] guess = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    Console.Write(guess[i] = '*');

                Console.WriteLine("\nPlease enter guess: ");               
               

                while (true)
                {
                    char userGuess = char.Parse(Console.ReadLine());
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (userGuess == word[j])
                            guess[j] = userGuess;                                            
                    }
                    Console.WriteLine(guess);
                   
                }

            }
        }
    }
}