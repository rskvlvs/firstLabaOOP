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
            Tree second = new Tree("\tДед");
            Tree third = new Tree("\t\tОтец");
            Tree fourth = new Tree("\t\t\tСын");
            Tree fifth = new Tree("\t\t\t\tВнучка");

            first.Add(second); // прадед дед
            first.Add(third); // прадед отец
            first.Add(fourth); // прадед сын
            first.Add(fifth); // прадед внучка

            second.Add(third); // прадед дед отец 
            second.Add(fourth); // прадед дед сын прадед отец внучка
            second.Add(fifth); // прадед дед внучка

            third.Add(fourth);
            third.Add(fifth);

            fourth.Add(fifth);

            List<string> result = first.output();
            foreach(string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

