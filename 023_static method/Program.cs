using System;

namespace _023_static_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Date 클래스의 인스턴스 생성
            Date bDay = new Date();
            bDay.year = 2002;  // 생년
            bDay.month = 10;   // 생월
            bDay.day = 28;     // 생일

            // DayOfYear 메서드를 호출하여 '올해 몇 번째 날인지' 계산
            Console.WriteLine("내 생일은 {0}째 되는 날입니다.", bDay.DayOfYear());
            // 출력 예: "내 생일은 301째 되는 날입니다."

            // static 메서드는 클래스 이름으로 직접 호출 (객체 없이)
            Console.WriteLine(Date.IsLeapYear(2028));  // 윤년인지 확인 → true
        }
    }

    // 클래스이름.객체 스태틱 ← 네가 쓴 주석, 그대로 살림!
}
