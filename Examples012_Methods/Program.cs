// Вид 1 - НЕ возращают , НЕ принимают
/*
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

// Вид 2 НЕ возращают , Принимают

void Method2(string msg) //принимают аргументы 
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст Сообщения");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    } 
}
//Method21(msg: "Текст", count: 4);  // можно перставлять итог будет оденаковый
Method21(count: 4, msg: "Текст");


// Вид 3 Возращают , НЕ принимают

int Metog3()
{
    return DateTime.Now.Year;
}
int year = Metog3();
Console.WriteLine(year);
*/

//Вид 4 Возврашают и Принимают
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

        while (i < count)
        {
            result = result + text;
            i++;
        }
        return result;

}
string res = Method4(10, "zv");
Console.WriteLine(res);
*/

/*
string Method4(int count, string text)
{
        string result = String.Empty;
        for (int i = 0; i < count; i++)
        {
            result = result + text;
           
        }
        return result;

}
string res = Method4(10, "zv");
Console.WriteLine(res);
*/

/*
for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i*j}");
    }
    Console.WriteLine(); //Искуственный разрыв десятков строк
}
*/

// === Работа с текстом
// Дан текст. В тексте нужно все заменить черточками,
// маленькие буквы "к" заменить большими "К" ,
//а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = " - Я думаю, - сказал князь, улыбаясь, - что "
                + "ежели бы вас послали вместо нашего милого Винценгероде, "
                + "вы бы взяли приступом согласие прусского короля. "
                + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345         
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // иницилизация пустой строки

    int length = text.Length; // определяем длинну строки
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если совпадает то положить в результат newValue
        else result = result +  $"{text[i]}"; // иначе если совпададений не обноруженно положим в результат текуший символ
    }

    return result; // возвращаем результат
}


string newText = Replace(text, ' ', '|'); // заменяем пробелы на вертикальную строку
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);

