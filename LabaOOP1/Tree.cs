using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP1
{
    public class Tree
    {
        private string data { get; set; }
        public List<Tree> son = new List<Tree>();

        public Tree(string data)
        {
            this.data = data;
        }
        public void Add(Tree tree)
        {
            son.Add(tree);
        }
        public void output()
        {
            int count = 1;
            if(son.Count == 0)
            {
                return;
            }
            Console.WriteLine("Name: " + this.data);
            foreach (var item in son)
            {
                Console.Write("Position: " + count);
                if (item.data == "Внучка" || item.data == "Дочка" || item.data == "Мама")
                    Console.WriteLine(", Daugther: " + item.data);
                else
                    Console.WriteLine(", Son: " + item.data);
                count++;
            }
            Console.WriteLine();
            foreach(var item in son)
            {
                item.output();
            }
        }
    }
}
