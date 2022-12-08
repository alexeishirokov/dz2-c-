Console.Clear();

 Console.WriteLine("Введите число: ");
       
       int a = int.Parse(Console.ReadLine());
        
       if(a <= 99){
        	
        	Console.WriteLine($"в числе {a} нет третьей цифры");

        	Console.WriteLine("Введите другое число: ");

       }
        
        	if(a > 99 && a < 1000){
        		
        		Console.WriteLine($"Третья цифра {a % 10}");
        	
            }
    
        	else{
                while(a > 999)
             	
             	a = a / 10;
             	
             	Console.WriteLine($"Третья цифра  {a % 10}");
                
            }
       
    
       