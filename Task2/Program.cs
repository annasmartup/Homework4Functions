class Program
{
    static void Main(string[] args)
    {
        int[] array = CreateRandomArray(7);
        ShowArray(array);
        Console.WriteLine("Количество четных чисел в массиве: " + CountEven(array));
    }
    static int[] CreateRandomArray (int size)
    {
        int[] array = new int [size];
        for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
        return array;
    }
    static void ShowArray(int[] array)
{
    foreach(int item in array)
    {
        Console.Write(item+", ");
    }
    Console.WriteLine();
}
    static int CountEven(int[] array)
    {
        int count = 0;
        foreach(int number in array)
        {
            if(number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}