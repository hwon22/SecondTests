using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class22_9
    {
        //22-9. 참조값 복사와 참조 복사

        //값복사
        /*static void Change(int input)
        {
            input = 20;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Change(a);
            Console.WriteLine(a); //10이 나옴
        }*/

        //참조복사
        class Test
        {
            public int value = 10;
        }
        static void Change(Test input)
        {
            input.value = 20;
        }
        static void Main22_9(string[] args)
        {
            Test test = new Test();
            test.value = 10;
            Change(test);

            Console.WriteLine(test.value);
        }
    }
}
