using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Chart 컨트롤 관련 네임스페이스

namespace _018_Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 폼과 컨트롤 초기화
        }

        // Paint 이벤트 처리 함수: 폼이 그려질 때 실행됨
        protected override void OnPaint(PaintEventArgs e) // 코드에서 직접 차트를 그린다
        {
            // 차트 배경색 설정
            chart1.ChartAreas[0].BackColor = Color.DarkBlue;

            // --- X축 설정 ---
            chart1.ChartAreas[0].AxisX.Minimum = -20;    // 최소값
            chart1.ChartAreas[0].AxisX.Maximum = 20;     // 최대값
            chart1.ChartAreas[0].AxisX.Interval = 2;     // 눈금 간격
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;          // 눈금선 색
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash; // 점선 스타일

            // --- Y축 설정 ---
            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = 2;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // --- 첫 번째 그래프 (Series[0]) 설정: Sin(x)/x ---
            chart1.Series[0].ChartType = SeriesChartType.Line;   // 선 그래프
            chart1.Series[0].Color = Color.LightGreen;           // 선 색상
            chart1.Series[0].BorderWidth = 2;                    // 선 두께
            chart1.Series[0].LegendText = "Sin(x)/x";            // 범례 표시

            // --- 두 번째 그래프 (Series[1]) 설정: Cos(x)/x ---
            if (chart1.Series.Count == 1) // Series[1]이 아직 없으면 추가
            {
                chart1.Series.Add("Cos"); // 새 시리즈 이름 추가
                chart1.Series[1].ChartType = SeriesChartType.Line;
                chart1.Series[1].Color = Color.Orange;
                chart1.Series[1].BorderWidth = 2;
                chart1.Series[1].LegendText = "Cos(x)/x";
            }

            // --- 데이터 포인트 추가 ---
            for (double x = -20; x <= 20; x += 0.1)
            {
                // Sin(x)/x 값 계산 (x=0일 때 예외 처리는 없음)
                double y = Math.Sin(x) / x;
                chart1.Series[0].Points.AddXY(x, y); // x, y 좌표 추가

                // Cos(x)/x 값 계산
                y = Math.Cos(x) / x;
                chart1.Series[1].Points.AddXY(x, y);
            }
        }

        // 차트를 클릭했을 때의 이벤트 (현재는 사용 안 함)
        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
