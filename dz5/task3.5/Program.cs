void InArr(int[] array)
{
   for (int i = 0; i < array.Length; i++)
     array[i] = new Random().Next(10, 100);
}

void sumResult(int[] array)
{
    int max = 0;
    int min = array[0];
  for (int i = 0; i < array.Length; i++){

    if(array[i] > max){
        max = array[i];
    }
    if(array[i] < min){
        min = array[i];
    }  
}
    Console.WriteLine($"max и min: {max} и {min}");
    Console.WriteLine($"Разница между ними: {max - min}");
   
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InArr(array);
Console.WriteLine($" [{string.Join(", ", array)}]");
sumResult(array);