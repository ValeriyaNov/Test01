using static System.Console;
Clear();

string[] array=new string[4]{"fast", "fat", "cat", "s"};
PrintArray(array);

string[] matrix=ReplacementArray(array);
PrintArray(matrix);
string[] ReplacementArray(string[] array1)
{
    int count=0;
    for (int i=0; i<array1.Length; i++)
    if (array1[i].Length<3)
    count++;
    string[] newarray=new string[count];
    int j=0;
    for (int i=0; i<array1.Length; i++)
    {
            if (array1[i].Length<3)
           { newarray[j]=array1[i];
            j++;
           }
        
    }
    return newarray;

}
void PrintArray(string[]prarray)
{
    string prArray=String.Join(",",prarray);
WriteLine($"[{prArray}]");
}