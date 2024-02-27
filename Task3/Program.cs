class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {43, 8, 1, 504};
        ReverseArray(numbers);
        ShowArray(numbers);
    }
    static int[] ReverseArray(int[] numbers)
    {
        for(int i = 0; i < numbers.Length / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
            
        }
        return numbers;
    }
        static void ShowArray(int[] array)
{
    foreach(int item in array)
    {
        Console.Write(item+", ");
    }
}
}