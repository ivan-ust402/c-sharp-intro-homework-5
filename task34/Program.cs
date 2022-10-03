/* 
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами или введите его через консоль. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] CreateRandomArray(int length) {
    int[] array = new int[length];
    Random randNumGen = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = randNumGen.Next(99, 1000);
    }
    return array;
}

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) 
    {
        if (i == 0 && array.Length > 1) 
        {
            Console.Write($"[{array[i]}, ");
        } 
        else if (i == array.Length - 1 && array.Length > 1) 
        {
            Console.Write($"{array[i]}]");
        } 
        else if (i == 0 && array.Length <= 1) 
        {
            Console.Write($"[{array[i]}]");
        }
        else 
        {
            Console.Write($"{array[i]}, ");
        }
     }
     Console.WriteLine("");
}