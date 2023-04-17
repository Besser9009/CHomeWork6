int NewNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] NewMassiv(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = NewNumber($"Введите {i+1} элемент");
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
int NumPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int length = NewNumber("Введите колличество элементов");
int[] array;
array = NewMassiv(length);
PrintArray(array);
System.Console.WriteLine($"Колличество чисел больше 0 = {NumPositive(array)}");