using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class22_7
    {
        //22-7. 소멸자
        //소멸자(destructor): 인스턴스 변수가 더 사용되지 않아! 이럴때 객체 소멸시키며 소멸자 호출
        //가비지컬렉터에 의해 관리되어 지점이 확실하진 않음
        //클래스 이름 앞에 ~기호
        //접근 제한자 사용하지 않음
        //반환 선언 없음
        //매개변수 선언 없음
        //하나의 클래스에는 하나의 소멸자만

        //~클래스이름(){ }
        //객체가 어떤 동작을 해왔다면 소멸시 해당 동작을 정의해주어야함
        class Product
        {
            public readonly int id;//여기랑
            public string name;
            public int price;

            public Product(string name,int price)
            {
                id = 10;//여기에서만 변경가능한 readonly
                this.name = name;
                this.price = price;
            }
            ~Product()
            {
                Console.WriteLine(this.name + "의 소멸자 호출");
            }
        }
        static void Main22_7(string[] args)
        {
            Product product = new Product("과자", 1000); //과자의 소멸자 호출이 출력된다
            
            const int value = 10; //상수 생성시 const
            Console.WriteLine(value);

            //product.id = 20; //읽기 전용으로 할당불가능하다 readonly를 붙이면 변수생성, 생성자 메서드에서만 값 변경가능하다
        }
    }
}
