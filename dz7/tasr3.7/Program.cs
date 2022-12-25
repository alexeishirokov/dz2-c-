/*Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)}; ");
}*/
Random arr = new Random();
int[,] matrix = new int[arr.Next(3, 9), arr.Next(3, 9)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = arr.Next(1, 10);
			Console.Write($"{matrix[i, j]} \t");
		}
		Console.WriteLine();
	}

Console.WriteLine($"Столбцов: {matrix.GetLength(1)}");
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		double sum = 0;
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			sum += matrix[i, j];
		}
		Console.Write($"{ Math.Round(sum / matrix.GetLength(0),2)}; ");

}
	