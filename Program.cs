// See https://aka.ms/new-console-template for more information
 //var number;
 Console.WriteLine("This program determines if a number is a Prime number \nPlease enter any desired integer:");
 var number = Console.ReadLine();
 int num;
 int count = 0;
 num = Convert.ToInt32(number);
 if (num == 1 || num == 0)
    {
        Console.WriteLine(num + " is not a prime number.");
    }
else if (num == 2)
    {
        Console.WriteLine("2 is a prime number");
    }
else for(int i = 1; i <= num; i++ ){
        if( num % i == 0){ count++;}

  }
  if(count == 2){Console.WriteLine(num + " is a Prime number");}
  else Console.WriteLine(num + " is not a Prime number");
  