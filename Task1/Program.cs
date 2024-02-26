class Program
{
    static void Main(string[] args)
    {
        InputNumber();
    }

    static void InputNumber()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число, или q, чтобы выйти. Также программа будет завершена автоматически, если сумма цифр числа будет четной: ");
            string input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            int number;
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Неверный формат числа. Введите целое число или q для выхода");
                continue;
            }
            if (IsDigitSumEven(number))
            {
                break;
            }
        }
    }

    static bool IsDigitSumEven(int number)
    {
        List<int> digits = new List<int>();

        while (number > 0)
        {
            digits.Add(number % 10);
            number /= 10;
        }
        int sum = 0;
        foreach(int digit in digits)
        {
            sum += digit;
        }
        return sum % 2 ==0;
    }
}