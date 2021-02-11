#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
    string tmp_str;
    double sum = 0;
    double max_of_neg;
    vector<double> vec, vec2;
    cout << "Input values of 1st list (STOP = end):" << endl;
    while (1)
    {
        cin >> tmp_str;
        if (tmp_str != "STOP")
        {
            vec.push_back(stod(tmp_str));
        }
        else break;
    }
    
    sort(vec.begin(), vec.end());

    int i = 0;
    if (!vec.size())
    {
        perror("Empty vector");
        exit(1);
    }
    while (i < vec.size())
    {
        if (vec[i] < 0) i++;
        else break;
    }
    if (i != 0)
    {
        max_of_neg = vec[i - 1];
        cout << "Max of negative elements: " << max_of_neg << endl;
    }
    else cout << "No negative elements" << endl;
    
    for (i = 0; i < vec.size(); i++)
    {
        sum += vec[i];
    }
    cout << "Average value of 1st list: " << sum / vec.size() << endl;


    cout << "Input values of 2st list (STOP = end):" << endl;
    while (1)
    {
        cin >> tmp_str;
        if (tmp_str != "STOP")
        {
            vec2.push_back(stod(tmp_str));
        }
        else break;
    }

    sort(vec2.begin(), vec2.end());

    if (!vec2.size())
    {
        perror("Empty vector");
        exit(1);
    }
    i = 0;
    while (i < vec2.size())
    {
        if (vec2[i] < 0) i++;
        else break;
    }

    if (i != 0)
    {
        max_of_neg = vec2[i - 1];
        cout << "Max of negative elements: " << max_of_neg << endl;
    }
    else cout << "No negative elements" << endl;

    for (i = 0; i < vec2.size(); i++)
    {
        sum += vec2[i];
    }
    cout << "Average value of 2nd list: " << sum / vec2.size() << endl;
}