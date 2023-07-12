using ConsoleApp27;
using static System.Console;
using Base;


/*string name;
name = "Ted";

WriteLine(name);
Write("Привет мир\n");

int age = 33;
bool isEmployed=false;
double weight = 78.65;
WriteLine($"Имя: {name}\n Возраст: {age}\n Вес: {weight}\n Работает: {isEmployed}");
WriteLine("Введите имя: ");
string name1 = ReadLine();
WriteLine($"Привет {name1}");*/
//try
/*{
    int a = 33;
    int b = 600;
    // byte c = checked((byte)(a + b));
    byte c = (byte)(a + b);
    Console.WriteLine(c);
}
/*catch(OverflowException ex)
{
    WriteLine(ex.Message);
}*/
/*bool x1 = (5 > 6) & (4 < 6);
WriteLine(x1);
bool x2 = (5 > 6) | (4 < 6);
WriteLine(x2);

int x = 3;
int y = 2;

int z=x<y ? (x+y) : (x-y);
WriteLine(z);
//for
for(int i = 0; i < 10; i++)
    WriteLine(i);
short j = 1;
for (WriteLine("Начало выполнения цикла"); j < 10; WriteLine($"j={j}"))
   j++;
int k = 1;
for(; ; )
{
    WriteLine($"k={k}");
    k++;
    if (k == 10)
        break;
}
int l = 1;
for(;l<4;)
{
    WriteLine($"l={l}");
    l++;
}
for (int m = 0, n = 0; m < 10; m++, n++)
    WriteLine($"{m * n}");
WriteLine("***************************");
//do...while
int i1 = 6;
do
{
    WriteLine(i1);
    i1--;
}
while (i1 > 0);
WriteLine("***************************");
//while
int j1 = 6;
while(j1 > 0)
{
    WriteLine(j1);
    j1--;
}
WriteLine("***************************");
//foreach
string? name = ReadLine();   
foreach(char c in name)
{
    Write($"{c}\t");
}*/
/* Напишите программу, в которой пользователь вводит два числа и выводит результат их умножения. При этом программа должна запрашивать
 * у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. Если введенные числа окажутся больше 10 или меньше 0, 
 * то программа должна вывести пользователю сообщение о том, что введенные числа недопустимы, и повторно запросить у пользователя ввод данных.
 * Если введенные числа принадлежат диапазону от 0 до 10, то программа выводи результат умножения.
 * Для организации ввода используйте бесконечный цикл while и оператор break.
 */
/*while(true)
{
    WriteLine("Введите первое число: ");
    int num1=Convert.ToInt32(Console.ReadLine());
    WriteLine("Введите второе число: ");
    int num2=Convert.ToInt32(Console.ReadLine());
    if(num1<0 ||num1>10|| num2>10||num2<0)
        WriteLine("Оба числа должны быть в диапазоне от 0 до 10");
    else
    {
        WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    }
}
ReadKey();*/
/*int[] nums = new int[4];
int[] nums2 = new int[4] {1,2,3,4};
int[] nums3 = new int[] {1,2,3,4,5};
int[] nums4 = new[] {1,2,3,4,5,6};
int[] nums5 = {1,2,3,4,5,6,7};
int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] nums7;
int[,] nums8 = new int[2, 5];*/
/*
 * int[,,]mas={{{1,2},{3,4}},
 *              {{4,5},{6,7}},
 *              {{7,8},{9,10}},
 *              {{10,11},{12,13}}};
 * {{{1,2},{3,4}},{{4,5},{6,7}},{{7,8},{9,10}},{{10,11},{{12,13}}}
 */
/*int[,,] mas ={{{1,2},{3,4}},
               {{4,5},{6,7}},
               {{7,8},{9,10}},
               {{10,11},{12,13}}
               };

int x= mas.GetUpperBound(0);
int y= mas.GetUpperBound(1);
int z= mas.GetUpperBound(2);

Write("{");
for(int i=0; i<=x; i++)
{
    Write("{");
    for(int j=0; j<=y; j++)
    { 
        Write("{");
        for(int k=0; k<=z; k++)
        {
            Write(mas[i,j,k]);
            if(k<z)
                Write(",");
        }
        Write("}");
        if(j<y)
            Write(",");
    }
    Write("}");
    if(i<x)
         Write(",");
}
WriteLine("}");
ReadKey();*/
/*int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int result = 0;
foreach (int i in numbers)
    if (i > 0)
        result++;
WriteLine($"Число элементов больше нуля: {result}");
int n=numbers.Length;
int k = n / 2;
int temp;
for (int i = 0; i < k; i++)
{
    temp = numbers[i];
    numbers[i]= numbers[n-i-1];
    numbers[n-i-1]= temp;
}
foreach (int i in numbers)
    Write($"{i}\t");
int[] nums = { 54, 7, -41, 2, 4, 2, 99, 22, -9, 15, 35, -40 };
WriteLine();
void hello() => WriteLine("Hello");
hello();
void PrintPerson(string name,int age=18,string company="Undefined")
{
    if(age>120||age<1)
    {
        WriteLine("Недопустимый возраст");
        return;
    }
    WriteLine($"Name: {name} Age: {age} Company: {company}");
}
PrintPerson("Ted", 35, "Azure");
PrintPerson("Ted", 354);
PrintPerson("Ted");
PrintPerson("Bred",company: "Azure", age:25);
PrintPerson(age:45,name:"Bod");
PrintPerson(company:"Yandex",name:"Jecika");


//int Sum (int x, int y) => x + y;
string GetMessage()
{
    return "hello";
}
//string GetMessage() => "Hello";
void Increment(ref int n)
{
    n++;
    WriteLine($"Число в методе Increment: {n}");
}
int number = 5;
WriteLine($"Число до метода Increment: {number}");
Increment(ref number);
WriteLine($"Число после метода Increment: {number}");

void Sum(int x,int y,out int result)
{
    result = x + y;
}
int b;
Sum(12,15,out b);
WriteLine(b);*/
/*void Sum(int initialValue, params int[] numbers)
{
    int resualt = initialValue;
    foreach(var n in numbers)
        resualt += n;
    WriteLine(resualt);
}
int[] nums = { 1, 2, 3, 4, 5 };
Sum(10,nums);
Sum(1, 2, 3, 4);
Sum(1, 2, 3);
Sum(20);
WriteLine("*********************************");
void Sum1(int[] numbers,int initialValue)
{
    int resualt = initialValue;
    foreach (var n in numbers)
        resualt += n;
    WriteLine(resualt);
}
int[] nums1 = {1,2,3,4,5};
Sum1(nums1, 15);*/
/*//int Factorial(int n)
//{
//    if (n == 0) return 1;
//    if (n == 1) return 1;
//    return n*Factorial(n-1);
//}
//int Fibonachi(int n)
//{
//    if(n==0||n==1) return n;
//    return Fibonachi(n-1)+Fibonachi(n-2);
//}

//int Sum(int[]numbers)
//{
//    int limit = 0;
//    int result = 0;
//    foreach (int n in numbers)
//        if (IsPassed(n)) 
//            result += n;
//    return result;
//    bool IsPassed(int number)
//    {
//        return ((number > limit)&&(number%2==0));
//    }
//}

//int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7 };
//int[] numbers2 = { -3, -99, 100, 25, 66, 45, -34 };
//WriteLine(Sum(numbers1));
//WriteLine(Sum(numbers2));
//int DoOperation(int op,int a, int b)
//{
//    int resualt = op switch
//    {
//        1 => a + b,
//        2 => a - b,
//        3 => a * b,
//        _ => 0
//    };
//    return resualt;
//}
//WriteLine(DoOperation(1, 4, 7));
//WriteLine(DoOperation(2, 5, 6));
//WriteLine(DoOperation(3, 7, 8));
//WriteLine(DoOperation(0,7, 9));
//long f = Factorial(15);
//int f2 = Factorial(10);
//int f3 = Factorial(6);

//WriteLine($"Факториал числа 15 = {f}");
//WriteLine($"Факториал числа 10 = {f2}");
//WriteLine($"Факториал числа 6 = {f3}");
//int fib=Fibonachi(40);
//WriteLine(fib);
///* int result=op switch{
// * 1=>a+b;
// * 2=>a-b;
// * 3=a*b;
// * _=>0;
// * 
// * /

/*Human ted = new ();
Human bred= new ("Bred");
Human sam = new("Sam", 25);
ted.Print();
bred.Print();
sam.Print();*/

class Program
{

    static void Main()
    {
        /* //Human ted = new Human { name = "Ted", age = 34, company = { title = "Azure" } };
         //(string name, int age, Company company) = ted;
         //WriteLine($"{name} {age} {company}");
         //ted.Print();
         //Human1 ted1 = new();
         //Human1 test = ted1 with { name = "Test" };
         //ted1.Print();
         //test.Print();
         //Calculate(5);
         //State state1=new State();
         //Country country1=new Country();
         //State state2=new State();
         //Country country2=new Country();
         //state2.x = 1;
         //state2.y=2;
         //state1 = state2;
         //state2.x = 15;
         //WriteLine(state1.x);
         //WriteLine(state2.x);

         //country1.x = 1;
         //country1.y = 9;
         //country2 = country1;
         //country2.x = 23;
         //country1.x = 55;
         //WriteLine(country2.x);
         //WriteLine(country1.x);
         //state2.country.x = 1;
         //state1=state2;
         //state1.country.x = 9;*/

        Human h = new Human { Name = "Ted", age = 23 };
        ChangeHuman( h);

        WriteLine(h.Name);
        WriteLine(h.age);

        Animal jake = new("Jake");
        jake.Print();

        void ChangeHuman( Human human)
        {
            human.Name = "Alice";
            human.age = 25;
            human = new Human { Name = "Tom", age = 33 };
            WriteLine(human.Name);
            WriteLine(human.age);
        }

    }
    
    static void Calculate(int t)
    {
        object x = 6;
        int y = 7;
        int z = y + t;
    }
}

namespace Base
{
    class Animal
    {
        string name;
        public Animal(string name)=>this.name = name;
        public void Print()=>WriteLine($"Имя: {name}");
    }
}
class Human
{
    public string Name = "";
    public int age;
}
struct State
{
    public int x;
    public int y;
    public Country country;
    public State()
    {
        x = 0;
        y =0;
        country = new Country();
    }
}
class Country
{
    public int x;
    public int y;
}



struct Human1
{
    public string name;
    public int age;
    public Human1() : this("Ted") { }
    public Human1(string name) : this(name, 18) { }
    public Human1(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => WriteLine($"Имя: {name} Возраст: {age}");
}