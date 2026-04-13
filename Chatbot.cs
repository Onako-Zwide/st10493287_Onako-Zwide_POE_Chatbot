using System;

namespace CyberSecurityChatbot
{
    class Chatbot
    {
        public static void Respond(string input)
        {
            //this is to make the input case insensitive
            string text = input.ToLower();

            //this is to make the chatbot's responses red in color
            Console.ForegroundColor = ConsoleColor.Red;

            // these are the menu options
            //this checks if the users input matches any of the menu options, if it does,
            //the chatbot will respond with the appropriate information
            if (text == "1" || text.Contains("phishing"))
            {
                TypeText("Bot: Phishing is a cyberattack where criminals pretend to be trusted organizations in emails," +
                        " texts, phone calls, or fake websites to trick people into revealing sensitive information such as passwords," +
                        " bank details, or personal data." +
                        " These messages often create urgency to make victims click malicious links or download harmful attachments." +
                        " The dangers of phishing include identity theft, financial loss, data breaches, and malware infections." +
                        " To stay safe, people should avoid clicking suspicious links, verify the sender, check website URLs carefully," +
                        " and use strong passwords with two-factor authentication. ");
            }

            //this handles the password option and responds with information about passwords and how to create strong passwords
            else if (text == "2" || text.Contains("password"))
            {
                TypeText("Bot: Passwords are important as they protect accounts," +
                        " systems, maintain privacy, and personal information from unautorized access." +
                        " It is essential to ensure that you use strong passwords with a mixture of " +
                        "letters, numbers and special characters. Use upper case here and there. " +
                        "Your password must be hard to guess, An examplle would be #Unpr3d!ct@ble" +
                        "... see what I did there?");

            }

            //this handles the scam option and responds with information about scams and how to avoid them
            else if (text == "3" || text.Contains("scam"))
            {
                TypeText("Bot: A scam is a dishonest scheme designed steal valuable things such as money, banking details, identity information." +
                        "Scammers use fake emails, messages or websites pretending to be trusted organizations to trick people" +
                        "into entering their password or banking details. They also  use fake lottery or prize scams whereby they trick victims into thinking" +
                        "they have won a prize, and in order to claim the prize, they have to send their ID number. " +
                        "Be careful of scams asking for money or personal details, or clicking suspecious links on emails.");
            }

            //this handles the online safety option and responds with information about how to stay safe online
            else if (text == "4" || text.Contains("safe"))
            {
                TypeText("Bot: Staying safe online means avoiding sharing senstive information online," +
                        "using strong passwords, avoiding unknown links or downloads as they may contain viruses or malware that may damage devices or steal information." +
                        "Please keep in mind to always verify websites and avoid clicking suspicious links."
                    );
            }


            // this handles general responses from the user such as greetings and asking how the chatbot is doing,
            // and responds with appropriate messages
            else if (text.Contains("hello") || text.Contains("hi"))
            {
                TypeText("Hello! How can I assist you with cybersecurity today?");
            }
            else if (text.Contains("how are you"))
            {
                TypeText("As a bot I have no feelings, thanks for asking though. Hope you're doing good. How may I assist you? ");
            }
            else if (text.Contains("purpose"))
            {
                TypeText("My purpose is to help you stay safe online and understand cybersecurity.");
            }


            // this handles Unknown input from the user and responds with a message asking them to try again
            else
            {
                TypeText("I didn't understand that. Try asking about phishing, passwords, scams or online safety.");
            }


            //this resets the console color back to the default color after the chatbot has responded
            Console.ResetColor();
        }

        // this is a typing effect that makes the chatbot's responses appear as if they are being typed out in real time,
        // with a short delay between each character for a more engaging user experience.
        private static void TypeText(string message)
        {
            //this loops through each character in the message
            //and prints it to the console with a delay of 20 milliseconds between each character,
            //creating a typing effect.
            foreach (char c in message)
            {
                //this prints the current character to the console without a newline, allowing the message to appear as if it's being typed out in real time.
                Console.Write(c);
                System.Threading.Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}
