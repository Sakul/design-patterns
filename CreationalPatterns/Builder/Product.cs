using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Builder
{
    public class Product
    {
        private IList<string> parts;

        public Product() => parts = new List<string>();

        public void Add(string part) => parts.Add(part);

        public void Show()
        {
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
}
