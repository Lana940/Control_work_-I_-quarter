// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам

// "hello", "2", "world", ":-)"
    // {"1234", "1567", "-2", "computer"}
    // {"Russia", "Denmark", "Kazan"}
    
 
 string[] array =
{
    "hello", "2", "world", ":-)",
    "1234", "1567", "-2", "computer",
    "Russia", "Denmark", "Kazan"

};
 
var result = new string[array.Length];
var count = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[count] = value;
        count++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine result, 0, count));









 



