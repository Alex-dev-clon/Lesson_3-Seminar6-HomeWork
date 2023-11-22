// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
// “aBcD1ef!-” => “abcd1ef!-”
Console.WriteLine("Enter the String: ");
string line = Console.ReadLine().ToLower();
Console.WriteLine("New String: " + line);