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


