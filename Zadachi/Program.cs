//Задача Пользователь ввел в консоль м-чисел.Подсчитать,сколько чисел больше 0 он ввел.

Console.WriteLine ("Введите количество вводимых чисел ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i<a;i++ )
{
  Console.WriteLine ("Введите число ");
  int b = Convert.ToInt32(Console.ReadLine());
  if (b>0)
  {
    count = count + 1;
    
  }
}
Console.WriteLine ( " Количество введенных чисел больше нуля =  " + count);


/*Задача: напишите программу,которая будет 
искать параметры точки пересечения двух прямых,
 заданных уавнениями: y = к1*х + b1 и y = k2*x + b2.
  Значения k1,b1,k2,b2 задаются пользователем*/

  int x;
  int y;
  
  Console.WriteLine ("Введите число k1 ");
  int k1 = Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine ("Введите число k2 ");
  int k2 = Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine ("Введите число b1 ");
  int b1 = Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine ("Введите число b2");
  int b2 = Convert.ToInt32(Console.ReadLine());

  if (k1==k2)
  {
    Console.WriteLine ("Введены некорректные значения. Прямые параллельны");
  }
  else
  {
    x = (b1-b2)/(k1-k2);
    y = k1*x-b1;
   Console.WriteLine ($"Точка пересечения прямых - М ({x};{y})"); 
  }
  

