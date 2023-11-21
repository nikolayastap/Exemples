Console.Clear();
// string[,] table = new string[2, 5]; // задаем размер массива
// // String.Empty //инициализация для строк
// // table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// // table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]

// table[1, 2] = "слово"; // так обращаемся к конкретному эл. в массиве

// for (int rows = 0; rows < 2; rows++) //rows строки
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"{table[rows, columns]}-"); // вывод будет в 1н столбец - Line
//     }
// }




// int[,] matrix = new int[3, 4];

// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         System.Console.Write($"{matrix[i, j]} "); // вывод в строку
//     }
// }




// int[,] matrix = new int[3, 4];

// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         System.Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine(); // вывод таблицей
// }




// void PrintArray(int[,] matr) // создает вумерный массив
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine(); // вывод таблицей
//     }
// }

// void FillArray(int[,] matr) // заполняет матрицу случ числами
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// System.Console.WriteLine(); // разделяем массивы 
// PrintArray(matrix);




// // Алгоритм для закрашивания замкнутых облостей(для маленьких облостей, рескурсоемкий)
// void PrintImage(int[,] image) //метод меняет удиницы в картинки на + 
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if(image[i,j] == 0) Console.WriteLine($" ");
//             else Console.WriteLine($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col) // закрашивает внут. обл. картинки
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row,col] = 1; // то закрашивает 1ей
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13); // указываем случайную точку внутри ресунка
// PrintImage(pic);




// // метод принимает аргумент и возращает Факторил этого числа
// double Factorial (int n)
// {
//     if(n == 1) return 1; // лпределение фактариала (1! = 1)
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//     System.Console.WriteLine($"{i}! = {Factorial(i)}");
// }




// метод принимает аргумент и возращает числа Фибоначчи
// f(1) = 1; f(2) = 1; f(3) = 2
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}