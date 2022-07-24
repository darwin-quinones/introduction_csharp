


//Console.WriteLine("Enter the selected soda: ");
//string caseSwitch = Console.ReadLine();

//switch (caseSwitch)
//{
//    case "cola":
//        Console.WriteLine("Cola soda - $2 USD");
//        break;
//    case "lime":
//        Console.WriteLine("Lime soda - 1 USD");
//        break;
//    case "orange":
//        Console.WriteLine("Orange soda - $1.5 USD");
//        break;
//    case "aple":
//        Console.WriteLine("Aple soda - $1 USD");
//        break;
//    default:
//        Console.WriteLine("You should type a correct option");
//        break;
//}

Console.WriteLine("MENU" +
    "Please type the number of the drink you want to drink \n" +
    "1. Apple Juice\n2. Ponny Malta\n3. Chocolate");
int n = Convert.ToInt32(Console.ReadLine());

switch (n) { 
    case 1: 
        Console.WriteLine("You selected Apple Juice. Price: $3 USD");
        break;
    case 2:
        Console.WriteLine("You selected Ponny Malta. Price: $4 USD");
        break;
    case 3:
        Console.WriteLine("You selected Chocolate. Price: $6 USD");
        break;

    default:
        Console.WriteLine("invalid number");
        break;
}
