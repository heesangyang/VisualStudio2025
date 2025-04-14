using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_static_method
{
    // 날짜 정보를 저장하고, 윤년 및 연중 날짜 계산 기능을 제공하는 클래스
    class Date
    {
        // 인스턴스 필드: 각각의 Date 객체가 가지는 연, 월, 일
        public int year, month, day;

        // 정적 메서드: 윤년인지 판단 (클래스 이름으로 바로 호출 가능)
        public static bool IsLeapYear(int y) // 매개변수로 연도를 받음
        {
            // 윤년 조건:
            // 1. 4로 나누어지고
            // 2. 100으로는 나누어지지 않거나
            // 3. 400으로 나누어지는 해는 윤년
            return (y % 4 == 0 && y % 100 != 0) || y % 400 == 0;
        }

        // 각 월의 누적 일 수 (윤년 제외)
        // 예: 3월 1일은 59일 + 1 = 60일째
        static int[] days = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
        // 이 배열도 static이므로 클래스 이름으로 접근해야 함 (Date.days)

        // 인스턴스 메서드: 현재 객체가 나타내는 날짜의 '연중 며칠째'인지 계산
        public int DayOfYear()
        {
            // 삼항 연산자를 사용한 계산:
            // 윤년이면서 3월 이후라면 하루를 더함
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);

            // 위와 같은 내용, if문으로 풀어쓰면:
            /*
            if (month > 2 && IsLeapYear(year))
            {
                return days[month - 1] + day + 1;
            }
            else
            {
                return days[month - 1] + day;
            }
            */
        }
    }
}
