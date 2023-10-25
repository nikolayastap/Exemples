        // Вид 1 (Как пример используется в качестве подписи)
// void Method1()
// {
//     Console.WriteLine("Автор ......");
// }
// Method1();      // Таким вызавается метод




        // Вид 2 Не возращ. но могут принимать аргументы
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");    // Таким вызавается метод



        // Вид 2.1
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст сообщения", 4); // выводит текст указанное колво раз



        // Вид 3   Что то возращают, но ничего не принемают.
// int Method3()
// {
//     return DateTime.Now.Year; // как пример берем текущий год
// }
// int year = Method3();
// Console.WriteLine(year);


        // Вид 4   Что то принемает и что то возращает.
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty; // strirng.Empty или "" - пустая строка 
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Текст");
// Console.WriteLine(res);


        // Вид 4 Спомощю цикла FOR
// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "Текст");
// Console.WriteLine(res);


                // Цикл for в таблтце умножения
// for (int i = 2; i <= 10; i++) // 1е число
// {
//         for (int j = 2; j <= 10; j++) // 2е число
//         {
//             Console.WriteLine($"{i} x {j} = {i * j}"); // выведение таблицы 
//         }
//         Console.WriteLine(); // выполняет разрыв между столбцами
// }



                // ==== Работа с текстом
                // Дан текст. В тексте нужно все пробелы заменить черточками,
                // маленькие буквы "к" заменить большими "К",
                // а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас поставили вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

//                                 // string s = "qwerty"
//                                 //             0123
//                                 // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//         string result = String.Empty; // инициализация пустой строки

//         int length = text.Length; // показывает кол-во символов в строке
//         for (int i = 0; i < length; i++)
//         {
//                 if(text[i] == oldValue) result = result + $"{newValue}";
//                 else result = result + $"{text[i]}";
//         }
//         return result;
// }

// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);




                // Упорядовачение данных внутри массива 
                // (алгоритм сортировки методом выюора)
                // 1.Найти Min в неотсортированной части массива
                // 2.Протзвести обмен этого значения со знач. первой неотсорт. позиции
                // 3.Повторять пока есть не отсортированные элементы

// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray(int[] array) // выводит данный массив на экран
// {
//         int count = array.Length;

//         for (int i = 0; i < count; i++)
//         {
//                Console.Write($"{array[i]} "); 
//         }
//         Console.WriteLine();
// }

// void SelectionSort(int[] array) // метод упорядовачивает массив
// {
//         for (int i = 0; i < array.Length - 1; i++)
//         {
//                 int minPocition = i; // запоминаем позицию min
//                 for (int j = i + 1; j < array.Length; j++) // ищем минимальный элемент
//                 {
//                         if(array[j] < array[minPocition]) minPocition = j;
//                 }


//                 int temporary = array[i];
//                 array[i] = array[minPocition]; // кладет найденный эл. в [i] позицию
//                 array[minPocition] = temporary; // а временный в его позицию
//         }
// }


// PrintArray(arr);
// SelectionSort(arr); // вызов упорядочевания массива

// PrintArray(arr);