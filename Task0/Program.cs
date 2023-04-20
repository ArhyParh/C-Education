//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
//на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49
Console.WriteLine("введите число:");
int numberA = int.Parse(Console.ReadLine());
int numberB = numberA*numberA;
Console.WriteLine(numberB);
