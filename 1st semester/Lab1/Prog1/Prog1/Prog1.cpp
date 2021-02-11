#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    double x, E, kont, sum = 1;
    cout << "Введите x = ";
    cin >> x;
    cout << "Введите E = ";
    cin >> E;
    double a = 1;
    int i = 0;

    while (abs(a) > E) {
        a *= -x * x * (2 * i + 3) / ((2 * i + 1) * (2 * i + 1) * (2 * i + 2));
        i++;
        sum += a;
    }

    kont = cos(x) - x * sin(x);

    cout << "Сумма ряда = " << sum << endl << "Контрольное значение = " << kont << endl;

    if (abs(sum - kont) < E) cout << "Вычисления верны" << endl;
    else cout << "Вычисления не верны" << endl;
    return 0;
}