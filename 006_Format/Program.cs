namespace _006_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("안녕하세요!!  C#입니다.");
            Console.WriteLine("10이하의 소수 : {0} {1} {2} {3}", 2, 3, 5, 7);
            //서식 문자열 (format string) 을 사용해서 여러 개의 값을 출력하는 방법이야.
            string s
                = string.Format("10이하의 소수 : {0} {1} {2} {3}", 2, 3, 5, 7);
            Console.WriteLine(s);
            //string.Format() 을 사용하면 문자열을 조합해서 변수에 저장할 수 있어.
            //s 변수에 "10이하의 소수 : 2 3 5 7"라는 문자열이 저장된 후 출력돼.

            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2); //에러
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");

            double x = 1234.5678;
            Console.WriteLine("{0:C}", x); //통화 형식으로 출력
            Console.WriteLine("{0:E}", x); //지수 형식으로 출력
            Console.WriteLine("{0:F2}", x); //고정 소수점 형식으로 출력
            Console.WriteLine("{0:N2}", x); //넘버를 두자릿수까지. 천단위 구분 기호
            Console.WriteLine("{0:#,#.##}", x); //숫자를 #로 표시하고 ,와 .을 넣어줌
        }
    }
}
//문자열 하나를 만들어서 출력해야한다.
//1.문자들을 더해서 하나로 만든다.
//2.$를 쓰면 괄호안의 변수를 직접 써서 사용해도 된다.
//3.서식 문자열 사용. {0}은 첫번째 변수, {1}은 두번째 변수를 의미한다.