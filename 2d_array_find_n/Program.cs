// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите номер столбца:  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки:  ");
int B = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] Number)     //Заполняем массив случайными цифрами
{
    for (int m = 0; m < Number.GetLength(0); m++)
    {
        for (int n = 0; n < Number.GetLength(1); n++)
        {
            Number[m, n] = new Random().Next(-100, 101);
        }
    }
}
void PrintArray(int[,] printnumb)       //Выводим массив на экран
{
    for (int m = 0; m < printnumb.GetLength(0); m++)
    {
        for (int n = 0; n < printnumb.GetLength(1); n++)
        {
            Console.Write($"{printnumb[m, n]} ");
        }
        Console.WriteLine();
    }
}

void Findnum(int[,] findnum)
{
    for (int m = 0; m < findnum.GetLength(0); m++)
    {
        for (int n = 0; n < findnum.GetLength(1); n++)
            {
            if (A<=findnum.GetLength(0) && B<=findnum.GetLength(1))
                {
                    findnum[m,n]=findnum[A,B];
                }
            

            }
                    
    }
    Console.Write($"{findnum[A,B]} - есть в массиве");
}
int[,] array = new int[7, 8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Findnum(array);
Console.WriteLine();
