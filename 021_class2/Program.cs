using System.Net.Http.Headers;

namespace _022_Class2
{
    class Product
    {
        public string? name;
        public int price;
    }
    class MyMath
    {
        public static double PI = 3.14;
    }
    class MyCalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / weeks;
        public const double daysPerMonth = (double)days / months;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //product의 객체 p를 만들고, p의 이름은 "시계", 가격은 10만원
            Product p = new Product();
            p.name = "시계";
            p.price = 100000;

            //객체 p의 이름과 가격을 출력하시오
            Console.WriteLine(p.name);
            Console.WriteLine(p.price);

            //MyMath 객체
            MyMath m = new MyMath();
            
            //인스턴스는 객체 static은 클래스에 하나만. 객체에서 가지고 있지 않다. 그래서 m.PI는 불가능하다. 스태틱이 없으면 사용가능.
            //클래스 이름으로만 사용가능
            Console.WriteLine(MyMath.PI);
            //상수는 바꿀 수 없다. 그냥 갖다 쓸 수 있다.
            MyCalendar c = new MyCalendar();
            Console.WriteLine("{0:F3}", MyCalendar.daysPerMonth);
            //객체에 속하는 메소드 인스턴스, 클래스에 속하는 메소드 스태틱
            //instance method 객체 메소드
        }
    }
}
