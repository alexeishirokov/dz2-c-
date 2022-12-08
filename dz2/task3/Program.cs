Console.Clear();

Console.WriteLine("Введите число недели");
      
       int a = int.Parse(Console.ReadLine());
       
         if(a > 5 && a < 8){
         	
         	Console.WriteLine("Это выходной");
         }
         
         else{
         	
         	Console.WriteLine("Это рабочий день");
         }
