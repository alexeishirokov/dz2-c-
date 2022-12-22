Console.Clear();
Console.Write("Введите числа массива через пробел: ");
int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sum = 0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"количество значений больше 0 = {sum}");
