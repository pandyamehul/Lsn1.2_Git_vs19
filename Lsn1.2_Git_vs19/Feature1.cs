using System;
using System.Collections.Generic;
using System.Text;

namespace Lsn1._2_Git_vs19
{
    class Feature1
    {
        public void MethodPrint()
        {
            Console.WriteLine("Method 'MethodPrint' called from Feature 1 class ");
        }

        public int add()
        {
            var num1 = 10;
            var num2 = 20;
            return num1 + num2;
        }
    }
}
