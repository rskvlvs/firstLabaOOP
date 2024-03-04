// See https://aka.ms/new-console-template for more information
namespace LabaOOP1 {
    class Program
    {
        static void Main()
        {
            drobi first = new drobi(4, 3);
            drobi second = new drobi(3, 5);
            drobi test = new drobi(12, 15);
            drobi res = first * second;
            Console.WriteLine("result: " + res.ToString());
            Console.WriteLine("result: " + first.ToString());
            res = second - first;
            Console.WriteLine("result: " + res.ToString());
            Console.WriteLine(first != second);
            Console.WriteLine(first == second);
            Console.WriteLine(first > second);
            Console.WriteLine(first < second);
        }
    }
}

