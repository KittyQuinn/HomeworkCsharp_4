﻿// Напишите программу, которая задаёт массив из 10 элементов, 
//которые необходимо заполнить случайными значениями 
// в диапазоне от -10 до 10 и найти максимальное значение среди них
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

Console.Clear();
int [] array = new int[10];
Random rand = new Random();

for (int i = 0; i<array.Length; i++)
array[i] = new Random().Next(-10,10);
Console.WriteLine(array[i]);


int index = 0;
int max = array[index];
while (index<array.Length)
  
    if (array[index]>max) 
   
    index++;
    max = array[index];
   
    Console.WriteLine(max);
