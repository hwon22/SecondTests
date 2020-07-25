using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    /*class Class22_6
    {
        //22_6. 생성자
        //생성자: 무언가 생성할때 자동으로 호출하는 메서드
        //인스턴스 생성자: 인스턴스 생성할 때 자동 호출되는 메서드
        //이름은 클래스 이름과 같음
        //접근 제한자는 public (private와는 기능이 다름)
        //반환과 관련된 선언이 없음

        //public 클래스 이름(매개변수){}
        //인스턴스 변수 초기화 하는 역할
        public string name; //this.name은 클래스의 현재 인스턴스가 가지고 있는 name.
        public int price; //this.price는 클래스의 현재 인스턴스가 가지고 있는 price.

        public Class22_6(string name, int price) //생성자의 이름은 클래스이름과 같음
        {
            this.name = name;
            this.price = price;
        }

    }*/
    class Class22_6
    {
        class Product
        {
            public static int counter = 0; //클래스 변수
            public int id;
            public string name;
            public int price;

            public Product(string name,int price) 
                //private 로 하면 사용 불가능->정적멤버만 가질때 /팩토리 메서드에서
                //static Product() //정적 생성자(접근제한자 사용X 매개변수X ->한번만 호출(맨위)
            {
                Product.counter = counter + 1; //counter 변수를 증가시킴
                this.id = counter;
                this.name = name;

                this.price = price;
            }
        }
        static void Main22_6(string[] args)
        {
            Product product1 = new Product("감자", 2000); //Product()생성자 호출
            Product product2 = new Product("고구마", 3000);

            Console.WriteLine(product1.id + ":" + product1.name);
            Console.WriteLine(product2.id + ":" + product2.name);
            Console.WriteLine(Product.counter + " 개 생성되었습니다.");
        }
    }
}
