// Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.

using System.Globalization;

void Main()
{

    System.Console.WriteLine("ВВедите нижнюю границу чисел: ");
    int LowRegister = CorrectInput();
    System.Console.WriteLine("ВВедите Верхнюю границу чисел: ");
    int HighRegister = CorrectInput();

    PrintNumberLenght(HighRegister, LowRegister);

}

void PrintNumberLenght(int M, int N)
{

    if (N > M) return;
    System.Console.Write(N + " ");
    PrintNumberLenght(M, N + 1);
    
}

int CorrectInput()
{
    while (true)
    {
        string? input = Console.ReadLine()!;
        if (int.TryParse(input, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Ввод некорректен. Попробуйте еще раз: ");
        }
    }
}

Main();