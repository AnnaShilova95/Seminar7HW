int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateRandom2dArray(int m, int n, int min, int max){
    double [,] array = new double [m,n];
    for(int i = 0; i<m; i++)
        for(int j = 0; j<n; j++)
            array[i,j] = min + Convert.ToDouble(new Random().NextDouble()* (max - min)); 
    return array;
}

void Show2dArray(double[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(Math.Round (array[i,j],1)+ "   ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray (m, n, min, max);
Show2dArray (array);



//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void SearchElement (int [,] array, int i, int j){
    if (i >= array.GetLength(0) || j >= array.GetLength(1)) Console.WriteLine("Такого элемента нет");
    else Console.WriteLine($"Значение элемента {i} строки и {j} столбца равно {array [i,j]}");
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = CreateRandom2dArray(rows,cols,min,max);
Show2dArray(array);
Console.WriteLine();
Console.WriteLine("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

SearchElement(array, i, j);
*/
//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Average (int [,] array){
    double mean = 0;
    double sum = 0;
    for (int cols = 0; cols < array.GetLength(1); cols++){
        for (int rows = 0; rows < array.GetLength(0); rows++){
            sum+=array[rows,cols];
            mean = sum / (array.GetLength(0));
        }
    double meanres = Math.Round(mean, 1);
    Console.WriteLine($"Среднее арифметическое стобца {cols} равно: {meanres}");    
    sum = 0;   
    }
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows,cols,min,max);
Show2dArray(array);
Average(array);