// Задача 66
/*
int SumOfNaturals(int m, int n, int steps = 0)
{
    if(steps == 0 && m - n < 0)
        steps = n - m;
    
    if(steps != 0)
        return SumOfNaturals(m + n, n - 1, --steps);
   
    return m;
}
int startNum = 0, finNum = 0;
while(true)
{
    Console.WriteLine("Input first number a : ");
    startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input second number b   b > a: ");
    finNum = Convert.ToInt32(Console.ReadLine());
    if(finNum > startNum)
        break;
    else
        Console.WriteLine("Error second number should be bigger than first. Please try again");
}
Console.WriteLine();
Console.WriteLine($"{startNum}; {finNum} -> {SumOfNaturals(startNum, finNum)}");
*/

// Задача 67

int SumOfDigits(int n, int result)
{
    if(n / 10 == 0)
        return result;
    else
        return SumOfDigits(n /= 10, result += n % 10);
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine("Sum: " + number + " -> " + SumOfDigits(number, number % 10));
