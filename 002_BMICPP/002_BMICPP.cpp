#include <iostream>
using namespace std;

int main()
{
    double h, w;

    cout << "Ű(cm) : ";
    cin >> h;
    cout << "ü��(kg) : ";
    cin >> w;

    h /= 100;

    double bmi = w / (h * h);
    cout << "BMI = " << bmi << endl;
}