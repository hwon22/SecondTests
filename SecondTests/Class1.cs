using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class ClassUse
    {

        static void oneMain(string[] args)
        {
            //21-2. 클래스 사용

            //Random 클래스
            Random random = new Random(); //인스턴스 생성
            //인스턴스 이름 뒤에 점 찍고 사용(=인스턴스멤버) -> 인스턴스 메서드(인스턴스 변수, 인스턴스 속성)
            Console.WriteLine(random.Next());
            //범위 제한 없는 양수의 랜덤 값 
            Console.WriteLine(random.Next(4,6));
            //제한된 범위 안의 랜덤 값
            Console.WriteLine(random.Next(3));
            //3안의 랜덤 값
            Console.WriteLine(random.NextDouble());
            //0.XX 의 랜덤 실수 값
            Console.WriteLine(random.NextDouble() * 10);
            //0.XX ~9.XX 의 랜덤 실수 값

            Console.WriteLine();

            //List 클래스
            List<int> list = new List<int>(); 
            //선언 자료형표시에 <>제네릭 사용
            list.Add(23);
            //리스트 요소 생성
            list.Add(52);
            list.Add(110);
            //list 요소 값 찾기
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
                /* 
                   Count: 3     item: 23
                   Count: 3     item: 52
                   Count: 3     item: 110
                */
            }

            Console.WriteLine(); // 줄바꿈

            //list 번호와 값 출력하기
            for (int i = 0; i < list.Count; i++) //배열은 0부터 세기 때문에 012 칸 까지 사용, 따라서 범위는 i<list.Count
            {
                Console.WriteLine("item_Number: " + i + "\titem_Value: " + list[i]); //list로 찍어버리면 list의 값을 담는 공간이 없어서 그냥 리스트정보? 같은 것 나옴
                /* 
                 Count: 0     item: 23
                 Count: 1     item: 52
                 Count: 2     item: 110
                */
            }

            Console.WriteLine(); // 줄바꿈
            
            List<int> list2 = new List<int>() { 52, 23, 10, 2 };
            //list 클래스 선언과 동시에 초기화하기
            foreach (var item in list2)
            {
                Console.WriteLine("Count: " + list2.Count + "\titem: " + item);
                /* 
                Count: 4     item: 52
                Count: 4     item: 23
                Count: 4     item: 10
                Count: 4     item: 2
               */
            }

            Console.WriteLine();

            List<int> list3 = new List<int>();
            list3.Add(22);
            list3.Add(33);
            list3.Add(44);
            list3.Add(55);

            list3.Remove(33); //list 요소 삭제

            foreach (var item in list3)
            {
                Console.WriteLine("Count: " + list3.Count + "\titem: " + item);
                /* 
                Count: 3     item: 22
                Count: 3     item: 44
                Count: 3     item: 55
               */
            }

            Console.WriteLine();

            //Math 클래스 -> 인스턴스 생성 X 클래스이름에 점 찍고 멤버 사용(=클래스멤버) 클래스메서드, 클래스변수, 클래스속성
            Console.WriteLine(Math.Abs(-52273));
            //절댓값을 구함 52273
            Console.WriteLine(Math.Ceiling(52.1));
            //크거나 같은 최소 정수 53
            Console.WriteLine(Math.Floor(52.1));
            //작거나 같은 최대 정소 52
            Console.WriteLine(Math.Max(52, 1));
            //두 수 중에서 큰 값 52
            Console.WriteLine(Math.Min(52, 1));
            //두 수 중에서 작은 값 1
            Console.WriteLine(Math.Round(53.530));
            //반올림 54
        }

    }
}


