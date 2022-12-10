  Console.Clear();

   Console.Write("Введите пятизначное число: ");
   
   string a = Console.ReadLine();

    int n = a.Length;

if (n == 5)
{
  if (a[0] == a[4] && a[1] == a[3])
    {
        Console.WriteLine("Это число является палиндромом");
    }
    else
       {
        Console.WriteLine("Это число не является палиндромом");
      }
        }
          else
     {
    Console.WriteLine("Вы ввели не пятизначное число");
}
    