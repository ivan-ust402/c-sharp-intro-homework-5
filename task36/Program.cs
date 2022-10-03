/* 
Задача 36: Задайте одномерный массив или введите через консоль, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
Console.Clear();
Console.WriteLine("Вы находитесь в программе подсчета суммы всех элементов массива, находящихся на нечетных позициях.");
Console.Write("Введите элементы массива через пробел: ");
string str = Console.ReadLine()!;
int[] arr = ParseToArray(str);
int result = SumOfOddElem(arr);
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {result}");

int[] ParseToArray(string str) {
    string[] stringArray = str.Split(" ");
    int[] numArray = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++) {
        numArray[i] = int.Parse(stringArray[i]);
    }
    return numArray;
}

int SumOfOddElem(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (i % 2 != 0) {
            sum += array[i];
        }
    }
    return sum;
}
