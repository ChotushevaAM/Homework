 /* Задача1
 int FindMaxNum(int num)
 {
     int n1 = num % 10;
     int n2 = num / 10;
     if(n1 > n2)
     {
         return n1;
     }
     else
     {
         return n2;
     }
 }

 

{
    int number = new Random().Next(10,99);
    Console.WriteLine("Current number is" + number + "max part is" + FindMaxNum(number));
}

    
Задача2

int Max(int num)
{
    int n1 = (num / 100) * 10;
    int n2 = num % 10;
    return n1 + n2;
}
int number = new Random().Next(100,1000);
Console.WriteLine(number + "-->" + Max(number));

Задача3


void Chastnoe(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        Console.WriteLine("Yes!");
    }
    else
    {
        Console.WriteLine("num1 % num2");
    }
}

Console.WriteLine("enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());

Chastnoe(number1,number2);

Задача4


void Proverka(int num1, int num2, int num3)
{
    if(num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine(" число " + num1 + " является кратным числом " + num2 + " и " + num3);
    }
    else{
        Console.WriteLine(" число " + num1 + " неявляется кратным числом " + num2 + " и " + num3);
    }
}

Console.WriteLine("enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter second number");
int check1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter third number");
int check2 = Convert.ToInt32(Console.ReadLine());

Proverka(number1,check1,check2);


Домашняя задание 1

    int Chislo(int num)
    {
        int n1 = ( num / 10) % 10;
    
        return n1;
    }
    int number = new Random().Next(100,1000);
    Console.WriteLine(number + "-->" + Chislo(number));
   


Домашняя задача 3

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 6)
{
    Console.WriteLine("нет\n");
}
else if(number == 6)
{
    Console.WriteLine("да\n");
}
else if(number == 7)
{
    Console.WriteLine("да\n");
}


Домашняя задача 2

int sum(int num)
{
    int n1 = (num / 100 % 10);
    return n1;
}

int number = new Random().Next(10,100000);
Console.WriteLine(number + "-->" + sum(number));
*/