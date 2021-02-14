using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer 
            { Id = 1, 
              BirthYear = 1985,
              FirstName = "Engin", 
              LastName = "Demiroğ",
              IdentityNumber = 12345
            });
        }
    }
}
