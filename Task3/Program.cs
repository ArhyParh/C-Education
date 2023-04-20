// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number2 = number;
int i = 0;
while(number != 0)
{
Console.Write("-"+number +", ");
number -= 1;
}
while(i < number2+1)
{
Console.Write(+i +", ");
i +=1;
}
