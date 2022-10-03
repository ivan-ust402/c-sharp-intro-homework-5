/* 
Задача со звёздочкой
Найти в массиве самую длинную последовательность, состоящую из одинаковых элементов. Вывести на экран количество элементов самой длиной последовательности, элемент самой последовательности и номер элемента, который является ее началом.
Данная задача не вилияет на оценку
Пример:
[1 2 2 4 4 4 4 3 3 3] ->
Count: 4
Element: 4
Position: 3
*/


int[] ParseToArray(string str) {
    string[] stringArray = str.Split(" ");
    int[] numArray = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++) {
        numArray[i] = int.Parse(stringArray[i]);
    }
    return numArray;
}