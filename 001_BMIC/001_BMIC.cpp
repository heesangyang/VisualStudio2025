#include <stdio.h>
int main()
{
    double h; // Ű
    double w; // ü��

    printf("Ű(cm) : ");
    scanf_s("%lf", &h);
    printf("ü��(kg) : ");
    scanf_s("%lf", &w);

    h /= 100; // m�� ȯ��

    double bmi = w / (h * h);
    printf("bmi = %.2lf\n", bmi);
}