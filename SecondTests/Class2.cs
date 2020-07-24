using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class FirstClass
    {

    }
    class SecondClass
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //21-3. 클래스 생성

            //Main 클래스가 있는 Program 클래스 밖에서
            //class FirstClass{} class SecondClass() 식으로 생성하면 Main클래스 안에서 사용가능
            //-> 하나의 파일에 여러 개의 클래스 생성하기

            //Program 클래스 안에 class FirstClass{}, class SecondClass{}, Main클래스 모두 생성가능
            //-> 클래스 내부에 클래스 생성하기

            //가장 일반적인 파일 생성 시 생기는 클래스(이름 변경가능, 일반적으로 같게)
            //기존에 있는 클래스와 이름 겹치면 충돌해 (ex. Math클래스)
            //-> 서로 다른 파일에 클래스 생성하기
            
        }
    }
}
