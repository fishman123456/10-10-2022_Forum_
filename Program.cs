// See https://aka.ms/new-console-template for more information
// Создать массив на 10 элементов, при этом три варианта создания массива
// заполнять значениями вводимыми с клавиатуры;
// заполнить рандомными значениями от 1 до 100.
// сделать  вывод массива на экран полностью и по индексу

int[] myArr_A; // обьявляем одномерный массив
myArr_A = new int[5]; // задаём кол-во элементов
float [,] myArr_B; // обьявляем одномерный массив
myArr_B = new float[3,4]; // задаём кол-во элементов
Random rand = new Random(); // выделяем память под функцию рандом
Console.WriteLine(); // перенос на новую строку
Console.WriteLine("Одномерный массив:\t"); // вывод на консоль 

for (int i = 1; i < myArr_A.Length; i++) 
{
    myArr_A[i] = i; // запоняем массив myArr_A
}
Console.WriteLine(); // перенос на новую строку
print(myArr_A);     // функция вывода массива в одну строку
Console.WriteLine(); // перенос на новую строку
static void print(int[] arr) // функция вывода массива arr в одну строку
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " "); // вы
    }
}
