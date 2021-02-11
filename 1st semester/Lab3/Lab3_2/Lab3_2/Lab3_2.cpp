#include <iostream>
#include <string>
using namespace std;

typedef struct queue_elem
{
    int value;
    struct queue_elem* prev;
} queue_elem;

typedef struct queue
{
    size_t size;
    queue_elem* front;
    queue_elem* back;

} queue;

int size(queue* q)
{
    return q->size;
}

int empty(queue* q)
{
    return q->size == 0 ? 1 : 0;
}

int back(queue* q)
{
    if (!empty(q)) return q->back->value;
    else
    {
        printf("Queue is empty\n");
        return 0;
    }
}

void pop(queue* q)
{
    if (empty(q)) return;
    queue_elem* tmp;
    tmp = q->back;
    q->back = q->back->prev;
    free(tmp);
    q->size--;
}

void push(queue* q, char value)
{
    queue_elem* new_elem = new queue_elem;
    if (empty(q))
    {
        q->front = new_elem;
        q->back = new_elem;
        new_elem->value = value;
        new_elem->prev = NULL;
        q->size++;
        return;
    }
    q->front->prev = new_elem;
    q->front = new_elem;
    new_elem->prev = NULL;
    q->front->value = value;
    q->size++;
}

void queue_init(queue* q)
{
    q->size = 0;
    q->front = NULL;
    q->back = NULL;
}


void queue_del(queue* q)
{
    if (empty(q)) return;
    queue_elem* tmp;
    while (q->back->prev != NULL)
    {
        tmp = q->back;
        q->back = q->back->prev;
        delete tmp;
    }
    delete q->back;
}


/////////////////////////////////////////// Добавляет в отсортированную очередь элемент на своё место
void sorted_insert(queue* q, int value)
{
    queue q2;
    queue_init(&q2);
    while (!empty(q) && q->back->value < value)
    {
        push(&q2, q->back->value);
        pop(q);
    }
    if(!empty(q))
    {
        if (q->back->value != value)
        {
            push(&q2, value);
        }
        else
        {
            cout << "Element " << value << " is already in queue\n";
        }
    }
    else
    {
        push(&q2, value);
    }

    while (!empty(q))
    {
        push(&q2, q->back->value);
        pop(q);
    }
    while (!empty(&q2))
    {
        push(q, q2.back->value);
        pop(&q2);
    }
    queue_del(&q2);
}

/////////////////////////////////////////// Сортирует очередь
void queue_sort(queue* q)
{
    queue q2;
    queue_init(&q2);
    while (!empty(q))
    {
        sorted_insert(&q2, q->back->value);
        pop(q);
    }
    while (!empty(&q2))
    {
        push(q, q2.back->value);
        pop(&q2);
    }
    queue_del(&q2);
}

int main()
{
    queue q;
    queue_init(&q);
    
    string tmp;
    int tmp_int;
    cout << "Input numbers. \"STOP\" to end\n";
    cin >> tmp;
    while (tmp != "STOP")
    {
        tmp_int = stoi(tmp);
        sorted_insert(&q, tmp_int);
        cin >> tmp;
    }
    
    //queue_sort(&q);

    cout << "Sorted queue:\n";
    while (!empty(&q))
    {
        cout << back(&q) << " ";
        pop(&q);
    }
    cout << endl;
    queue_del(&q);
}