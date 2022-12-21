
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//
//["Hello", "2", "world", ":-)"] → ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] → ["-2"]
//["Russia", "Denmark", "Kazan"] → []



//using System.Linq;

string [] SourceArray1 = new string [] {"Hello", "2", "world", ":-)"};
string [] SourceArray2 = new string [] {"1234", "1567", "-2", "computer science"};
string [] SourceArray3 = new string [] {"Russia", "Denmark", "Kazan"};

//
// короткий алгоритм с использованием расширений C#
//
string [] SelectItemsByLength1 (string [] Source, int length)
    {
        string [] ResultArray = new string [0];
        for (int i = 0; i < Source.Length; i++)
        {
            if (Source [i].Length <= length)
            {
                ResultArray = ResultArray.Append(Source[i]).ToArray();
            }
        }
        return ResultArray;
    }

//
// длинный алгоритм с "обычными массивами"
//
string [] SelectItemsByLength2 (string [] Source, int length)
    {
        int shortStringsCount = 0;
        for (int i = 0; i < Source.Length; i++)
        {
            if (Source [i].Length <= length)
            {
                shortStringsCount++;
            }
        }
        // Узнали количество "коротких" строк в массиве:Console.Clear();

        string [] Result = new string [shortStringsCount];
        //создали результирующий массив:
        int ResultItemIndex = 0;
        for (int i = 0; i < Source.Length; i++)
        {
            if (Source [i].Length <= length )
            {
                Result [ResultItemIndex] = Source [i];
                ResultItemIndex++;
            }
        }
        // заполнили результирующий массив:
        return Result;
        // и передали его дальше
    }


////////////////////////////////////////////////////////////////////
Console.Clear();

//получим массивы строк не длиннее 3 символов по короткому алгоритму:
string [] ResultArray1 = SelectItemsByLength1 (SourceArray1, 3);
string [] ResultArray2 = SelectItemsByLength1 (SourceArray2, 3);
string [] ResultArray3 = SelectItemsByLength1 (SourceArray3, 3);

//выведем эти массивы:
Console.WriteLine($"Result 2");
Console.WriteLine(String.Join(", ", ResultArray1));
Console.WriteLine(String.Join(", ", ResultArray2));
Console.WriteLine(String.Join(", ", ResultArray3));

//получим массивы строк не длиннее 3 символов по "обычному" алгоритму:
string [] ResultArray12 = SelectItemsByLength2 (SourceArray1, 3);
string [] ResultArray22 = SelectItemsByLength2 (SourceArray2, 3);
string [] ResultArray32 = SelectItemsByLength2 (SourceArray3, 3);

//выведем и эти массивы:
Console.WriteLine($"Result 2");
Console.WriteLine(String.Join(", ", ResultArray12));
Console.WriteLine(String.Join(", ", ResultArray22));
Console.WriteLine(String.Join(", ", ResultArray32));



