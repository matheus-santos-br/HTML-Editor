using System;
using System.IO;

namespace HTMLEditor{

    public static class Open{

        public static void OpeningFile(){

            Console.Clear();

            Console.Write("Specify the file's path: ");
            Console.WriteLine("");

            var path = Console.ReadLine();
            //C:\test\text.txt

            using(var file = new StreamReader(path)){ // using System.IO; ^^

                string text = file.ReadToEnd();
                Console.WriteLine(text);

                }

                Console.WriteLine("");
                Console.ReadKey();
                Menu.Show();
            }

    }

}