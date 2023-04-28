//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
    string N = Console.ReadLine();
    int len_N = N.Length;
    if ( len_N < 3 ) 
      {
        Console.WriteLine("Третьго числа нет");
      }
    else
      {
        int x = Convert.ToInt32(N);
        for (int i = 3; i < len_N; i++)
          {            
            x = x / 10;  
          }  
        if (x % 10 == 0)
          {
            Console.WriteLine(0);
          }
        else
          {
            Console.WriteLine(x - x / 10 * 10);
          }
      }
