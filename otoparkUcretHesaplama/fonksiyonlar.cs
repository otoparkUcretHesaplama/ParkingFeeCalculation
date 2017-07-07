using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFeeCalculation
{
    class function
    {
        public class StringOperations
        {
            private char[] _number = new char[10]
       {
           '1','2','3','4','5','6','7','8','9','0'
       };
            public int allNumber(string str)
            {

                if (string.IsNullOrEmpty(str)) return 0;
                else
                {
                    foreach (char item in str)
                        if (_number.Where(p => p == item).Count() > 0) continue;
                        else return 2;

                    return 1;

                }
            }
        }
    }
}
