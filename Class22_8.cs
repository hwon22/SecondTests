using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class22_8
    {
        //22-8. 속성
        //외부에서 값이 막 변경되지 않으려면 -> 캡슐화를 한다 public 을 private으로 바꾸는거임
        //그러면 인제 아예 변경이 안됨 -> get set메소드로 한다
        //그러면 너무 소스가 길다 -> C#의 속성 기능을 사용한다
        
        //생성은 private int 변수이름; public int 속성이름{ 
        //                                                  get{return 변수이름;}
        //                                                  set{변수이름=value;}
        //                                                 }

        //사용은 인스턴스이름.속성이름 //겟터호출
        //       인스턴스이름.속성이름=값 //셋터호출

        //속성은 공구기호모양 대문자로 시작함

        class Box
        {
            private int width;
            public int Width
            {
                get { return width; }
                set
                {
                    if (value > 0) { width = value; }
                    else { Console.WriteLine("너비는 자연수를 입력해주세요");  }
                }
            }
            private int height;
            public int Height
            {
                get { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { Console.WriteLine("높이는 자연수를 입력해주세요."); }
                }
            }

            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }
            

            public int Area() { return this.width * this.height; }

            static void Main22_8(string[] args)
            {
                Box box = new Box(-10, -20); //너비는 자연수를 입력해주세요, 높이는 자연수를 입력해주세요
               // box.Width = -200;
               // box.Height = -100;
            }

        }
    }
}
