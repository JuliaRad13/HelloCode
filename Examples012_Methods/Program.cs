// Вид 1 // Ничего не принимают, ничего не возвращают
/*
void Method1()// Аргумент который ни чего не возвращает
{
    System.Console.WriteLine("Автор");// тело 
}
Method1();
*/

// Вид 2 //Принимают, но не возвращают
/*
void Method2(string msg)// с аргументом
{
    System.Console.WriteLine(msg);
}
Method2("Текст сообщения");
*/
/*
void Method21(string msg, int count)
{
   int i=0;
   while (i<count)
   {
    System.Console.WriteLine(msg);
    i++;
   }
}
Method21(msg:"Текст сообщения", count:4);
Method21("Текст сообщения", 4);// или
*/

// Вид 3 // Не принимают, но возвращают
/*
int Method3()
{
    return DateTime.Now.Year;// Сделали
}
int year=Method3();// Положили
System.Console.WriteLine(year);// Показали
*/

// Вид 4 // Принимают, и возвращают
/*
string Method4(int count, string Text)
{
    int i=0;
    string result=String.Empty;// пустая строка
    while (i<count)
    {
        result=result+Text;
        i++;
    }
    return result;
}
string result=Method4(10, "Abc");
System.Console.WriteLine(result);
*/

/*
string Method5(int count, string Text)
{
    string result=String.Empty;// пустая строка
    for (int i=0; i<count; i++)
    // инициализация счетчика, проверка условия, инкримент
    {
        result=result+Text;
    }
    return result;
}
string result=Method4(10, "Abc");
System.Console.WriteLine(result);
*/

/*
// Таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i*j}");
    }
    System.Console.WriteLine();// пробел
}
*/


/*
//    Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с"

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty" вспомогательный функционал
//             0123
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;  // пустая строка 
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText=Replase(text, ' ', '|');
System.Console.WriteLine(newText);

System.Console.WriteLine();
newText=Replase(newText, 'к', 'К');
System.Console.WriteLine(newText);

System.Console.WriteLine();
newText=Replase(newText, 'С', 'с');
System.Console.WriteLine(newText);
*/

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)// array.Length "-1" вводится искуственно
    {
        int minPosition = i; //1// 
        
        for (int j = i+1; j < array.Length; j++)//3
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];//2
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);//выводим массив
SelectionSort(arr);

PrintArray(arr);