void square(int num1)
{
	int i = 1;
	Console.WriteLine($"{num1} -> ");
	while (i <= num1)
	{
		Console.WriteLine($"{i} | {i * i * i,6} ");
		i++;
	}
}

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

square(N);