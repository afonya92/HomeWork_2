int programm, number;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("2. Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("3. На вход принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            
            int number1 = ReadInt("Введите трехзначное число: ");
            int amount = number1.ToString().Length;
                        
            if (amount < 3 || amount > 3)
            {
                Console.WriteLine("Вы ввели не трехзначное число");
            }
            else
            {
                Console.WriteLine($"Вторая цифра этого числа: {InCenter(number1)}");
            }
            
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            
            int InCenter(int a)
            {
                int result = ((a / 10) % 10);
                return result;
            }
                     
            break;

    
    
        case 2:
            //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

            int number2 = ReadInt("Введите число: ");
            int count = number2.ToString().Length;
            Console.Write(MakeArray(number2, count));

            int ReadInt1(string message)
            {
                Console.WriteLine(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            
            int MakeArray(int a, int b)
            {
                int result = 0;
                if (b < 3)
                {
                    Console.Write("Третьей цифры нет, значит = ");
                    
                    
                }
                else
                {
                    int c = 1;
                    for (int i = b; i > 3; i--)
                    {
                        c = c * 10;
                    }

                    result = (a / c) % 10;
                }
                return result;
            }

            break;
    
    
        case 3:
            //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            int dayNumber = ReadInt("Введите число от 1 до 7: ");
            Console.WriteLine(WorkHoliday(dayNumber));

            int ReadInt2(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            
            
            string WorkHoliday(int a)
            {
                if (a > 0 && a < 8)
                {
                    if (a == 7 || a == 6)
                    {
                        Console.Write("Под цифрой " + a + " - Выходной");
                    }
                    else
                    {
                        Console.Write("Под цифрой " + a + " - Рабочий");
                    }
                }
                else
                {
                    Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
                }
                return " день.";
            }
            break;
    
    
    
        default:
            begin = false;
            break;
    }
}