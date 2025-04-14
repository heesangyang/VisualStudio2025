using System;

namespace _021_Class
{
    // Program 클래스: 실행 진입점 포함
    public class Program
    {
        // Date 클래스: 날짜 정보를 저장하고 출력하는 기능 제공
        class Date
        {
            // 필드: 외부에서 직접 접근할 수 없도록 private으로 선언
            private int year, month, day;

            // year 값을 설정하는 메서드 (setter)
            public void SetYear(int year)
            {
                this.year = year; // 매개변수와 필드를 구분하기 위해 this 사용
            }

            // year 값을 반환하는 메서드 (getter)
            public int GetYear()
            {
                return this.year;
            }

            // 현재 저장된 날짜(year, month, day)를 출력하는 메서드
            public void PrintDate()
            {
                Console.WriteLine("{0}년 {1}월 {2}일", year, month, day);
            }

            // 기본 생성자: 아무 값도 주지 않았을 때 기본값으로 초기화
            public Date()
            {
                year = 1;
                month = 1;
                day = 1;
            }

            // 생성자 오버로딩: 매개변수를 받아 해당 값으로 초기화
            public Date(int y, int m, int d)
            {
                year = y;
                month = m;
                day = d;
            }
        }

        // Main 메서드: 프로그램의 시작점
        static void Main(string[] args)
        {
            // 기본 생성자를 사용하여 Date 객체 생성
            Date a = new Date();
            a.SetYear(2025);                // year 값만 변경
            Console.WriteLine(a.GetYear()); // year 값 확인
            a.PrintDate();                  // 출력: 2025년 1월 1일

            // 기본 생성자 사용: 모든 값이 1로 초기화됨
            Date b = new Date();
            b.PrintDate();                  // 출력: 1년 1월 1일

            // 매개변수 생성자 사용: 원하는 날짜로 초기화
            Date c = new Date(2025, 4, 7);
            c.PrintDate();                  // 출력: 2025년 4월 7일
        }

        // 참고: public 키워드를 사용하면 다른 클래스에서도 접근 가능
    }
}
