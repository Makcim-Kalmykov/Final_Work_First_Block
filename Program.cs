// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% 
// %%% Задача:  Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых   %%%
// %%%          меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте %%%
// %%%          выполнения алгоритма. Обойтись исключительно массивами.                                             %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

string[] CreatArray()
{
    Console.Write("Enter the desired number of lines: ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] newArray = new string[size];

    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write("Input any number of characters in the string: ");
        newArray[i] = Convert.ToString(Console.ReadLine());
    }

    return newArray;
}

void ShowArray(string[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
        Console.Write(Array[i] + ", ");
    Console.Write("\b\b]");
    Console.WriteLine();
}

string[] SelectionArray(string[] array, int longString)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= longString & array[i].Length > 0)
            count++;

    string[] newArray = new string[count];

    for (int i = 0, j = 0; i < array.Length; i++)
        if (array[i].Length <= longString & array[i].Length > 0)
        {
            newArray[j] = array[i];
            j++;
        }

        return newArray;
}



string[] arrayNew = CreatArray();
ShowArray(arrayNew);
string[] selectionArray = SelectionArray(arrayNew, 3); // 3 - длинна строки в 3 символа из уcловия задачи
ShowArray(selectionArray);