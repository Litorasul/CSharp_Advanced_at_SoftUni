using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Box<T>
    {
        public List<T> List { get; set; }

        public Box()
        {
            List = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in List)
            {
                result.Append($"{item.GetType()}: {item}{Environment.NewLine}");
            }

            return result.ToString();
                      
        }
    }
}
