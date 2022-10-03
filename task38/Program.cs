/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76
*/

int[] CreateArrayRealElem(int length) {
    double[] array = new double[length];
    Random RandomGen = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = RandomGen.NextDouble();
    }
    return array;
}

void PrintArray(double[] arr) {
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

int FindDiffMaxMin(double[] array) {
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    return diff;
}
