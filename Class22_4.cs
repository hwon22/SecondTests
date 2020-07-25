using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class22_4
    {
        //22-4.오버로딩

        //오버로딩은 메서드의 이름은 같게 매개변수는 다르게 해서 생성
        //ex.Math.Abs(정수/실수...)
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) return -input;
                else return input;
            }
            public static double Abs(double input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
            public static long Abs(long input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            /*public static double Abs(int input)
                //동일한 매개변수 형식을 가진 Abs 멤버를 미리 정의
                //일부만 값을 반환한다.
                //->호출시 어떤 걸 부르는 지 몰라
                //호출이 클래스.메서드(매개변수)인데 매개변수가 같으니까
            {
                if (input < 0) { return -input; }
                else { return input; }
            }*/
        }

        public static void Main24(string[] args)
        {
            //int
            Console.WriteLine(MyMath.Abs(-589));
            Console.WriteLine(MyMath.Abs(589));

            //double
            Console.WriteLine(MyMath.Abs(53.323));
            Console.WriteLine(MyMath.Abs(-53.323));

            //long
            Console.WriteLine(MyMath.Abs(5212414534515134515));
            Console.WriteLine(MyMath.Abs(-5212414534515134515));
        }
    }
}
