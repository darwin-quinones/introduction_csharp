

// arrays declaration

string[] coffeeTypes;
float[] coffeePrices;

// arrays initialization
coffeeTypes = new string[] { "Expresso", "Largo", "Filtrado", "Latte" };
coffeePrices = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };

// chanhe array 
coffeeTypes[1] = "Banana";

for(int i = 0; i < coffeeTypes.Length; i++)
    Console.Write(coffeeTypes[i] +" Coffe $ " + coffeePrices[i] + "\n");

//other way to declarate arrays

int[] numbers = new int[3] { 2, 4, 6 };
int[] eges = { 20, 45, 22 }; 

