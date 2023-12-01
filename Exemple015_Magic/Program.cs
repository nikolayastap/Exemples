Console.Clear();

int row = 128;
int[,] triangle = new int[row, row];
const int cellWidth = 1; // Кол-во символов для вывода каждого эл.

void FillTriangle() // Метод заполняет треугольник
{
    for (int i = 0; i < row; i++) // Пробегает по 1му столбику и заполняет 1(еденицами)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle [i, j] = 
                triangle [i - 1, j - 1] + triangle [i - 1, j];
        }
    }
}

//  void PrintTriangle() // Медод печатает треуголник
//  {
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < row; j++)
//         {
//             if (triangle [i, j] != 0) // Все что не равно 0 печатаем
//                 Console.Write($"{triangle[i,j], cellWidth}");
//         }
//         Console.WriteLine();
//     }
//  }

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
       for (int j = 0; j <= i; j++)
       {
        Console.SetCursorPosition(col, i + 1);
        // if (triangle[i,j] != 0) Console.Write($"{triangle[i,j], cellWidth}"); // Делает треугольник паскаля равнобедренным
        // if (triangle[i,j] != 0) Console.WriteLine("*"); // Заполняет треугольник звездами вместо цифр
        if (triangle[i,j] % 2 != 0) Console.WriteLine("*"); // Заполняет звездами только четные числа (треугольник Серпинского)
        col += cellWidth * 2;
       }
       col = cellWidth * row - cellWidth * (i + 1);
       Console.WriteLine();
    }
}

Console.ReadLine();
FillTriangle();
// PrintTriangle(); // Печатает треугольник Паскаля
Console.ReadLine();
Magic();