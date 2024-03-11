// See https://aka.ms/new-console-template for more information
namespace LabaOOP1 {
    class Program
    {
        static void Main()
        {
            TimeEuro timeEu = new(); 
            TimeUS timeUS = new();
            Console.WriteLine(timeEu.ShowTime()); 
            Console.WriteLine(timeUS.ShowTime());
            TimeEuDecorator timeEuDecorator = new TimeEuDecorator(new TimeEuro());
            TimeUSDecorator timeUSDecorator = new TimeUSDecorator(new TimeUS());
            Console.WriteLine(timeEuDecorator.ShowTime());
            Console.WriteLine(timeUSDecorator.ShowTime());

            Console.WriteLine("Вывод дерева: ");
            Tree first = new Tree("Прадед");
            Tree second = new Tree("Дед");
            Tree third = new Tree("Отец");
            Tree fourth = new Tree("Сын");
            Tree fifth = new Tree("Внучка");

            first.Add(second);
            first.Add(third);
            first.Add(fourth);
            first.Add(fifth);
            second.Add(third);
            second.Add(fourth);
            second.Add(fifth);
            third.Add(fourth);
            third.Add(fifth);
            fourth.Add(fifth);
            first.output();
        }
    }
}

