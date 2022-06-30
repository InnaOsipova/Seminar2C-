//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

void Showthird (string num)
{
  char [] array = num.ToCharArray();
  int count = array.Length;
 
  if (count > 2)
  {
     Console.WriteLine (array[2]);
  }
  else
  {
      Console.WriteLine("третьего числа нет");
  }
}

Console.Write("Введите целое число : ");
string number = Console.ReadLine();

Showthird(number);

