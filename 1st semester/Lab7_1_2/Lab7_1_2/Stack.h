#include <iostream>
using namespace std;

template <class T> class Stack
{
private:
    struct elem
    {
        T value;
        elem* next;
    };
    int size_var;
    elem* top_p;
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