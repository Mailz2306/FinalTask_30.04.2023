
int arraysize = int.Parse(Console.ReadLine()); 

string[] array = new string[arraysize]; 

for (int i = 0; i < arraysize; i++)
{
    Console.Write("Введите элементы массива: "); 
    string result = Console.Readline();
    array[i] = result; 
}
