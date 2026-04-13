using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatbot
{
    class ChatHandler
    {
        // CHATBOT RESPONSES
        public string GetResponse(string input)
        {
            if (input.Contains("how are you"))
                return "I am doing well! How can I assist you today?";
            else if (input.Contains("hello") || input.Contains("hi"))
                return "Hello! Feel free to ask me about cybersecurity.";
            else if (input.Contains("thank"))
                return "You're welcome!";
            else if (input.Contains("phishing"))
                return "Phishing is a scam where attackers trick you into giving personal information.";
            else if (input.Contains("password"))
                return "Use strong passwords with letters, numbers, and symbols.";
            else if (input.Contains("malware"))
                return "Malware is harmful software designed to damage your system.";
            else if (input.Contains("firewall"))
                return "A firewall protects your network from unauthorized access.";
            else
                return "I don't understand. Try asking about cybersecurity. (Try: phishing, password, malware, or firewall)";
        }
    }
}
