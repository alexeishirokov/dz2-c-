 void even(int[] array)
{
int even = 0;
for (int j = 0; j < array.Length; j++)
{
if (array[j] % 2 !=0);

else
    even++;
}
Console.WriteLine($"Сумма чётных чисел равна {even}");
    
} 
    Console.Clear();

    int quantity = new Random().Next(10, 100);

    int[] array =  new int[quantity];

    for(int i = 0; i < array.Length; i++)

      array[i] = new Random().Next(100, 1000);
    
    Console.WriteLine($"[{string.Join(", ", array)}]");

     even(array);