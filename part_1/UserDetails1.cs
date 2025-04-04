using System;
using System.Collections.Generic;
using System.IO;

namespace part_1
{
    public class UserDetails1
    {
        private List<string> names = new List<string>();
        private List<string> surnames = new List<string>();

        private string[] cybersecurityQuestions =
        {
            "How to create a strong password?",
            "What is phishing?",
            "How does Two-Factor Authentication (2FA) work?",
            "What is safe browsing?"
        };

        private string[] cybersecurityResponses =
        {
            "A strong password includes letters, numbers, and symbols.",
            "Phishing is the practice of sending fraudulent communications that appear to come from a legitimate and reputable source, usually through email and text messaging.",
            "Two-Factor Authentication (2FA) is a security process in which users provide two different authentication factors to verify themselves. 2FA is implemented to better protect both a user's credentials and the resources the user can access.",
            "Safe Browsing is a Google service that lets client applications check URLs against Google's constantly updated lists of unsafe web resources."
        };

        public void GreetUser()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello! Welcome to the Cybersecurity Assistant.");
            Console.WriteLine("I'm here to help you with online safety tips and advice.\n");
            Console.WriteLine("Before we start, let’s get to know you and your purpose.");
            Console.ResetColor();
        }

        public string StoreName()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine()?.Trim();
            names.Add(firstName ?? "");
            return firstName ?? "";
        }

        public string StoreSurname()
        {
            Console.Write("Enter your surname: ");
            string lastName = Console.ReadLine()?.Trim();
            surnames.Add(lastName ?? "");
            return lastName ?? "";
        }

        public void GenerateUserReport(string name, string surname)
        {
            string fullName = $"{name} {surname}";
            string greetingMessage = $"Hi {fullName}, welcome to the Cybersecurity Assistant!";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{greetingMessage}");
            Console.WriteLine("Feel free to ask me anything about cybersecurity and online safety.");
            Console.ResetColor();

            string filePath = "User_Report.txt";
            File.WriteAllText(filePath, greetingMessage);
            Console.WriteLine($"User report has been saved to '{filePath}'.");
        }

        public void CybersecurityChat()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nLet's talk about cybersecurity! You can ask me questions like:");
            foreach (var question in cybersecurityQuestions)
            {
                Console.WriteLine($" - {question}");
            }
            Console.WriteLine("Type 'exit' to end the chat.\n");
            Console.ResetColor();

            while (true)
            {
                Console.Write("\nAsk me a cybersecurity question (or type 'exit' to quit): ");
                string question = Console.ReadLine()?.Trim().ToLower();

                if (question == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Goodbye! Stay safe online.");
                    Console.ResetColor();
                    break;
                }

                // Match user question with stored questions
                string response = "I'm sorry, I don't have an answer for that. Try asking about strong passwords, phishing, 2FA, or safe browsing.";
                for (int i = 0; i < cybersecurityQuestions.Length; i++)
                {
                    if (question.Contains(cybersecurityQuestions[i].ToLower().Replace("?", ""))) // Case insensitive match
                    {
                        response = cybersecurityResponses[i];
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nYou asked: {question}");
                Console.WriteLine($"Response: {response}");
                Console.ResetColor();

                Console.WriteLine("\nWould you like to ask another question? (yes/no)");
                string userResponse = Console.ReadLine()?.Trim().ToLower();
                if (userResponse != "yes")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Alright! Have a great day and stay safe online!");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
