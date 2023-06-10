// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Net;
using System.IO;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;
using System.Net.Http;

namespace Roadkill
{
    class Game
    {
        // add getters and setters and constructor and all that silly stuff or also don't that's fine
        public static string traffic = @"
        
                                                         _________________________   
                    /\\      _____          _____       |   |     |     |    | |  \  
     ,-----,       /  \\____/__|__\_    ___/__|__\___   |___|_____|_____|____|_|___\ 
  ,--'---:---`--, /  |  _     |     `| |      |      `| |                    | |    \
 ==(o)-----(o)==J    `(o)-------(o)=   `(o)------(o)'   `--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````

        ";
        private static string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1]; // split takes domain name out of username
        private static string? timerinput; // stores console input for timer before being parsed
        private static int honkfrequency; // parsed user input for honk pitch/frequency
        private static int honkduration; // parsed user input for honk duration
        private static int seconds; // parsed user input for timer duration
        private static int label = 1; // label for filename, increments each iteration of the foreach loop
        private static string? address; // used to store each url for each iteration of the foreach loop
        private static string? destination; // used to store each destination for the downloads of each iteration of the foreach loop
        private static string? content; // holds StreamReader content for each iteration of foreach loop
        private static string [] urls = // array of roadkill photo urls
        {
            "https://i1.wp.com/www.denverpost.com/wp-content/uploads/2016/08/20160804_101741_raccoon.jpg?w=810&crop=0%2C0px%2C100%2C9999px",
            "https://radraccoon.files.wordpress.com/2016/08/ta9cmoy-e1470405823516.jpg?w=1108",
            "https://images5.memedroid.com/images/UPLOADED11/50bbdca9dc5b7.jpeg",
            "https://4.bp.blogspot.com/_EfDRu0IfQ6s/Se8XsTmtJcI/AAAAAAAAFOc/-gt0O4w2npE/s400/Krystal+King.jpg",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQjvU83MByLRiij1_tHs0OokmCjMOAte3scWA&usqp=CAU",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjYZTNhkC95pUvZRqfkoSB5f8YwurW_ZlHYA&usqp=CAU",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJIG_zyqeY8phRfW2KNSR7xUlGFLrBVmqrew&usqp=CAU"
        };

        static async Task Main()
        {
            Console.Title = "cyberpunk2077.exe";
            Console.WriteLine("Please enter your full legal name, billing address, credit card number, cvv, and expiration date.");
            Console.ReadKey();
            Console.WriteLine("\nJust kidding lol.");

            while(true) // user input determines the frequency of the console beep
            {        
                
                Console.WriteLine("Pick a number between 37 and 32767."); // this is the only range of integers that works for the beep frequency
  
                if(int.TryParse(Console.ReadLine(), out int frequency))
                {
                    if(frequency >= 37 && frequency <= 32767)
                    {
                        honkfrequency = frequency;
                        break;
                    }
                }
                Console.WriteLine("Try again loser!");         
            }
            while(true) // user input determines the duration of the console beep.  tread lightly young padawan.
            {
                Console.WriteLine("Pick a number between 1000 and 100000."); 

                if(int.TryParse(Console.ReadLine(), out int duration))
                {
                    if(duration >= 1000 && duration <= 100000)
                    {
                        honkduration = duration;
                        break;
                    }
                }
                        Console.WriteLine("Stop trying to be different and just pick a number.");                       
            }    
    
            Console.WriteLine(traffic);
            Console.Beep(honkfrequency, honkduration);
            Console.WriteLine("That was a honk.");
            Console.WriteLine("Wait, what was your name again?");
            Console.ReadKey();
            Console.WriteLine("\nJust kidding.  How could I forget!");
            Console.WriteLine("You, " + username + ", are sitting in the car, trying to leave town after work.  It is approximately 5:15pm EST.  Traffic is moving slowly.");
    
            while(true) // user input determines the length of the timer countdown thing
            {
                Console.WriteLine("Pick a number.");
                timerinput = Console.ReadLine();

                if(!int.TryParse(timerinput, out seconds) || seconds <= 0)
                {
                    Console.WriteLine("Please pick an actual number that will work.");
                }
                else
                {
                    break;
                }

            }
                
            if(seconds == 0)
            {
                return;
            }

            Console.WriteLine("It appears that you are now stuck in a traffic jam for " + timerinput + " seconds.  Please wait.");
            await Task.Delay(seconds * 1000);
            
            Console.WriteLine("Wake up! There's that honk again!");

            Console.Beep(honkfrequency, honkduration);

            Console.WriteLine("It appears that in your reckless driving and carelessness you have hit an innocent creature with your car");
            Console.WriteLine("You Lose!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            foreach(string url in urls)
            {
                address = url;
                
                using(HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    byte[] content = await response.Content.ReadAsByteArrayAsync();
                    
                    string contenttype = response.Content.Headers.ContentType.MediaType;
                    string fileextension = contenttype switch
                    {
                        "image/jpeg" => ".jpg",
                        "image/png" => ".png",
                        "image/gif" => ".gif", // for scalability ;)
                        _ => ".jpg" // defaults to .jpg if content type is unknown
                    };

                    destination = $@"C:\Users\{username}\Desktop\photo{label}{fileextension}";
                    File.WriteAllBytes(destination, content);
                }
                
                label++;

            }
        }
    }
}