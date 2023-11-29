Console.Clear();

// // Собрать строку с числами от a до b, a ≤ b

//     string NumberFor(int a, int b) //итеративный подход
//     {
//         string result = string.Empty;
//         for (int i = a; i <= b; i++) //запускаем цикл который меняет счеткик от a до или больше b
//         {
//             result += $"{i} "; //в результриующую строку собирает значения счетчика
//         }
//         return result;
//     }
//     Console.WriteLine(NumberFor(1, 10));


// string NumberRec(int a, int b) //используя рекурсию
// {
//     if (a <= b) return $"{a} " + NumberRec(a + 1, b);
//     else return string.Empty; // устловие окончания, когда возрощаем пустую строку
// }
// Console.WriteLine(NumberRec(1, 10));


// // Собрать строку с числами от a до b, a ≥ b

//     string NumberFor(int a, int b) //итеративный подход, существенно не отличается
//     {
//         string result = string.Empty;
//         for (int i = a; i => b; i--)
//         {
//             result += $"{i} ";
//         }
//         return result;
//     }
//     Console.WriteLine(NumberFor(1, 10));

// string NumberRec(int a, int b) //используя рекурсию
// {
//     if (a <= b) return NumberRec(a + 1, b) + $"{a} "; // необходимо поменять собирающую строку
//     else return string.Empty;
// }
// Console.WriteLine(NumberRec(1, 10));



// // Сумма чисел от 1 до n

// int SumFor(int n) //итеративный
// {
//     int result = 0;
//     for (int i = 1; i < n; i++) return += i;
//     return result;
// }
// Console.WriteLine(SumFor(10));

// int SumRec(int n) //используя рекурсию
// {
//     if (n == 0) return 0; //условия выхода n=0
//     else return n + SumRec(n-1);
// }
// Console.WriteLine(SumRec(10));


// // Факториал числа

//     int FactorialFor(int n)
//     {
//         int result = 1;
//         for (int i = 1; i <= n; i++) result *=i;
//         return result;
//     }
//     Console.WriteLine(FactorialFor(10));

// int FactorialRec(int n) //используя рекурсию
// {
//     if (n == 1) return 1; // условие выхода 1, возращаем еденицу
//     else return n * FactorialRec(n-1);
// }
// Console.WriteLine(FactorialRec(10));


// // Вычеслит число a в степени n

//     int PowerFor(int a, int n)
//     {
//         int result = 1;
//         for (int i = 1; i <= n; i++) result *=a;
//         return result;
//     }
//     Console.WriteLine(PowerFor(2, 10)); // 1024

// int PowerRec(int a, int n) //используя рекурсию
// {   // return n == 0 ? 1 : PowerRec(a, n-1) * a; -вариант записи в одну строку
//     if (n == 0) return 1; // условие выхода 0, возращаем 1
//     else return PowerRec(a, n-1) * a;
// }
// Console.WriteLine(PowerRec(2, 10)); // 1024

// int PowerRecMath(int a, int n) //используя рекурсию и сокращаем с помощю формулы возведерия в степень
// {   
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n-1) * a;
// }
// Console.WriteLine(PowerRecMath(2, 10));


// // Перебор слов. В некотором ашинном алфавите имеются
// // четыре буква "a", "и", "с" и "в". Покажите все слова,
// // сосотящие из Т букв, которые можно построить из букв
// // этого алфавита

// int n = 1; //принудительно сделали счетчик слов
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//     Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length +1);
//     }
// }
// FindWords("аисв", new char[2]); // ожидаем получить все 2х буквенные слова


// // Рекурсия которая ходит по папкам и расматривает что внутри

// void CatalogInfo(string path, string indent = "") //path-путь к текущей папке, string indent = ""-отступы,чтобывидеть структуру папки
// {
//     DirectoryInfo catalog = new DirectoryInfo(path); //получ инф о деректории в которую зашли

//     DirectoryInfo[] catalogs = catalog.GetDirectories(); 
//     for (int i = 0; i < catalogs.Length; i++) //получаем массив всех папок
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
// string path = @"C:\Users\astas\Desktop\Languag C\Examples\Example003_Sum"; //путь к папке
// CatalogInfo(path);


// // Игра в пирамидки (программа записывает последовательный алгоритм)
// // with - откуда берем блин, on - шпиль на который переносим пирамиду,
// // some - промежуточный шпиль, count - кол-во блинов

// void Towers(string with = "1", string on = "3", string some ="2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();


// // Обход различных структур
// // ((4-2) * (1+3)) / 10 посчитав иерархию подчиненности выстраиваем следующие
// // string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"}
// //                   0    1    2     3    4    5    6    7    8    9    10   11

// string emp = string.Empty;
// string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"}; // одномерный массив

// void InOrderTraversal(int pos = 1) // в метод передаем позицию с которой начинаем делать обход
// {
//     if (pos < tree.Length) //если позиция вылетела за количество эл то рекурсия заканчивается
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();


// Подсчет чисел Вибоначчи (Итеративный способ работае быстрее Рекурсивного)
decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecuursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecuursion(n - 1) + FibonacciRecuursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

// # 1 2 3 4 5 6
// v 1 1 2 3 5 8

DateTime dt = DateTime.Now; //засечем время до начала подсчета

for (int n = 10; n < 40; n++)
{                                                                                       //что бы числа были дру над дружкой
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); //выведем разницу веремени мжду началом и концем

Console.WriteLine();
Console.ReadLine();

dt = DateTime.Now;

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecuursion({n}) = {FibonacciRecuursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

