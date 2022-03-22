using System;
using System.Text.RegularExpressions;

namespace HTMLEditor{

    public static class Viewer{

        public static void Show(string text){


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("View Mode");
            Console.WriteLine("------------");
            Replace(text);
            Console.WriteLine("------------");         
            
        }      

        public static void Replace(string text){

            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");

            var words = text.Split(" ");

            for(var c = 0 ; c < words.Length ; c+=1){

                if(strong.IsMatch(words[c])){

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(
                        words[c].Substring(words[c].IndexOf(">") + 1,
                         (words[c].LastIndexOf("<") - 1) - words[c].IndexOf(">"))
                    );
                        Console.WriteLine(" ");
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(words[c]);
                }
            }

        }


    }

}