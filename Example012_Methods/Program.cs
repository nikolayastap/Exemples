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
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; // strirng.Empty или "" - пустая строка 
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Текст");
Console.WriteLine(res);