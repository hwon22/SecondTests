using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class22_2
    {
        //22.2 매개변수와 반환

        //메서드는 코드를 줄여줘 따로 빼내어 게산처리 쉽게 ->리팩토링
        class Test
        {
            public int Sum(int min,int max)
            {
                int output = 0;
                for(int i =min; i<=max; i++)
                {
                    output += i;
                }
                return output;
            }

            public int Mul(int min, int max)
            {
                int output = 1; //곱셈 계산일 경우 무조건 누적 초기값이 1이어야함
                for(int i=min; i<=max; i++)
                {
                    output *= i;
                }
                return output;
            }
        }
        static void Main22(string [] args)
        {
            Test test = new Test();
            test.Sum(1,10); //따로 출력문을 작성하지 않으면 반환했다고 나오지 않아 결과가
            Console.WriteLine(test.Sum(1, 100));
            Console.WriteLine(test.Mul(1, 10));
        }
    }
}
