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
