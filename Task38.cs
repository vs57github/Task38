/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76 */
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");  
    array[i] = int.Parse(Console.ReadLine());  
}
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++) 
{ 
    if (array[i] > max) 
    { 
        max = array[i]; 
    } 

    if (array[i] < min) 
    { 
        min = array[i]; 
    } 
}  
int difference = max - min;
Console.WriteLine(difference);
