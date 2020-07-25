using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    /*
    class Class22_5
    {
        //22-5. 접근제한자

        //접근제한자는 변수나 메서드 맨앞에, private 와 public
        //private 접근제한자 -> 기본적으로 제시X private 설정
        //-> 자신의 클래스 내부에서만 접근되고 아니면 오류
        //public 접근제한자 -> 다른 클래스에서도 접근이 가능함
        //근데 보안상 외부에서 접근해도 괜찮은 것만 public 주고 나머지는 private 주자
        public void TestMethod()
        {
            Program22_5.Main(new string[] { "" });
            //보호수준때문에 접근할수없어! Main메서드는 private야!
        }
    }
    class Program22_5
    {
        public static void Main(string[] args)
            //public을 제시해주면 다른 클래스에서도 접근이 됨.
        {

        }
    }
    */
   class Program22_5
    {
        class P22_5
        {
            public void TestMethod()
            {
                Program22_5.Main22_5(new string[] { "" });
                    //내부클래스의 메서드에서 접근이 가능함
            }
        }

        public void TestMethod()
        {
            Program22_5.Main22_5(new string[]{""});
                    //자신의 클래스가 가진 메서드에서도 접근가능
        }

        static void Main22_5(string[] args)
            //private인데
        {

        }
    }
}
