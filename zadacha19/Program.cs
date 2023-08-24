//Использую long и ToInt64, чтобы использовать числа более чем пятизначные.
bool Palindrome(long num1)
{
	long originalNumber = num1;
	long reversedNumber = 0;
	while (num1 > 0)
	{
		long lastdigit = num1 % 10;
		reversedNumber = reversedNumber * 10 + lastdigit;
		num1 /= 10;
	}
	return originalNumber == reversedNumber;
}

Console.Write("Введите целое число: ");
long n1 = Convert.ToInt64(Console.ReadLine());

bool result = Palindrome(n1);
Console.Write($"{n1} -> ");
Console.WriteLine(result ? "Да" : "Нет");