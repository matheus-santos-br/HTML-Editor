using System;

namespace HTMLEditor
{
    public static class Menu{
        public static void Show(){

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
            WriteOptions();
            
            var option = short.Parse(Console.ReadLine());

            HandleMenuOptions(option);
        }

        public static void DrawScreen(){

            Console.Write("+");
            
            for(var c = 0; c <= 30 ; c+=1){
                Console.Write("-");
            }
            
            Console.Write("+");
            
            Console.Write("\n");

            for(var lines = 0; lines <= 10 ; lines += 1){

                Console.Write("|");
                 for(var c = 0; c <= 30 ; c+=1){
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }

             Console.Write("+");
            
            for(var c = 0; c <= 30 ; c+=1){
                Console.Write("-");
            }
            
            Console.Write("+");
            
            Console.Write("\n");

        }
        
        public static void WriteOptions(){

            Console.SetCursorPosition(3,2);
            Console.WriteLine("HTML Editor");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Select an option below:");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - New file:");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Open file:");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Exit:");
            Console.SetCursorPosition(3,10);
            Console.Write("Option: ");
        }

        public static void HandleMenuOptions(short option){
            switch(option){

                case 1: Editor.Show();break;
                case 2: Open.OpeningFile();break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                }; break;

                default: Show();break;
            }
        }

    }
    
}