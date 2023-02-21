// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] Number)   //Заполняем массив случайными вещественными цифрами
{
    for (int m = 0; m < Number.GetLength(0); m++)
    {
        for (int n = 0; n < Number.GetLength(1); n++)
        {
            Number[m,n] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);}
        }            
    }
void PrintArray(double[,] printnumb)       //Выводим массив на экран
{
    for (int m = 0; m < printnumb.GetLength(0); m++)
    {
        for (int n = 0; n < printnumb.GetLength(1); n++)
        {
            Console.Write($"|{Math.Round(printnumb[m,n],1)}| ");
        }
    Console.WriteLine();
    }    
}
double[,] array = new double[5,4]; 
FillArray(array);
PrintArray(array);

