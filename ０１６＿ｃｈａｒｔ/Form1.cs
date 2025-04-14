using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _０１６＿ｃｈａｒｔ
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            chart1.Titles.Add("성적");

            for (int i = 0; i < 10; i++)
            {
                chart1.Series[0].Points.Add(r.Next(101));
            }
            chart1.Series[0].LegendText = "비주얼\n프로그래밍";

            //Random 클래스의 객체r을 만든다. Random r = new Random(); 교수님왈 : 매우 중요하다.
            //Car 클래스의 객체 car를 만든다. Car car = new Car();



        }
    }
}
