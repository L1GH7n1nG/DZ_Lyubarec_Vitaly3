double distancefunction(int x1, int y1, int z1, int x2, int y2, int z2)
{
	double solution = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
	double roundedDistance = Math.Round(solution, 2);
	return roundedDistance;
}

Console.WriteLine("Введите координаты точки: A");
Console.Write("X: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.Write("X: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double distance = distancefunction(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
Console.WriteLine($"Расстояние между точками A и B = {distance}");