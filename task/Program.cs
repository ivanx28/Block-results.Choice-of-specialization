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

