using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Box<T> 
        where T : IComparable<T>
    {
        public List<T> List { get; set; }

        public List<T> GreaterElements { get; set; }

        public Box()
        {
            List = new List<T>();
            GreaterElements = new List<T>();
        }

        public void GreaterThan(T element)
        {
            foreach (var item in List)
            {
                if (item.CompareTo(element) == 1)
                {
                    GreaterElements.Add(item);
                }
            }
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
