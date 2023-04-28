using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsClassPrblm
{
    public class Overloadding
    {
        //Polymorphism=it means many forms.
        //There are two types-1)Run time:Method overriding 2)Compile time:Method overloading.
        public class OverLoading
        {
            //It will contain many methods with same name and different parameters.
            public void MethodOne()
            {
                Console.WriteLine("Without parameter");
            }
            public void MethodOne(int num)
            {
                Console.WriteLine("With one parameter");
            }
            public void MethodOne(string str, int num)
            {
                Console.WriteLine("With two parameters");

            }

        }
    }
}
