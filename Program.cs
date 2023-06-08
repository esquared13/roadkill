// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Net;
using System.IO;
using System.Drawing;
using System.Numerics;

namespace roadkill
{
    class game
    {
        // add getters and setters and constructor and all that silly stuff
        // need to create a method for the game i think maybe
        public static string traffic = @"
        
                                                         _________________________   
                    /\\      _____          _____       |   |     |     |    | |  \  
     ,-----,       /  \\____/__|__\_    ___/__|__\___   |___|_____|_____|____|_|___\ 
  ,--'---:---`--, /  |  _     |     `| |      |      `| |                    | |    \
 ==(o)-----(o)==J    `(o)-------(o)=   `(o)------(o)'   `--(o)(o)--------------(o)--'  
`````````````````````````````````````````````````````````````````````````````````````

        ";
        private static int honkfrequency; 
        private static int honkduration; 
        private static bool ending;

        bool gameplay()
        {
            Console.Title = "cyberpunk2077.exe";

            while(true)
            {        
                Console.Write("Pick a number.");
                    
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    honkfrequency = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                else
                {
                        Console.Write("Try again loser!");
                        
                }
            }
            while(true)
            {
                Console.Write("Pick another number.");

                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    honkduration = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                else
                {
                        Console.Write("Stop trying to be different.");
                        
                }

            return ending; // will be equal to true or false and determine what consequence
            }    
                    
            Console.Write(traffic);
            
            Console.Beep(honkfrequency, honkduration);
    
                

                // some exceptions to handle hehehehehe   
                //    IOException
                //    OutOfMemoryException
                //    ArgumentOutOfRangeException
            

            // return statement here please gal
        }
        
        

    }
    class photos
    {
        string [] urls = // array of roadkill photo urls
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