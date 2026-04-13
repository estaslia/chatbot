using System;
using System.Threading;

namespace chatbot

{
    class UIHelper
    {
        // ASCII ART
        public void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
   _____       _                              _             
  / ____|     | |                            | |            
 | |     _   _| |__   ___ _ __ ___  ___ _   _| |_ ___  _ __ 
 | |    | | | | '_ \ / _ \ '__/ __|/ _ \ | | | __/ _ \| '__|
 | |____| |_| | |_) |  __/ |  \__ \  __/ |_| | || (_) | |   
  \_____|\__, |_.__/ \___|_|  |___/\___|\__,_|\__\___/|_|   
          __/ |                                            
         |___/                                             

        CYBERSECURITY ASSISTANCE
    ");

            Console.ResetColor();

        }

        // Typing effect
        public void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }
            Console.WriteLine();
        }

        // Welcome message
        public void ShowWelcome(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n========================================");
            Console.WriteLine("              WELCOME");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine($"Hello {userName} What can I help you with today?\n");
        }

        // MENU DISPLAY
        public int ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================");
            Console.WriteLine("              MAIN MENU");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("1. Chat with the Bot");
            Console.WriteLine("2. Learn about Phishing");
            Console.WriteLine("3. Learn about Password Safety");
            Console.WriteLine("4. Learn about Malware");
            Console.WriteLine("5. Learn about Firewall");
            Console.WriteLine("6. Exit");

            Console.Write("\nEnter choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
                return choice;

            return 0; // invalid
        }

        // Helper method to pause after showing information
        public void PressAnyKeyToContinue()
        {
            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }

        // EXIT METHOD
        public void ExitProgram(string userName)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n========================================");
            Console.WriteLine($"   Goodbye {userName}! Stay safe online. 🔒");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Thread.Sleep(2000);
        }
    }
}