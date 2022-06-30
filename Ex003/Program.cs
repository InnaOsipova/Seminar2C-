// Напишите программу, которая принимает на вход цифру, обозначающую день 
//недели, и проверяет, является ли этот день выходным.

void WeekEnd (int num)
{
   if(num>0 & num <8)
   {  if(num < 6 )
      {
          Console.WriteLine(num+" - Этот день недели не выходной");
      }
      else
      {
          Console.WriteLine(num+ "- выходной - можно отдыхать");
      }
   }
   else
   {
     Console.WriteLine("Это не день недели");
   }
}
  

Console.Write ("введите цифру дня недели : ");
int number = Convert.ToInt32(Console.ReadLine());

WeekEnd(number);
