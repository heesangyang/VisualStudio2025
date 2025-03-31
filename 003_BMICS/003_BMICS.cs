namespace _003_BMICS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("키(cm) : ");
            string s = Console.ReadLine(); //C#에서 Read는 문자열로 받기에 double로 값을 받지 못하고
                                           //string(문자열)로 값을 받아야한다.
                                           //사용자가 "170" 문자열을 입력

            double h = double.Parse(s); //그 다음 double(실수).Parse(형 변환 s{문자열})
                                        //"170" ㅡ> 170.0 변환
            Console.Write("체중(kg) : ");
            s = Console.ReadLine();
            double w = double.Parse(s);

            h = h / 100;

            double bmi = w / (h * h);
            Console.WriteLine("BMI : " + bmi); //하나의 문자열만 쓸 수 있어 더해야한다. 왜 더해??
                                               //C#에서는 + 연산을 할 때 하나라도 string이면 나머지도 문자열로 변환된다.
        }
    }
}

