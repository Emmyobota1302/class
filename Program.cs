using System;
namespace Defining{
    class Program{
        static void Main(string[] args){
            Book b1=new Book("war and peace","leo",825);
            Book b2=new Book("desire","emmy",435);
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());
            
        }
    }
}