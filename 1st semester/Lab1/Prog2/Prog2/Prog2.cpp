#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    double A, B, E, x, f, fx;
    cout << "Введите A = ";
    cin >> A;
    cout << "Введите B = ";
    cin >> B;
    cout << "Введите E = ";
    cin >> E;

    while (abs(A - B) > E) {
        f = 1 / (pow(A, 2 / 3) + 0.7 * sin(A) - log(A + 1)) - A;    
        x = (A + B) / 2;
        fx = 1 / (pow(x, 2 / 3) + 0.7 * sin(x) - log(x + 1)) - x;
        if (f * fx > 0) {
            A = x;
        }
        else {
            B = x;
        }
    }
    cout << x << endl;
    return 0;
}