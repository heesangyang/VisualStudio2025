using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//첫 번째 Control을 배치
//두 번째 Control의 속성 변경 (속성 창에서)
//솔루션 탐색기에서 

namespace _004_BMIForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //btnBMI가 Click되었을 때 생기는 이벤트 처리를 처리하는 함수
        private void btnBMI_Click(object sender, EventArgs e) //sender=버튼
        {
            double h = double.Parse(txtH.Text);
            h /= 100;

            double w = double.Parse(txtW.Text);

            double bmi = w / (h * h);

            lblBMI.Text = "bmi = " + bmi.ToString("F2");

            if (bmi < 20)
            {
                lblR.Text = "판정 : 저체중";
                PicC.BackColor = Color.Blue;
            }
            else if (bmi < 25)
            {
                lblR.Text = "판정 : 정상체중";
                PicC.BackColor = Color.Green;
            }
            else if (bmi < 30)
            {
                lblR.Text = "판정 : 과체중";
                PicC.BackColor = Color.Yellow;
            }
            else if (bmi < 35)
            {
                lblR.Text = "판정 : 비만";
                PicC.BackColor = Color.Orange;
            }
            else
            {
                lblR.Text = "판정 : 고도비만";
                PicC.BackColor = Color.Red;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
