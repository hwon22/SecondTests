using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTests
{
    class Class22_10
    {
        //22-10. 메서드 응용
        //1. 재귀 메서드: 자기 자신을 호출하는 메서드
        //반드시 자기 자신을 탈출할 수 있는 종료 조건이 포함시킬 것
    }

    //인스턴스 메서드를 활용한 재귀메서드
    /*class Fibonacci
    {
        public long Get(int i)
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }
    class Program22_10
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(fibo.Get(1));
            Console.WriteLine(fibo.Get(2));
            Console.WriteLine(fibo.Get(3));
            Console.WriteLine(fibo.Get(4));
            Console.WriteLine(fibo.Get(5));
        }
    }*/
    
    //클래스 메소드를 활용한 재귀메서드
    /*class Fibonacci
    {
        public static long Get(int i)
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
            if (i == 2) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }
    class Program22_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(2));
            Console.WriteLine(Fibonacci.Get(3));
            Console.WriteLine(Fibonacci.Get(4));
            Console.WriteLine(Fibonacci.Get(5));
        }
    }*/

    //메모화 - > 한번 계산했던 값을 저장해두고 꺼내 써서 성능 올리기
    class Fibonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public static long Get(int i)
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }

            if (memo.ContainsKey(i))
            {
                return memo[i];
            }
            else
            {
                long value = Get(i - 2) + Get(i - 1);
                memo[i] = value;
                return value;
            }
        }
    }

    class Program22_10
    {
        static void Main22_10(string[] args)
        {
            Console.WriteLine(Fibonacci.Get(40));
            Console.WriteLine(Fibonacci.Get(100));
        }
    }
}
