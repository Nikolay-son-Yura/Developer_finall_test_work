/* Написать программу,которая из имеющегося массива строк формирует массив из строк,
длина которых,меньше или равна 3 символа.Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнение алгоритма. При решение не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
{"helo","2","world",":-)"}->{"2",":-)"}
{"1234","1567","-2","computer science"}->["-2"}
{"Russia","Denmark","Kazan"}->{}
*/
string[] example1 = { "helo", "2", "world", ":-)" };
string[] example2 = { "1234", "1567", "-2", "computer science" };
string[] example3 = { "Russia", "Denmark", "Kazan" };

string[] ArrayLessThanThreeElements(string[] input, int n)
{
    string[] output = new string[ArrayInitializer(input, n)];
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int ArrayInitializer(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}
int num = 3;
string[] result1 = ArrayLessThanThreeElements(example1, num);
string[] result2 = ArrayLessThanThreeElements(example2, num);
string[] result3 = ArrayLessThanThreeElements(example3, num);

Console.WriteLine($"[{string.Join(", ", example1)}] -> [{string.Join(", ", result1)}]");
Console.WriteLine($"[{string.Join(", ", example2)}] -> [{string.Join(", ", result2)}]");
Console.WriteLine($"[{string.Join(", ", example3)}] -> [{string.Join(", ", result3)}]");
