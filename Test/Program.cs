//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
//исключительно массивами.

Console.Write("Введите длину массива: ");
int lengthOfArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную длину элемента массива: ");
int maxLengthOfElenent = Convert.ToInt32(Console.ReadLine());
Console.Write($"Задан массив из {lengthOfArray} элементов: [   ");

string symbols = "abcdefghijklmnopqrstuvwxyz1234567890[]{};:<>,/?!@#$%^&*()-_+=~`";
int lengthOfElenent = symbols.Length;
Random rand = new Random();

//создаем массив слов

string[] arrayOfWords = new string[lengthOfArray];
for (int i = 0; i < lengthOfArray; i++)
{

//создаем случайное слово

    string word = "";
    int randLengthNumber = rand.Next(1, 10);
    for (int j = 0; j < randLengthNumber; j++)
    {
        int element = rand.Next(0, lengthOfElenent);
        word+= symbols[element];
    }
    arrayOfWords[i] = word;
}
//выводим на печать все слова
foreach (string word in arrayOfWords)
{
    Console.Write($"{word}   ");
}
Console.WriteLine("]");
      
//Находим слова, длина которых не больше заданной, сначала находим, сколько слов подходит всего,
//создаем массив нужной длины и вторым проходом заполняем его
         
int count = 0;
foreach (string word in arrayOfWords)
{
    if (word.Length <= maxLengthOfElenent)
        {
            count++;
        }   
}

//выводим на печать подходящие по условию слова
            
Console.Write($"Нам подходят следующие элементы массива с длиной не более {maxLengthOfElenent}: [   ");
string[] finalArray = new string[count];
int x = 0;

foreach (string word in arrayOfWords)
    {
        if (word.Length <= maxLengthOfElenent)
            {
                finalArray[x] = word;
                x++;
                Console.Write($"{word}   ");
            }
}
Console.Write("]");