// Ввести пятизначное число и определить, палиндром оно или нет.

Console.WriteLine("Введите целое пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 99999) Console.WriteLine ("Введено неверное значение"); 
else if (num % 10 == num / 10000) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");


