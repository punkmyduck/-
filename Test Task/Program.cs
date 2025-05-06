namespace Test_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinTwoSumCalculatorTests.RunAllTests();
        }
    }


    internal interface IMinTwoSumCalculator
    {
        int Calculate(int[] numbers);
    }

    internal class StandardMinTwoSumCalculator : IMinTwoSumCalculator
    {
        public int Calculate(int[] numbers)
        {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers), "Массив не инициализирован.");
            if (numbers.Length < 2) throw new ArgumentException("В массиве должно быть не менее двух чисел.", nameof(numbers));
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min1)
                {
                    min2 = min1;
                    min1 = numbers[i];
                }
                else if (numbers[i] < min2)
                {
                    min2 = numbers[i];
                }
            }
            return min1 + min2;
        }
    }

    internal static class MinTwoSumCalculatorTests
    {
        public static void RunAllTests()
        {
            Test_CorrectSum();
            Test_TwoElementsSum();
            Test_DuplicateMinimums();
            Test_NegativeNumbers();
            Test_LessThanTwoElements();
            Test_UninitializedArray();
            Test_LargeArray();
        }

        public static void Test_CorrectSum()
        {
            var calculator = new StandardMinTwoSumCalculator();
            int[] input = { 4, 0, 3, 19, 492, -10, 1 };
            int expected = -10;
            int result = calculator.Calculate(input);
            Console.WriteLine(result == expected ? $"Тест пройден : Ожидаемый результат {expected}, получен {result}" : $"Тест провален. Ожидаемый результат {expected}, получен {result}.");
        }

        public static void Test_TwoElementsSum()
        {
            var calculator = new StandardMinTwoSumCalculator();
            int[] input = { 4, 0 };
            int expected = 4;
            int result = calculator.Calculate(input);
            Console.WriteLine(result == expected ? $"Тест пройден : Ожидаемый результат {expected}, получен {result}" : $"Тест провален. Ожидаемый результат {expected}, получен {result}.");
        }

        public static void Test_DuplicateMinimums()
        {
            var calculator = new StandardMinTwoSumCalculator();
            int[] input = { 2, 2, 5, 8 };
            int expected = 4;
            int result = calculator.Calculate(input);
            Console.WriteLine(result == expected ? $"Тест пройден : Ожидаемый результат {expected}, получен {result}" : $"Тест провален. Ожидаемый результат {expected}, получен {result}.");
        }

        public static void Test_NegativeNumbers()
        {
            var calculator = new StandardMinTwoSumCalculator();
            int[] input = { -5, -10, -3 };
            int expected = -15;
            int result = calculator.Calculate(input);
            Console.WriteLine(result == expected ? $"Тест пройден : Ожидаемый результат {expected}, получен {result}" : $"Тест провален. Ожидаемый результат {expected}, получен {result}.");
        }

        public static void Test_LargeArray()
        {
            var calculator = new StandardMinTwoSumCalculator();
            int[] input = new int[100000000];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = i + 10;
            }
            input[50] = 1;
            input[99] = 0;
            int expected = 1;
            var start = DateTime.Now;
            int result = calculator.Calculate(input);
            var duration = DateTime.Now - start;
            Console.WriteLine(result == expected ? $"Тест пройден : Ожидаемый результат {expected}, получен {result} (за {duration.TotalMilliseconds} мс)" : $"Тест провален. Ожидаемый результат {expected}, получен {result}.");
        }

        public static void Test_LessThanTwoElements()
        {
            var calculator = new StandardMinTwoSumCalculator();
            int[] input = { 4 };
            try
            {
                calculator.Calculate(input);
                Console.WriteLine("Тест провален. Ожидалось исключение, но оно не было выброшено.");
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    Console.WriteLine($"Тест пройден : Исключение выброшено - {ex.Message}");
                }
                else
                {
                    Console.WriteLine($"Тест провален. Ожидалось исключение ArgumentException, но выброшено {ex.GetType().Name}.");
                }
            }
        }

        public static void Test_UninitializedArray()
        {
            var calculator = new StandardMinTwoSumCalculator();
            int[] input = null;
            try
            {
                calculator.Calculate(input);
                Console.WriteLine("Тест провален. Ожидалось исключение, но оно не было выброшено.");
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                {
                    Console.WriteLine($"Тест пройден : Исключение выброшено - {ex.Message}");
                }
                else
                {
                    Console.WriteLine($"Тест провален. Ожидалось исключение ArgumentNullException, но выброшено {ex.GetType().Name}.");
                }
            }
        }
    }
}
