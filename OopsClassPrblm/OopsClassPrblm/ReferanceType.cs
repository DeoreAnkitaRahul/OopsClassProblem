using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsClassPrblm
{
    public class ReferanceType
    {
        public void MethodReferanceType(ref int num)
        {
            num = num * num;
            Console.WriteLine(num);
        }
    }
}
