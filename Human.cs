using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Human
    {
       
            public string name ;
            public int age;
            public Company company;
            /*//public Human() 
            //{
            //    Console.WriteLine("Создание объекта");
            //name = "Ted";
            //age = 30;
            //}
            //public Human(string n) { name = n;  age = 18; }
            //public Human(int n,string a) { name = a;age = n; }*/
            /*public Human():this ("Неизвестно")
            { }
            public Human(string name) : this(name, 18) { }
            public Human(string name, int age) 
             {
                 this.age = age;
                 this.name = name;
                 company = new Company();
             }*/
            public Human()
            {
            name = "undefined";
            age = 0;
            company = new Company();
            }
        public void Deconstruct(out string humanName, out int humanAge, out Company humanCompany)
        {
            humanName = name;
            humanAge = age;
            humanCompany = company;
        }

        public void Print()=>  Console.WriteLine($"Имя: {name} Возраст:{age} Компания: {company.title}");
            
        
    }
    class Company
    {
        public string title = "Unknow";
        public void Deconstruct(out string companyTitle)
        {
            companyTitle = title;
        }
        public override string ToString()
        {
            return title;
        }
    }
}
