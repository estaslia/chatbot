using System;

namespace chatbot
{
    class Chatbot
    {
        private string userName;
        private UIHelper uiHelper;
        private ChatHandler chatHandler;
        private TopicHandler topicHandler;

        public Chatbot()
        {
            uiHelper = new UIHelper();
            chatHandler = new ChatHandler();
            topicHandler = new TopicHandler();
        }

        // FUNCTION 1: Displays art, then automatically calls VoiceGreeting
        public void DisplayAsciiArt()
        {
            uiHelper.DisplayAsciiArt();

            // Automatically call the next function
            VoiceGreeting();
        }

        // FUNCTION 2: Shows greeting, then automatically calls GetUserName
        private void VoiceGreeting()
        {
            uiHelper.TypeText("\nBot: Initializing system...");
            uiHelper.TypeText("Bot: Welcome to your Cyber Security Assistant.");

            // Automatically call the next function
            GetUserName();
        }

        // FUNCTION 3: Gets user name, then automatically calls ShowWelcome
        private void GetUserName()
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                userName = "User";
            else
                userName = name;

            // Automatically call the next function
            ShowWelcome();
        }

        // FUNCTION 4: Shows welcome, then automatically calls ShowMenu
        private void ShowWelcome()
        {
            uiHelper.ShowWelcome(userName);

            // Automatically call the next function
            ShowMenu();
        }

        // FUNCTION 5: Shows menu and handles choice, then calls appropriate function
        private void ShowMenu()
        {
            int choice = uiHelper.ShowMenu();

            // Based on choice, call different functions
            switch (choice)
            {
                case 1:
                    StartChat();
                    break;

                case 2:
                    ShowPhishing();
                    break;

                case 3:
                    ShowPassword();
                    break;

                case 4:
                    ShowMalware();
                    break;

                case 5:
                    ShowFirewall();
                    break;

                case 6:
                    ExitProgram();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    ShowMenu(); // Call menu again
                    break;
            }
        }

        // CHAT FUNCTION - Returns to menu when done
        private void StartChat()
        {
            Console.WriteLine("\n--- Chat Mode (type 'menu' to return) ---\n");

            while (true)
            {
                Console.Write(userName + ": ");
                string input = Console.ReadLine().ToLower();

                if (input == "menu")
                {
                    Console.WriteLine();
                    ShowMenu(); // Return to menu
                    return;
                }

                Console.WriteLine("Bot: " + chatHandler.GetResponse(input) + "\n");
            }
        }

        // TOPIC FUNCTIONS - Each returns to menu when done
        private void ShowPhishing()
        {
            topicHandler.ShowPhishing();
            uiHelper.PressAnyKeyToContinue();
            ShowMenu(); // Return to menu
        }

        private void ShowPassword()
        {
            topicHandler.ShowPassword();
            uiHelper.PressAnyKeyToContinue();
            ShowMenu(); // Return to menu
        }

        private void ShowMalware()
        {
            topicHandler.ShowMalware();
            uiHelper.PressAnyKeyToContinue();
            ShowMenu(); // Return to menu
        }

        private void ShowFirewall()
        {
            topicHandler.ShowFirewall();
            uiHelper.PressAnyKeyToContinue();
            ShowMenu(); // Return to menu
        }

        // EXIT METHOD - Ends the program
        private void ExitProgram()
        {
            uiHelper.ExitProgram(userName);
            Environment.Exit(0); // Exit the program
        }
    }
}