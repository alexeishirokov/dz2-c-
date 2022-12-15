void inArr(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 10); 
}


void sumUneven(int[] array){

int sumUneven = 0;
for (int i = 1; i < array.Length; i+=2){

   sumUneven = sumUneven + (array[i]);
}
      Console.WriteLine($"Сумма чисел на нечётных позициях равна: {sumUneven}");
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inArr(array);

Console.WriteLine($"[{string.Join(", ", array)}]");

sumUneven(array);