/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76
*/

Console.Clear();
Console.WriteLine("Вы находитесь в программе по поиску разницы между максимальным значением массива и минимальным.");
Console.WriteLine("Введите размерность (длину) желаемого массива: ");
int number = int.Parse(Console.ReadLine()!);
double[] arr = CreateArrayRealElem(number);
PrintArray(arr);
double result = FindDiffMaxMin(arr);
Console.WriteLine($"Разница между максимальным значением элемента массива и минимальным равна {result}");

double[] CreateArrayRealElem(int length) {
    double[] array = new double[length];
    Random RandomGen = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = RandomGen.NextDouble();
    }
    return array;
}

void PrintArray(double[] array) {
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

double FindDiffMaxMin(double[] array) {
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    if (min < 0) min = -min;
    double diff = max - min;
    return diff;
}

/* int[] array1 = new int[]{-1, 1, -2};
int res = FindDiffMaxMin1(array1);
Console.WriteLine(res);

int FindDiffMaxMin1(int[] array) {
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    // if (min < 0) min = -min;
    int diff = max - min;
    return diff;
} */