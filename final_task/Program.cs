 // Задача: Написать программу, которая из имеющегося массива строк
//  формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.


string[]array= new string[4]{"Hello", "2", "world", ":-)"};
string[]array1=new string[array.Length];

void GetNewArray(string[]array, string[]array1)
{
    int N = 0;
    for(int i = 0;i<array.Length; i++)
    {
        if( array[i].Length<=3)
        {
           array1[N]=array[i];
            N++;
        }
    }
}

void PrintArray(string[]array)
{
    for(int i=0; i<array.Length;i++)
    {
    Console.Write($"{array1[i]} ");
    };
    Console.WriteLine();
}
GetNewArray(array,array1);
PrintArray(array1);

