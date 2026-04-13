using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatbot
{
    class TopicHandler
    {
        // TOPIC FUNCTIONS
        public void ShowPhishing()
        {
            ShowFormatted("PHISHING",
                "Phishing is when attackers trick users into giving sensitive information through fake emails or websites.\n\n" +
                "Protection Tips:\n" +
                "- Never click suspicious links in emails\n" +
                "- Check sender email addresses carefully\n" +
                "- Don't share personal information online");
        }

        public void ShowPassword()
        {
            ShowFormatted("PASSWORD SAFETY",
                "Use strong passwords with uppercase, lowercase, numbers, and symbols.\n\n" +
                "Best Practices:\n" +
                "- Use at least 12 characters\n" +
                "- Don't reuse passwords across sites\n" +
                "- Enable Two-Factor Authentication (2FA)");
        }

        public void ShowMalware()
        {
            ShowFormatted("MALWARE",
                "Malware is harmful software such as viruses or spyware.\n\n" +
                "Protection Tips:\n" +
                "- Install antivirus software\n" +
                "- Keep your system updated\n" +
                "- Don't download from untrusted sources");
        }

        public void ShowFirewall()
        {
            ShowFormatted("FIREWALL",
                "A firewall monitors and controls network traffic for security.\n\n" +
                "Key Functions:\n" +
                "- Blocks unauthorized access\n" +
                "- Monitors incoming/outgoing traffic\n" +
                "- Creates a barrier between trusted/internal networks");
        }

        // FORMATTED OUTPUT
        private void ShowFormatted(string title, string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n========================================");
            Console.WriteLine("   " + title);
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine(message + "\n");
        }
    }
}

