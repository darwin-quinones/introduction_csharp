
bool  numberPrime(int number)
{
    int divisor = 0;

    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            divisor++;
        }
    }
    if (divisor == 2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Random rnd = new Random();
int number = rnd.Next(1, 100);

string p = " is prime, ";
string np = " is not prime, ";
if(numberPrime(number) == true)
{
    Console.WriteLine(($"{number + p}").ToUpper() );
    string prime = p.Insert(11, " because has to devisors.");
    Console.WriteLine("{0}{1}", number, prime);
}
else
{
    Console.WriteLine(($"{number + np} ").ToLower());
    string notP =  np.Insert(15, " because has more than 2 devisors.");
    Console.WriteLine("{0}{1}", number, notP);
}







// prime numbers up to 100

//int num = 2;
//int divisor = 0;

//while (num <= 100)
//{
//    for (int i = 1; i <= num; i++)
//    {
//        if (num % i == 0)
//        {
//            divisor++;
//        }
//    }
//    if (divisor == 2)
//    {
//        Console.WriteLine("{0} is prime ", num);
//    }
//    divisor = 0;
//    num++;
//}
//Console.ReadKey();
