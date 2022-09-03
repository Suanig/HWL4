Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int modul = Math.Abs(number);
int sum ()
{
var digits = modul.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
int sum = 0;
for (int i = 0; i < digits.Length; ++i)
sum=sum + digits[i];
return sum;
}

Console.WriteLine($"Результат сложения всех цифр числа {number} = {sum()}");