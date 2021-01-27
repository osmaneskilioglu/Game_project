using System;

namespace Game_project
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager()); // (new NewEstateUserValidationManager());- 
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Engin", IdentityNumber = 1234 });

            Console.WriteLine();        
        }
    }
}
