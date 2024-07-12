using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Business
{
    public class CalculatorBusiness
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Difference(int x, int y)
        {
            return x - y;
        }
    }
}
