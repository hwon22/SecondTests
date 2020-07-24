using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class21_6
    {
        //21-6. 클래스 응용

        class Student
            //변수만 가지고 있는 클래스 = 모델 클래스
        {
        
            public string name; //인스턴스 변수에 public 확률 없음
            public int grade;
         
        }

        static void Main6(string[] args)
        {
            List<Student> list = new List<Student>();
            //Student클래스를 list(List클래스의 인스턴스)에 저장하고 출력한다.
            list.Add(new Student() { name = "윤인성", grade = 1 }); //리스트와 모델 클래스 동시 초기화
            list.Add(new Student() { name = "연하진", grade = 2 });
            list.Add(new Student() { name = "윤아린", grade = 3 });
            list.Add(new Student() { name = "윤명월", grade = 4 });
            list.Add(new Student() { name = "구지연", grade = 1 });
            list.Add(new Student() { name = "김연화", grade = 2 });

            foreach(var item in list)
            {
                Console.WriteLine(item.name + ":" + item.grade);
            }

            /*
            foreach(var item in list)
            {
                if (item.grade > 1)
                {
                    list.Remove(item); //list는 foreach반복문으로 요소제거 불가능 ->오류
                }
            }
            */
            /*
            for(int i=0; i<list.Count; i++)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                    //removeat은 지점을 받아 삭제함 -> 제거되지만 다르게 작동 -> list요소가 삭제되면서 인덱스 밀림
                    //->역for반복문 사용
                }
            }
            */

            for(int i=list.Count-1; i>=0; i--)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                    //제대로 학년이 1 초과인 item삭제됨
                }
            }

            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine(item.name + ":" + item.grade);
            }
        }
    }
}
