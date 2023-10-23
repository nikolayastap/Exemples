
// VOID не возрашаемый метод

// создает массив и запоняет его
void FillArray(int[] collection)
{
    int length = collection.Length; // - получает длинну массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // - наполнит коллекцию случайными числами в промежутке 1-10
        index++;
    }
}

// Метод VOID который печатает масссив
void PrintArray(int[] col) // col (collection)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// находит позицию элимента с использованием метода. Возращаемый метод.
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 будет выводить в случае отсутствия искомого элемента
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // отанавливает как тольконайдет первый искомый элемент
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // - Создай массив с 10 элиментами

FillArray(array); // вызывает метод который заполняет массив
PrintArray(array); // печатает наш массив
Console.WriteLine();

int pos = IndexOf(array, 24); // искомый эллемент
Console.WriteLine(pos);