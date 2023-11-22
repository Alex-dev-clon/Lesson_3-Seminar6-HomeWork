// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да
Console.WriteLine("Enter the String: ");
string line = Console.ReadLine();
if(IsЗalindrome(line)) Console.WriteLine("String: " + line + " is palindrome");
else Console.WriteLine("String: " + line + " isn't palindrome");

bool IsЗalindrome (string line){
    for (int i = 0, j = line.Length - 1; i < line.Length/2; i++, j--){
        if (line[i] != line[j]) return false;
    }
    return true;
}