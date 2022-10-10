// See https://aka.ms/new-console-template for more information
// Создать массив на 10 элементов, при этом три варианта создания массива
// заполнять значениями вводимыми с клавиатуры;
// заполнить рандомными значениями от 1 до 100.
// сделать  вывод массива на экран полностью и по индексу

int[] myArr1;
myArr1 = new int[20]; 
Random rand = new Random();
Console.WriteLine("Выберите способ заполнения: 1    2   3");

switch (Console.ReadKey().Key)
{
    case ConsoleKey.NumPad1:
            for (int i = 0; i < myArr1.Length; i++)
            {
                myArr1[i] = i;
            }
        print(myArr1);
        break;
        
    case ConsoleKey.NumPad2:
        break;
    case ConsoleKey.NumPad3:
        break;
    case ConsoleKey.NumPad4:
        break;
        default:
        Console.WriteLine("выход");
        break;
        static void print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
}
