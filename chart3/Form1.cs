using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Student 클래스 정의
        class Student
        {
            public string Name;
            public int Score;

            public Student(string name, int score)
            {
                Name = name;
                Score = score;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 차트 설정
            chart1.Series.Clear(); // 혹시 Series 남아 있으면 초기화
            chart1.Series.Add("수학");
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Titles.Add("학생 성적");

            // 객체 배열로 학생 3명 생성
            Student[] students = new Student[3];
            students[0] = new Student("홍길동", 85);
            students[1] = new Student("김영희", 92);
            students[2] = new Student("이철수", 76);

            int total = 0;
            int max = 0;

            // 차트에 데이터 추가 + 최고점/합계 계산
            foreach (Student s in students)
            {
                chart1.Series[0].Points.AddXY(s.Name, s.Score);
                total += s.Score;
                if (s.Score > max)
                    max = s.Score;
            }

            // 평균 계산
            double avg = total / (double)students.Length;

            // 라벨 출력 (Label1 = 최고점, Label2 = 평균)
            label1.Text = "최고점: " + max;
            label2.Text = "평균: " + avg.ToString("F1");
        }
        }
    }

}
}
