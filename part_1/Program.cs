using System;
using System.Media;

namespace part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances
            new Sound_sound() { };   
            photo1 photoInstance = new photo1();
            UserDetails1 userInstance = new UserDetails1();
            

            // User interactions
            userInstance.GreetUser();
            string firstName = userInstance.StoreName();
            string lastName = userInstance.StoreSurname();

            // Generate report
            userInstance.GenerateUserReport(firstName, lastName);

            
            // Start cybersecurity chatbot
            userInstance.CybersecurityChat();


            //playing sound 

            

        }
    }
}


