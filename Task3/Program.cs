// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.

void Main()
{
int [] Numbers = FillArray();


PrintArray(Numbers);


}

 void PrintArray(int[] array,int i = 0) 
 {
      
      if (i >= array.Length) return;
    {
        
        PrintArray(array, i+1);
        System.Console.Write($"{array[i]} ");
        
          
    }
  }



int [] FillArray()
    {
        System.Console.WriteLine("Введите длину массива: ");
        int LenghtArray = CorrectInput();
        int [] Array = new int[LenghtArray];
        for (int i = 0;i < LenghtArray; i++) 
        {
            Console.WriteLine($"Введите {i+1} символ:");
            Array[i] = CorrectInput();
        } 
        return Array ;
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