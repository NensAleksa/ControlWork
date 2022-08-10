namespace Task
{
    class Program
    {
        static void Main(string[]args)
        {
    string[] array1 = new string[5] {"123", "2", "hello", "world", "Moscow"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int number = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[number] = array1[i];
        number++;
        }
    }
}
Console.WriteLine("Числа <=3: ");
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);
        }
    }
}