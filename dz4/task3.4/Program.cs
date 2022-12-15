Console.Clear();

Console.Write("Введите количество чисел в массиве: ");

int a = Convert.ToInt32(Console.ReadLine());


int[] array = new int[a];
Console.WriteLine("Введите любые числа, количество которых равно вашему массиву: ");

 for (int i = 0; i < a; i++){
//Console.Write("Введите любые числа, количество которых равно вашему массиву: ");
 array [i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{String.Join(", " ,array)}]");
