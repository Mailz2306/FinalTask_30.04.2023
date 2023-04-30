Console.WriteLine("Введите размер массива: ");
int arraysize = int.Parse(Console.ReadLine()); 

string[] array = new string[arraysize]; 

for (int i = 0; i < arraysize; i++)
{
    Console.Write("Введите элемент вашего массива: "); 
    string result = Console.ReadLine();
    array[i] = result; 
}

Console.WriteLine();
Console.Write("Это введенный вами массив: [");
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

Console.WriteLine();

Console.Write("Это итоговый массив: [");

string[] array2 = new string[count]; 

int k = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= maximumSimbol)
    {
        array2[k] = array[i];
        Console.Write(array2[k] + ",");
        k++;
    }
}
Console.Write("]");

