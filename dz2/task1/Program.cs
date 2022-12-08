Console.Clear();

 Console.WriteLine("Введите трёхзначное число ");
       
        int a = Convert.ToInt32(Console.ReadLine());
         
        int n = ((a/10) % 10);
         
        
         	
        Console.WriteLine($"Вторая цифра {n}");
