using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _017_Chart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 폼과 컨트롤 초기화
        }

        // 폼이 처음 로드될 때 실행되는 메서드
        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("중간고사 성적"); // 차트 제목 추가

            // Series 하나 추가 (기본으로 이미 Series[0]은 있음)
            chart1.Series.Add("Series2");

            // 레전드 텍스트 설정 (범례에 표시될 과목명)
            chart1.Series[0].LegendText = "수학";
            chart1.Series[1].LegendText = "영어";

            Random r = new Random(); // 난수 생성기

            // 0~9까지의 X값에 대해 0~100 사이의 Y값(성적)을 랜덤으로 추가
            for (int i = 0; i < 10; i++)
            {
                chart1.Series[0].Points.AddXY(i, r.Next(101)); // 수학
                chart1.Series[1].Points.AddXY(i, r.Next(101)); // 영어
            }
        }

        // 🔹 "나누어 그리기" 버튼 클릭 시 실행
        // → ChartArea를 하나 더 추가하고 Series[1](영어)을 새 영역에 분리해서 그림
        private void btnTwoChart_Click(object sender, EventArgs e)
        {
            if (chart1.ChartAreas.Count == 1) // ChartArea가 하나일 경우에만 실행
            {
                chart1.ChartAreas.Add("ChartArea2");              // 두 번째 영역 추가
                chart1.Series[1].ChartArea = "ChartArea2";        // 영어 점수를 ChartArea2에 매핑
            }
        }

        // 🔹 "합쳐 그리기" 버튼 클릭 시 실행
        // → 두 개의 ChartArea를 하나로 합침. 영어 시리즈를 다시 ChartArea1로 되돌림
        private void btnOneChart_Click(object sender, EventArgs e)
        {
            if (chart1.ChartAreas.Count == 2) // ChartArea가 2개 있을 경우에만 실행
            {
                chart1.ChartAreas.RemoveAt(1);                    // 두 번째 ChartArea 제거
                chart1.Series[1].ChartArea = "ChartArea1";        // 영어 시리즈를 다시 ChartArea1로 설정
            }
        }   
    }
}
