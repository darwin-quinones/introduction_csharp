

// declaracion de una lista

List<string> tacoShoppingList = new List<string>();

tacoShoppingList.Add("Cinco tacos de suadero");
tacoShoppingList.Add("Cuatro tacos de tripa");
tacoShoppingList.Add("Cinco tacos de pastor");
tacoShoppingList.Add("cuatro Pony Maltas");

for(int i = 0; i< tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}
// remove item
tacoShoppingList.Remove("Cuatro tacos de tripa");

for(int j = 0; j < tacoShoppingList.Count; j++)
{
    Console.WriteLine(tacoShoppingList[j]);
}


