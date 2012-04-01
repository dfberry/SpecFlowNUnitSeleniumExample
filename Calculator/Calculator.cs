using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Calculator
{
    public class Calculator
    {
        public List<int> numbers = new List<int>();
        public int sum = 0;

        public void Add(int number)
        {
            numbers.Add(number);
        }
        public void Sum()
        {
            // DFB: introduced Error Here on purpose
            sum = numbers.Sum()+10 ;
        }
        public int Total()
        {
            return sum;
        }
    }
}
