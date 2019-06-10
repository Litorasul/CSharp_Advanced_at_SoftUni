using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.DateModifier
{
    public class DateModifier
    {
        private int dateDifference;

        public DateModifier(string dateOne, string dateTwo)
        {
            int[] first = dateOne
             .Split().Select(int.Parse).ToArray();
            DateTime firstDate = new DateTime(first[0], first[1], first[2]);
            int[] second = dateTwo
             .Split().Select(int.Parse).ToArray();
            DateTime secondDate = new DateTime(second[0], second[1], second[2]);

            if (firstDate > secondDate)
            {
                dateDifference = (firstDate - secondDate).Days;
            }
            else
            {
                dateDifference = (secondDate - firstDate).Days;
            }

        }

        public int TheDifferance()
        {
            return dateDifference;
        }

    }
}
