using static System.Console;
Clear();

WriteLine($"Введите массив, отделяя элементы массива пробелом");
string[]array=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] matrix=ReplacementArray(array);
WriteLine("Новый массив:");
PrintArray(matrix);




string[] ReplacementArray(string[] array1)
{
    int count=0;
    for (int i=0; i<array1.Length; i++)
        if (array1[i].Length<4)
            count++;

    string[] newarray=new string[count];
    int j=0;
    for (int i=0; i<array1.Length; i++)
        if (array1[i].Length<4)
        { 
            newarray[j]=array1[i];
            j++;
        }
        
    
    return newarray;
}

void PrintArray(string[]prarray)
{
    string prArray=String.Join(", ",prarray);
    WriteLine($"[{prArray}]");
}
