using System;

/*
 1. Validar si el usuario existe o si se debe registrar, y generar un sistema de registro o login.
 2. El programa debe ser capaz de darle la bienvenidad a un usuario existente.
 3. El programa debe repetirse hasta que se registren las 10 personas.
 */

namespace restauran10TablesReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // array de users
            string[] userNames = new string[10] { "Mike", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 1;
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world");

            while (true)
            {
                Console.WriteLine("Are you a registered user? write true, or false to register");
            }
        }
    }
}
