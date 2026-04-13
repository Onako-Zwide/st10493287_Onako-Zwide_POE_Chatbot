using System;
using System.Media;

namespace CyberSecurityChatbot
{
    class Program
    {

        //this is the main entry point of the application.
        //It initializes the chatbot, plays a greeting audio, and provides a user interface for interaction.
        //The user can ask questions about cybersecurity or choose from predefined topics.
        //The chatbot responds to user input until the user decides to exit the application.
        static void Main(string[] args)

        
        {
            string filePath = "C:\\Users\\Student\\source\\repos\\CyberSecurityChatbot\\CyberSecurityChatbot\\Chatbot Audio WAV.wav";

            // Play greeting
            // Play voice greeting

            //this block attempts to play a greeting audio file.
            //If the file is not found or cannot be played,
            //it catches the exception and prints a message to the console instead.
            try
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\CyberSecurityChatbot\\CyberSecurityChatbot\\Chatbot Audio WAV.wav");
                player.Play();
            }
            catch
            {
                Console.WriteLine("Voice greeting playing.");
            }


            // this is the UI Header whicch welcomes the user to the chatbot and provides some information about it.
            // It uses magenta color for the text to make it visually appealing.

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("================================================================");
            Console.WriteLine("   WELCOME TO Uniqua-SAFESPACE your CYBER SECURITY CHATBOT.    ");
            Console.WriteLine("================================================================");

            Console.WriteLine(@"
   __  __      _                        _____ ___    _________________ ____  ___   ____________
  / / / /___  (_)___ ___  ______ _     / ___//   |  / ____/ ____/ ___// __ \/   | / ____/ ____/
 / / / / __ \/ / __ `/ / / / __ `/_____\__ \/ /| | / /_  / __/  \__ \/ /_/ / /| |/ /   / __/   
/ /_/ / / / / / /_/ / /_/ / /_/ /_____/__/ / ___ |/ __/ / /___ ___/ / ____/ ___ / /___/ /___   
\____/_/ /_/_/\__, /\__,_/\__,_/     /____/_/  |_/_/   /_____//____/_/   /_/  |_\____/_____/   
                /_/                                                                            
                                     A SAFESPACE for Smarter Cyber Choices by ONAKO ZWIDE
            ");

            //this block resets the console color to default after printing the header and ASCII art.
            Console.ResetColor();

            // this is a Get user information block which prompts the user to enter their name and stores it in a User object.
            User user = new User();
            Console.Write("\nEnter your name: ");
            user.Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            //here the chatbot greets the user by name and provides some information about itself and how to interact with it.
            Console.WriteLine($"\nGreetings my darling {user.Name}! I'm Uniqua, your cybersucrity awareness assistant. I am pleased to to be in touch with you and I hope we will work well together! ");
            Console.WriteLine("Feel free to ask me anything about cybersecurity or choose a topic from the options below.");
            Console.WriteLine("Kindly type 'exit' to quit.\n");
            Console.ResetColor();

            // Main loop that keeps the chatbot running and allows the user to interact with it until they choose to exit.
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n1 - Phishing");
                Console.WriteLine("2 - Password Safety");
                Console.WriteLine("3 - Online Scams");
                Console.WriteLine("4 - Safety Online");
                Console.WriteLine("Or ask a question (e.g. 'What is phishing?')");
                Console.ResetColor();

                //this block prompts the user for input, validates it, and checks if the user wants to exit the application.
                Console.Write("\nYour input: ");
                string input = Console.ReadLine();

                // Input validation for empty or whitespace input. If the user enters an empty string or only whitespace,
                // it prompts them to enter something and continues the loop without sending the input to the chatbot.
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter something.");
                    continue;
                }

                //this block checks if the user wants to exit the application by typing "exit".
                //If so, it prints a goodbye message and breaks the loop to end the program.

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("\nBot: It was great working with you! Stay safe online and spread awareness about safety online. Goodbye my lovely!  ");
                    break;
                }

                // Send to chatbot
                Chatbot.Respond(input);
            }
        }
    }
}