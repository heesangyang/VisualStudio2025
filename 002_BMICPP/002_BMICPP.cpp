#include <iostream>
using namespace std;

int main()
{
    double h, w;

    cout << "Å°(cm) : ";
    cin >> h;
    cout << "Ã¼Áß(kg) : ";
    cin >> w;

    h /= 100;

    double bmi = w / (h * h);
    cout << "BMI = " << bmi << endl;
}