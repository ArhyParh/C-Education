﻿//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());
while (number > 7){number -= 7;}
if (number == 1){Console.WriteLine("Понедельник");}
if (number == 2){Console.WriteLine("Вторник");}
if (number == 3){Console.WriteLine("Среда");}
if (number == 4){Console.WriteLine("Четверг");}
if (number == 5){Console.WriteLine("Пятница");}
if (number == 6){Console.WriteLine("Суббота");}
if (number == 7){Console.WriteLine("Воскресенье");}
