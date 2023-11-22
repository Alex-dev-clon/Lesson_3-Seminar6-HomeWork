// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива.
// a b c => “abcdef”
// d e f
char [,] array = {{'a', 'b', 'c'}, {'d', 'e', 'f'}};
string line = CreateLineFromArray(array);
Console.WriteLine(line);

string CreateLineFromArray (char[,] array){
    string lineNew = "";
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
        lineNew += array[i,j];
        }
    }
    return lineNew;
}
