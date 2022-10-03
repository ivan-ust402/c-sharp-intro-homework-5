/* 
Задача 36: Задайте одномерный массив или введите через консоль, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] ParseToArray(string str) {
    int[] stringArray = str.Split(" ");
    int[] numArray = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++) {
        numArray[i] = int.Parse(stringArray[i]);
    }
    return numArray;
}
