// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма 

int getLength (string [] matr)
{
    int newLength = 0;
    for (int i = 0; i < matr.Length; i++)
    {
        string NY = matr[i];
        if (NY.Length<=3)
        {
            newLength++;
        }
    }
return newLength;
}

string [] getNewArray ( string [] matr, int len)
{
    int j = 0;
    string [] finalArray = new string [len];
    for (int i = 0; i < matr.Length; i++)
    {
        string NY = matr[i];
        if (NY.Length<=3)
        {
            finalArray[j] = matr[i];
            j++;
        }
    }
    return finalArray;
}

void PrintArray ( string [] matr)
{
    for (int i = 0; i< matr.Length; i++)
    {
        Console.Write(matr[i]);
        Console.Write(" ");
    }
}

string[] s = { "Sunday", "Monday", "Tuersday","Wednesday", "Thirsday", "Friday", "Saturday", "etr" };
int L = getLength(s);
string [] Array = getNewArray (s,L);
Console.WriteLine("the final array is: ");
PrintArray(Array);




