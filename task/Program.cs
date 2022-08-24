/*
Условие задачи:

Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
*/

int FindSize(string[] arbitraryArray, int requiredSize)             // Метод определения длинны итогового массива.
{
    int size = 0;
    for (int i = 0; i < arbitraryArray.Length; i++)
    {
        if (arbitraryArray[i].Length <= requiredSize) size++;
    }
    return size;
}

string[] SelectWords(string[] arbitraryArray, int requiredSize, int y)      // Метод создания и заполнения итогового массива.
{
    string[] resultArray = new string[y];
    int temp = 0;
    for (int i = 0; i < arbitraryArray.Length; i++)
    {
        if (arbitraryArray[i].Length <= requiredSize) 
        {
            resultArray[temp] = arbitraryArray[i];
            temp++;
        }
    }
    return resultArray;
}

Console.Write("Введите количество слов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите слова через enter:");
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    string? a = Console.ReadLine();
    array[i] = a;
}
Console.WriteLine();
Console.Write("Массив из введённых вами слов: ");
Console.WriteLine(string.Join("| ", array));

const int MAXSIZE = 3;

int finalArrayLength = FindSize(array, MAXSIZE);
string[] finalArray = SelectWords(array, MAXSIZE, finalArrayLength);

Console.WriteLine();
Console.Write("Массив, отсортированный по словам, в которых не более 3-х букв: ");
Console.WriteLine(string.Join("| ", finalArray));