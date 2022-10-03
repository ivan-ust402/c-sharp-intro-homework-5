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
Console.Clear();
Console.Write("Введите массив, последовательностей элементов. Элементы введите через пробел: ");
string str = Console.ReadLine()!;
int[] arr = ParseToArray(str);
FindChain(arr);

int[] ParseToArray(string str) {
    string[] stringArray = str.Split(" ");
    int[] numArray = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++) {
        numArray[i] = int.Parse(stringArray[i]);
    }
    return numArray;
}

int[] FindChain(int[] array) {
    int currentCount = 0;
    int prevCount = 0;
    int element = array[0];
    int position = 0;
    int[] resultArray = new int[3];
    
    for (int i = 0; i < array.Length; i++) {
        for (int j = i; j < array.Length; j++) {
            if (array[i] == array[j]) currentCount++;
        }
        if (prevCount < currentCount) {
            prevCount = currentCount;
            element = array[i];
            position = i;
        }
        currentCount = 0;
    }
    resultArray[0] = prevCount;
    resultArray[1] = element;
    resultArray[2] = position;
    
    return resultArray;
}