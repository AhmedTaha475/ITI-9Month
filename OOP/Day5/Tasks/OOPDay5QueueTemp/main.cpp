#include <iostream>

using namespace std;
template <class T>
class Queue
{
    T *queArr;
    int head,tail,Size,counter;
public:
    Queue(int _size)
    {
        Size=_size;
        queArr=new T[Size];
        tail=head=counter=0;
    }
    Queue(const Queue& old)
    {
        head=old.head;
        tail=old.tail;
        Size=old.Size;
        counter=old.counter;
        queArr =new T[Size];
        for(int i=0;i<Size;i++)
        {
            queArr[i]=old.queArr[i];
        }

    }
    ~Queue()
    {
        delete []queArr;

    }

    bool IsFull()
    {

        return counter==Size;
    }
    bool IsEmpty()
    {
        return counter==0;

    }

    void EnQ(T n)
    {
        if(!IsFull())
        {
            queArr[tail++]=n;
            counter++;
            if(tail==Size)
            {
                tail=0;
            }
        }
        else
        {
            cout<<"Queue is Full"<<endl;
        }

    }
    T DeQ()
    {
        if(!IsEmpty())
        {
            T value=queArr[head++];
            counter--;
            if(head==Size)
            {
                head=0;
            }
            return value;
        }
        else
        {
            cout<<"Queue is Empty"<<endl;
        }

    }
    T peak()
    {
        if(!IsEmpty())
        {
            return queArr[head];
        }
        else
            {
            cout<<"Queue is Empty"<<endl;
            }
    }
    int GetCount()
    {
        return counter;
    }


};
int main()
{
    Queue<double> q1(3);
    q1.EnQ(3.6);
    q1.EnQ(9.6);
    q1.EnQ(10.6);

    for(int i=0;i<3;i++)
    {
        cout<<q1.DeQ()<<",";
    }
    cout<<endl;


        Queue<char> q2(3);
    q2.EnQ('D');
    q2.EnQ('b');
    q2.EnQ('c');

    for(int i=0;i<3;i++)
    {
        cout<<q2.DeQ()<<",";
    }
    return 0;
}
