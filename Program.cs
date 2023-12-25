//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// char[,] elements = new char[,]{{'t', '3', '4'}, {'t', '8', '4'}};
// string result = string.Empty;

//     for (int i = 0; i < elements.GetLength(0); i++)
//     {
//     for (int j = 0; j < elements.GetLength(1); j++)
//         {
//             result += elements[i, j];
//         }
//     }

// Console.WriteLine(result);

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string input = "AaBbb";
// string lowerCaseInput = input.ToLower();

// Console.WriteLine($"Оригинальный текст: {input}");
// Console.WriteLine($"текст в нижнем регситре: {lowerCaseInput}");

//
Console.WriteLine("Введите строку : ");
String sl = Console.ReadLine();
char[] sym = sl.ToCharArray();
static bool IsPalindrom(char[] word)
{
    for (int i = 0; i < word.Length / 2; i++)
    if (word[i] != word[word.Length - 1 - i])
    return false;
    return true;
}
if (IsPalindrom(sym))
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");