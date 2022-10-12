// See https://aka.ms/new-console-template for more information
// Создать массив на 10 элементов, при этом три варианта создания массива
// заполнять значениями вводимыми с клавиатуры;
// заполнить рандомными значениями от 1 до 100.
// сделать  вывод массива на экран полностью и по индексу

int[] myArr_A; // обьявляем одномерный массив
myArr_A = new int[5]; // задаём кол-во элементов
double [,] myArr_B; // обьявляем одномерный массив
myArr_B = new double[3,4]; // задаём кол-во элементов

Console.Title = " Пример использования инструментов класса Console"; // оформление
    Console.BackgroundColor = ConsoleColor.Black; //изменяет цвет фона
Console.ForegroundColor = ConsoleColor.DarkGreen;//изменяет цвет текста
Console.SetWindowSize(100, 20);//устанавливаем размер окна консоли

Console.WriteLine(); // перенос на новую строку
Console.WriteLine("Одномерный массив:\t"); // вывод на консоль 

for (int i = 0; i < myArr_A.Length; i++) 
{
    int a = int.Parse(Console.ReadLine());
    myArr_A[i] = a; // запоняем массив myArr_A  // 12-10-2022 13:12
}
Console.WriteLine(); // перенос на новую строку
print(myArr_A);     // функция вывода массива в одну строку
Console.WriteLine(); // перенос на новую строку

Random rand = new Random(); // выделяем память под функцию рандом

// Двумерный массив 3 строки, 4 столбца
Console.WriteLine(); // перенос на новую строку
Console.WriteLine("Массив 2 double \"en-RUS\": \t");
Console.WriteLine(); // перенос на новую строку
double vares =0.001;
for (int l = 0; l < 3; l++) // поменял i на l, с i получалось только 10 проходов
{
    for (int j = 0; j < 4; j++)
    {
        myArr_B [l, j] = rand.NextDouble(); // присваиваем элементу, j-4 раза, i-3 раза.
        //Console.Write(Math.Round(myArr_B[l, j], 4) + "\t"); //Round(double a, int b):
        vares = myArr_B[l, j];
        Console.Write(vares.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-RUS"))+"\t");

        //возвращает число a, округленное до определенного количества знаков после запятой, представленного параметром b
    }
    Console.WriteLine(); // перенос на новую строку 0. 611 224 415 306 414 - 15 знаков после запятой
}





// функция вывода массива arr в одну строку
static void print(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write(arr[i] + " "); // выводим на консоль массив 
    }
}
