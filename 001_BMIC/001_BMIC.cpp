#include <stdio.h>
int main()
{
    double h; // 키
    double w; // 체중

    printf("키(cm) : ");
    scanf_s("%lf", &h);
    printf("체중(kg) : ");
    scanf_s("%lf", &w);

    h /= 100; // m로 환산

    double bmi = w / (h * h);
    printf("bmi = %.2lf\n", bmi);
}