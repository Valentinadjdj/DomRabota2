//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 | number > 999)
{
    Console.WriteLine("Некорректное значение");
}
string stringNumber = Convert.ToString(number);
Console.WriteLine("Вторая цифра:" + stringNumber[1]);
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2){
  Console.WriteLine("Третья цифра:" + numberText[2]);
}
else {
  Console.WriteLine("Отсутствует третья цифра");
}
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
/*
Console.Write("Введите значение, характеризующее день недели: ");
int numberdayofweek = Convert.ToInt32(Console.ReadLine());
void Checkthisday (int numberdayofweek) {
  if (numberdayofweek == 6 || numberdayofweek == 7) {
  Console.WriteLine("Ура выходной!");
  }
  else if (numberdayofweek < 1 || numberdayofweek > 7) {
    Console.WriteLine("В неделе всего семь дней!");
  }
  else Console.WriteLine("Опять работа!");
}
Checkthisday(numberdayofweek);
*/

