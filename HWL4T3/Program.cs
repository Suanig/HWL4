int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < 8; i++)
array[i] = rand.Next(101); 
var str = string.Join(" ", array);
Console.WriteLine($"Сгенерированный массив из 8 чисел - {str}");