#include <iostream>
#include <vector>
#include <string>
using namespace std;

template <typename T> 
T avg_counter(vector<T> vec)
{
    T sum = 0, avg;
    if (!vec.size())
    {
        perror("Division by ZERO");
        exit(1);
    }

    for(int i = 0; i < vec.size(); i++)
    {
        sum += vec[i];
    }
    return sum / vec.size();
}

int main()
{
    string tmp_str;

    vector<int> vec_i;
    cout << "Input Integers (STOP = end):" << endl;
    while (1)
    {
        cin >> tmp_str;
        if (tmp_str != "STOP")
        {
            vec_i.push_back(stoi(tmp_str));
        }
        else break;
    }
    cout << "Average value: " << avg_counter(vec_i) << endl;

    vector<double> vec_d;
    cout << "Input Doubles (STOP = end):" << endl;
    while (1)
    {
        cin >> tmp_str;
        if (tmp_str != "STOP")
        {
            vec_d.push_back(stod(tmp_str));
        }
        else break;
    }
    cout << "Average value: " << avg_counter(vec_d) << endl;
}