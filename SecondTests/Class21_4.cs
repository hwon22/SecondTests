using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class21_4
    {
        //21-4. 클래스 변수
        
        /*
        class Products
        {
            //1. 인스턴스 변수 (클래스 내부생성 인스턴스와 한몸, 생성: 접근제한자 자료형 이름, 사용: 인스턴스.변수이름)
            public string name;
            public string password;
            public string address="인천광역시 미추홀구 땡땡동 땡땡-땡땡"; 
            //인스턴스 변수 생성 시 초기화
            
        }

        static void Main4(string[] args)
        {
            Products products = new Products();
            //인스턴스 생성
            products.name = "감자"; 
            //인스턴스 변수에 값 할당
            products.password = "감자잉";

            Console.WriteLine(products.name + "의 비밀은 " + products.password); 
            //인스턴스 변수 사용하기
            Console.WriteLine(products.address);


            Products products2 = new Products() { name= "왕감자",password= "왕왕감자"};
            //씨샵문법 - 생성자 생성 없이 인스턴스 변수 생성과 동시에 초기화

            Console.WriteLine(products2.name + "의 비밀은 " + products2.password);
        }
        */

        class myMath
        {
            //2. 클래스 변수 (인스턴스 필요X, 생성: 접근제한자 static 자료형 이름)
            public static string p1 = "왕고구마";
        }
        static void Main4(string[] args)
        {
            Console.WriteLine(myMath.p1);
        }

    }
}
