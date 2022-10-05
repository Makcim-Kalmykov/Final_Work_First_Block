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
