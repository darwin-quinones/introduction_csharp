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
            string[] userNames = new string[10] { "", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 0;
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world");

            while (arrayCurrentIndex < 10)
            {
                Console.WriteLine("Are you a registered user? write true, or false to register");
                userType = Convert.ToBoolean(Console.ReadLine());

                if(userType == true)
                {
                    Console.WriteLine("You are a registered user, please enter your exact user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine($"The user you searched is {userToSearch}");

                    //  Buscar el index del usuario en en el array de usuarios
                    int indexOfUser = Array.IndexOf(userNames, userToSearch);
                    if(indexOfUser == -1)
                    {
                        Console.WriteLine("User not found, please try again or register");
                    }
                    else
                    {
                        // Aquí encontró el user
                        Console.WriteLine($"Welcome {userNames[indexOfUser]}. It's a pleasure to give you food");
                    }

                }else if(userType == false)
                {
                    Console.WriteLine("Please write and remember your username");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your user has been saved successfully.\n" + $"Your username is > {userNames[arrayCurrentIndex]}");
                    arrayCurrentIndex++;
                }
            }

            Console.WriteLine("The restaurant is full, try again next year\n. These are the guests to this night:");

            int auxIndex = 0;
            foreach(string username in userNames)
            {
                Console.WriteLine($"User number: {auxIndex} and username {username}");
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}
