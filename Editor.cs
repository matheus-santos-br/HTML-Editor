using System;
using System.IO;
using System.Text;

namespace HTMLEditor{

    public static class Editor{

        public static void Show(){

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Editor Mode");
            Console.WriteLine("------------");
            
            Console.ReadKey();

            Start();

        }

        public static void Start(){

            var text = new StringBuilder();
            
            do{

                text.Append(Console.ReadLine());

                text.Append(Environment.NewLine);


            }while(Console.ReadKey().Key != ConsoleKey.Escape);


            comeback:
            Console.Clear();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("WWould you like to save the file?(S/N)");

            Console.WriteLine("");

            Viewer.Show(text.ToString());

            var ans =  Console.ReadLine();

            ans = ans.ToLower();

            switch(ans){
                case "s":Saving(text.ToString());break;
                case "n": Menu.Show();break;
                default: {
                    Console.WriteLine("Invalid option");
                    Console.ReadKey();
                    goto comeback;
                }
            }

        }

        public static void Saving(string text){
            Console.Clear();
            
            Console.WriteLine("Specify the file's path: ");
            var path = Console.ReadLine();
            //C:\test\text.txt

            using(var file = new StreamWriter(path)){ // using System.IO; ^^

                    file.Write(text);

                }

                Console.WriteLine($"File {path} Saved!");
                Console.ReadKey();
                Menu.Show();

        }

    }

}