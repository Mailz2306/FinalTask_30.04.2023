
int arraysize = int.Parse(Console.ReadLine()); 

string[] array = new string[arraysize]; 

for (int i = 0; i < arraysize; i++)
{
    Console.Write("Введите элементы массива: "); 
    string result = Console.ReadLine();
    array[i] = result; 
}

Console.WriteLine();
Console.Write("Это ваш массив: [");
Console.Write(string.Join(",", array));
Console.Write("]");

int count = 0; 
int maximumSimbol = 3; 

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= maximumSimbol)
    {
        count++; 
    }
}
