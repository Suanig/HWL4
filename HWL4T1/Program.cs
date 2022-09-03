Console.WriteLine("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B числа A ");
int degreeB = Convert.ToInt32(Console.ReadLine());
int numberB = 1;

int DBA(int numberB)
{
   int result = 1;
    while (numberA < Math.Pow(numberA, degreeB))
    result = numberB * numberA;
    return result;
}


Console.WriteLine($"Результат возведения числа А в степень В = {DBA(numberB)}");