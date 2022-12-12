/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
["1234", "1567", "-2", "computer science"] → [“-2”]
["Russia", "Denmark", "Kazan"] → [] */
int CountLen (string [] collection)
{
   int count = 0; 
   int index = 0;
   while (index < collection.Length)
    {
        if (collection[index].Length <= 3) count ++;
        index++;
    }
    return count;
}
string [] LenElement (string [] collection, int lenResult)
{
    string [] result = new string[lenResult];
    int index = 0; 
    int indexInItems = 0;
    while (index < collection.Length)
    {
        if (collection[index].Length <= 3) 
        {
            result [indexInItems] = collection[index];
            indexInItems ++;
        }
        index ++;
    }
    return result;
} 
string PrintArray(string[] collection)
{
  int i = 0;
  string printResult = "[ ";
  while (i < collection.Length)
  {
    printResult += ($"{collection[i]} "+ ",");
    i++;
  }
  return printResult + "]";
}

string [] arrString = {"Hello", "2", "world", ":-)"};
int countItems = CountLen (arrString);
Console.Write("Количество элементов с длиной меньше 3:  ");
Console.WriteLine(countItems);
string [] newArray = LenElement(arrString, countItems);
string printResult = PrintArray(newArray);
Console.Write("Полученный массив: ");
Console.WriteLine(printResult);