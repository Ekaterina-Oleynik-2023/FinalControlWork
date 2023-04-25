// программа, которая из имеюшегося массива строк формирует массив,
// длина строк которых не больше 3-х символов.
void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++);
    Console.WriteLine($"Начальный массив: [{string.Join(" ", array)}] ");
}
Console.WriteLine();
 void FinalArray(string[] newarray){
     string[] finalarray = new string[newarray.Length];
     for (int i = 0; i < newarray.Length; i++){
         if (newarray[i].Length <= 3){
             finalarray[i] = newarray[i];
         }
     }
     Console.WriteLine($"Конечный  массив: [{string.Join(" ", finalarray)}] ");
 }
Console.Clear();
string[] array = { "лиса", "кот", "ёж", "ворона", "чиж", "жук", "медведь"};
PrintArray(array);
FinalArray(array);
