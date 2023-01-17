 // Задача: Написать программу, которая из имеющегося массива строк
//  формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.


string[]matrix= new string[4]{"Hello", "2", "world", ":-)"};
string[]matrix1=new string[matrix.Length];

void GetNewArray(string[]matrix, string[]matrix1)
{
    int N = 0;
    for(int i = 0;i<=matrix.Length; i++)
    {
        if( matrix[i].Length<=3)
        {
            matrix1[N]=matrix[i];
            N++;
        }
    }
}

void PrintArray(string[]array)
{
    for(int i=0; i<array.Length;i++)
    {
    Console.Write($"{matrix1[i]} ");
    };
    Console.WriteLine();
}
GetNewArray(matrix,matrix1);
PrintArray(matrix1);

