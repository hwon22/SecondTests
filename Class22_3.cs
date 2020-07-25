using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class22_3
    {
        //22.3 클래스 메소드
        //ex.Main()메소드가 굉장히 대표적.

        //접근 제한자 static 반환형 메서드이름(매개변수){}
        //Main에서 따로 인스턴스 생성 필요 없이 클래스.메소드, 클래스.변수 식으로 호출
        class MyMath
        {
            public int myValue = 60; //인스턴스 변수
            public static int myValue2 = 60; // 클래스 변수 (static)
            public static int Abs(int input)
            {
                if (input < 0)
                    return -input;
                else
                    return input;
            }
        }
        static void Main23(string[] args)
        {
            Console.WriteLine(MyMath.Abs(500));
            //Console.WriteLine(MyMath.myValue); //인스턴스변수는 클래스메소드안에서는 실행 X
            Console.WriteLine(MyMath.myValue2);
        }
    }
}
