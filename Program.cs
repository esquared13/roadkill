// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Net;
using System.IO;
using System.Drawing;
using System.Numerics;
using System.Timers;

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
        private static string timerinput;
        private static int honkfrequency; 
        private static int honkduration;
        private static int seconds;
        private static bool ending;
        private static string [] urls = // array of roadkill photo urls
        {
            "https://i1.wp.com/www.denverpost.com/wp-content/uploads/2016/08/20160804_101741_raccoon.jpg?w=810&crop=0%2C0px%2C100%2C9999px",
            "https://radraccoon.files.wordpress.com/2016/08/ta9cmoy-e1470405823516.jpg?w=1108",
            "https://www.google.com/url?sa=i&url=https%3A%2F%2Fgraspingforobjectivity.com%2F2017%2F01%2Fon-creating-a-roadkill-kit.html%2F&psig=AOvVaw1-r8I3vhGZ4Dv7fRPPlxE4&ust=1686192239184000&source=images&cd=vfe&ved=2ahUKEwjIzeTckbD_AhWepIkEHe0_DBYQjRx6BAgAEAw",
            "https://images5.memedroid.com/images/UPLOADED11/50bbdca9dc5b7.jpeg",
            "https://4.bp.blogspot.com/_EfDRu0IfQ6s/Se8XsTmtJcI/AAAAAAAAFOc/-gt0O4w2npE/s400/Krystal+King.jpg",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQjvU83MByLRiij1_tHs0OokmCjMOAte3scWA&usqp=CAU",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjYZTNhkC95pUvZRqfkoSB5f8YwurW_ZlHYA&usqp=CAU",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJIG_zyqeY8phRfW2KNSR7xUlGFLrBVmqrew&usqp=CAU"
        };

        static void Main()
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

            // probably need to clean up this dialog and make it look prettier and add spaces and whatnot        
            Console.WriteLine(traffic);
            Console.Beep(honkfrequency, honkduration);
            Console.WriteLine("That was a honk.");
            Console.WriteLine("Wait, what was your name again?");
            Console.ReadKey();
            Console.WriteLine("\nJust kidding.  How could I forget!");
            Console.WriteLine("You, " + username + ", are sitting in the car, trying to leave town after work.  It is approximately 5:15pm EST.  Traffic is moving slowly.");
    

            // this next part really is going to need some cooking on 
            while(true) // user input determines the length of the timer countdown thing
            {
                Console.WriteLine("Pick a number.");
                timerinput = Console.Readline();

                if(!int.TryParse(timerinputer, out seconds) || seconds <= 0)
                {

                }
                    

            } 
                // some exceptions to handle hehehehehe   
                //    IOException
                //    OutOfMemoryException
                //    ArgumentOutOfRangeException
            

            // no return but have an outcome that determines the other things
        }
    }
    class Photos
    {

        
        // add getters and setters and constructor and all that jazz
        // create a loop that changes the imageURL variable to the different URLs and downloads all of the images, also add a changing title variable
        // create a variable that pulls the user name for the file location
    
        public void download(string imageURL)
        {
            try
            {
                
            }
            catch
            {

            }
            
        }
    }
}





// code snippet for download and destination
//public class Example
//{
 //   public static void Main()
   // {
     //   String url = "https://code.jquery.com/jquery-3.6.1.min.js";
       // string dest = @"D:\jquery-3.6.1.min.js";
 //
   //     using (StreamReader reader = new StreamReader(WebRequest.Create(url)
     //           .GetResponse().GetResponseStream()))
       // {
         //   String content = reader.ReadToEnd();
           // File.WriteAllText(dest, content);
      //  }    
    //}
//}



// another snippet

class Program
{
    static void Main(string[] args)
    {
        int seconds;

        while (true)
        {
            Console.Write("Enter the number of seconds for the timer: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out seconds) || seconds <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                continue;
            }

            Timer timer = new Timer(seconds * 1000);
            timer.Elapsed += TimerElapsed;

            timer.Start();

            Console.WriteLine("Press Enter to start another timer or 'q' to quit.");
            string choice = Console.ReadLine();

            if (choice == "q")
                break;

            timer.Stop();
        }
    }

    static void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine("Timer finished!");
    }
}
This code allows the user to enter the number of seconds for the timer, starts the timer, and displays the "Timer finished!" message when the timer elapses. After each timer completes, the user can choose to start another timer or quit the program by pressing 'q'.





User
If the input cannot be parsed, will the loop start back at "Enter the number of seconds
ChatGPT
Yes, if the input cannot be parsed or if the entered number of seconds is invalid (less than or equal to 0), the loop will start back at the "Enter the number of seconds" prompt. The continue statement is used to skip the rest of the loop iteration and start the next iteration immediately.

In the provided example, if the user enters an invalid input, such as a non-numeric value or a negative number, the code will display the error message and then continue to the next iteration of the loop, prompting the user again to enter a valid number of seconds. This ensures that the user is prompted until a valid input is provided.






