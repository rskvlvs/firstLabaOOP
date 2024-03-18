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
        public List<string> output()
        {
            var list = new List<string>();

            list.Add(data);

            if (son.Count == 0)
            {
                return list;
            }

            foreach (var item in son)
            {
                list.AddRange(item.output());
            }
            
            return list;
        }
    }
}
