using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class22_1
    {
        //22_1. 메서드 기본 형태

        //메서드는 입력 - 함수처리 - 리턴값 .. 메서드의 역할은 진짜 return 계산? 처리를 해줄 수 있고 메서드가 그냥 작업을 수행하기도 함
        //클래스 안에서 메서드를 생성하는데 메서드는 접근제한자 반환형 메서드이름(매개변수){}
        //메서드이름은 무조건 대문자로 시작 접근제한자는 일단 public 반환형은 메서드코드 return안하면 void
        //인스턴스를 생성한 다음 호출할 수 있음 -> 인스턴스 메서드
        class Cal
        {
            public int Plus(int x, int y) //매개변수는 여러개 가능합니다 //반환형을 맞추어 주기
            {
                return x + y;
            }
            public void Print(string s)
            {
                Console.WriteLine("안녕하세요 저는 "+s+"입니다.");
            }
            public void Print()
            {
                Console.WriteLine("안녕하세요 저는 금동동입니다.");
            }
        }

        static void Main21(string [] args)
        {
            Cal cal = new Cal(); //인스턴스생성
            Console.WriteLine("x + y = " + cal.Plus(4, 5)); //인스턴스 메서드 호출
            Console.WriteLine();
            cal.Print("홍길동");
            cal.Print();
        }
    }
    
}
