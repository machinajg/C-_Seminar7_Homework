// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = new int[3,4];
void FillArray(int[,] Number)     //Заполняем массив случайными цифрами
{
    for (int m = 0; m < Number.GetLength(0); m++)
    {
        for (int n = 0; n < Number.GetLength(1); n++)
        {
            Number[m,n] = new Random().Next(-1,11);  
        }            
    }
}
void PrintArray(int[,] printnumb)       //Выводим массив на экран
{
    for (int m = 0; m < printnumb.GetLength(0); m++)
    {
        for (int n = 0; n < printnumb.GetLength(1); n++)
        {
            Console.Write($"|{printnumb[m,n]}|  ");
        }
    Console.WriteLine();
    }    
}
int[,] SumColumn (int[,] num)                //Создаём метод, который сначала складывает
{                                            // елементы в столбцах, а потом находит                                              
    for (int j=0; j<num.GetLength(1); j++)  // их среднее арифметическое
    {
        double Sumnum = 0;
        for (int i=0; i<num.GetLength(0); i++)
        {
            Sumnum = Sumnum + num[i,j];                 
        }
        double Average = Math.Round(Sumnum/num.GetLength(0),1);
        Console.Write($"|{Average}| ");            
    }
    return num;
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumColumn(array);