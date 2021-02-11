#include <iostream>
#include <fstream>
#include <string>
#include <random>
#include <time.h>
#include "Stack.h"
using namespace std;

void random_generator(int count, string filename, int lb, int rb)
{
    ofstream f_out(filename);
    for (int i = 0;i < count; i++)
    {
        f_out << rand() % (rb - lb + 1) + lb << " ";
    }
    f_out.close();
}

int main()
{
    Stack<int> all, even, odd;
    string tmp_str, fname_in;
    bool is_out_in_file = 0;

    srand(time(0));
    random_generator(40, "input.txt", -20, 20);

    cout << "Input file name of input file: ";
    cin >> fname_in;
    ifstream f_in(fname_in);

    while (f_in >> tmp_str) all.push(stoi(tmp_str));

    while (!all.empty())
    {
        if (all.top() % 2) odd.push(all.top());
        else even.push(all.top());
        if (all.top() == 1) is_out_in_file = 1;
        all.pop();
    }

    if (is_out_in_file)
    {
        string fname_odd, fname_even;
        cout << "Input file name for ODD numbers: ";
        cin >> fname_odd;
        cout << "Input file name for EVEN numbers: ";
        cin >> fname_even;

        ofstream f_odd(fname_odd);
        ofstream f_even(fname_even);
        while (!odd.empty())
        {
            f_odd << odd.top() << " ";
            odd.pop();
        }
        while (!even.empty())
        {
            f_even << even.top() << " ";
            even.pop();
        }
        f_odd.close();
        f_even.close();
    }
    else cout << "No ones in input";
}