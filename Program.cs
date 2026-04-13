using chatbot;
using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Chatbot bot = new Chatbot();
            bot.DisplayAsciiArt(); // First function calls the next, which calls the next
        }
    }
}