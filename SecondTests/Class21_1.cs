using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SecondTests
{
    class Class21_1
    {
        //21-1. 클래스 개요
        //C#은 객체 지향 프로그래밍 언어, 클래스 사용함

        //1. 사용자 정의 자료형
        //새로운 자료형인 클래스, 속성을 하나로 묶어서 사용.
        
        class Car //클래스 정의(사용자정의자료형)
        {
            int carNumber; //속성 넣을 수 있음
            DateTime inTime;
            DateTime outTime;
            public void SetInTime() //메서드 넣을 수 있음
            {
                this.inTime = DateTime.Now;
            }
            public void SetOutTime()
            {
                this.outTime = DateTime.Now;
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            //클래스 인스턴스 = new키워드 생성자;
            //클래스:사용자정의자료형, 대문자로 시작
            //인스턴스,객체: 사용자정의자료형을 변수로 선언한것
            //생성자: 클래스이름과같은메서드(클래스이름뒤에괄호붙은것)
            car.SetInTime();
            car.SetOutTime();
        }
    }
}
