using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentChartApp
{
    public partial class Form1 : Form
    {
        Student[] students;

        public Form1()
        {
            InitializeComponent();
        }

        class Student
        {
            public string Name;
            public int Math;
            public int English;

            public Student(string name, int math, int english)
            {
                Name = name;
                Math = math;
                English = english;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 학생 데이터 준비
            students = new Student[3];
            students[0] = new Student("홍길동", 85, 90);
            students[1] = new Student("김영희", 92, 87);
            students[2] = new Student("이철수", 76, 95);

            LoadChart();
            ShowAverages();
        }

        private void LoadChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            chart1.ChartAreas.Add("ChartArea1");
            chart1.Titles.Add("학생 성적");

            chart1.Series.Add("수학");
            chart1.Series.Add("영어");

            chart1.Series["수학"].ChartType = SeriesChartType.Column;
            chart1.Series["영어"].ChartType = SeriesChartType.Column;

            foreach (Student s in students)
            {
                chart1.Series["수학"].Points.AddXY(s.Name, s.Math);
                chart1.Series["영어"].Points.AddXY(s.Name, s.English);
            }
        }

        private void ShowAverages()
        {
            int sumMath = 0, sumEng = 0;
            foreach (Student s in students)
            {
                sumMath += s.Math;
                sumEng += s.English;
            }

            double avgMath = sumMath / (double)students.Length;
            double avgEng = sumEng / (double)students.Length;

            label1.Text = "수학 평균: " + avgMath.ToString("F1");
            label2.Text = "영어 평균: " + avgEng.ToString("F1");
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (chart1.ChartAreas.Count == 1)
            {
                chart1.ChartAreas.Add("ChartArea2");
                chart1.Series["영어"].ChartArea = "ChartArea2";
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (chart1.ChartAreas.Count == 2)
            {
                chart1.ChartAreas.RemoveAt(1);
                chart1.Series["영어"].ChartArea = "ChartArea1";
            }
        }
    }
}
