// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] Number)     //Заполняем массив случайными цифрами
{
    for (int m = 0; m < Number.GetLength(0); m++)
    {
        for (int n = 0; n < Number.GetLength(1); n++)
        {
            Number[m,n] = new Random().Next(-100,101);  
        }            
    }
}
void PrintArray(int[,] printnumb)       //Выводим массив на экран
{
    for (int m = 0; m < printnumb.GetLength(0); m++)
    {
        for (int n = 0; n < printnumb.GetLength(1); n++)
        {
            Console.Write($"{printnumb[m,n]} ");
        }
    Console.WriteLine();
    }    
}
int[,] array = new int[3,4];
FillArray(array);
PrintArray(array);
Console.WriteLine();


int[,] Findnum(int[,] findnum)       
{
    Console.Write("Введите число:  ");
    int numA = Convert.ToInt32(Console.ReadLine());
    for (int m = 0; m < findnum.GetLength(0); m++)
    {
        for (int n = 0; n < findnum.GetLength(1); n++)
        {
            if(findnum[m,n]==numA) Console.Write($"{findnum[m,n]} - такое число есть в массиве");
            else Console.Write($"{numA} - такого числа нет в массиве");
            
        }
    
    }   
return findnum;
}
Findnum(array);
