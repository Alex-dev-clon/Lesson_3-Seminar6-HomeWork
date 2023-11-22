// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.
// “Hello my world” => “world my Hello”
Console.WriteLine("Enter the String: ");
string line = Console.ReadLine();
string [] lineArray = line.Split(' ');
string newString = CreateStringFromArray (lineArray);
Console.WriteLine(newString);

string CreateStringFromArray (string[] lineArray){
    string result = "";
    for (int i = lineArray.Length - 1; i >= 0; i--){
        result = result + lineArray[i] + " ";
    }
    return result;
}
