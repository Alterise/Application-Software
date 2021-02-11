#include <iostream>
#include <fstream>
#include <vector>
#include <random>
#include <string>
#include <time.h>

using namespace std;

template <class T> class Stack
{
private:
    struct elem
    {
        T value;
        elem *next;
    };
    int size_var;
    elem *top_p;
public:
    Stack()
    {
        size_var = 0;
        top_p = nullptr;
    }

    ~Stack()
    {
        elem* tmp = top_p, * tmp2;
        if (size_var != 0)
            while (tmp != nullptr)
            {
                tmp2 = tmp;
                tmp = tmp->next;
                delete tmp2;
            }
        size_var = 0;
    }

    void clear()
    {
        elem* tmp = top_p, * tmp2;
        if (size_var != 0)
        while (tmp != nullptr)
        {
            tmp2 = tmp;
            tmp = tmp->next;
            delete tmp2;
        }      
        size_var = 0;
    }

    bool empty()
    {
        return !size_var;
    }

    int size()
    {
        return size_var;
    }

    void push(T value)
    {
        elem* element = new elem;
        element->next = top_p;
        element->value = value;
        top_p = element;
        size_var++;
    }

    void pop()
    {
        elem* tmp = top_p;
        top_p = top_p->next;
        size_var--;
        delete tmp;
    }

    T top()
    {
        return top_p->value;
    }
};

void random_generator(int count, string filename, int lb, int rb)
{
    ofstream f_out(filename);
    for (int i = 0; i < count; i++)
    {
        f_out << rand() % (rb - lb + 1) + lb << " ";
    }
    f_out.close();
}

template <typename T>
T avg_counter(vector<T> vec)
{
    T sum = 0, avg;
    if (!vec.size())
    {
        perror("Division by ZERO");
        exit(1);
    }

    for (int i = 0; i < vec.size(); i++)
    {
        sum += vec[i];
    }
    return sum / vec.size();
}



int main()
{
    cout << "Part 7.2" << endl << endl;
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
    else cout << "No ones in input" << endl;

    cout << "Part 7.3" << endl << endl;

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