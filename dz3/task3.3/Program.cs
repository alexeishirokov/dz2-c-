﻿Console.Clear();

Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)

Console.Write($"{(i * i)*i} ");
