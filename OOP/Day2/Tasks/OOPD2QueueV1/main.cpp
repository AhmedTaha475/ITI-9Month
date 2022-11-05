#include <iostream>

using namespace std;

class Queue
{
    int *queArr,head,tail,Size,counter;
public:
    Queue(int _size)
    {
        Size=_size;
        queArr=new int[Size];
        tail=head=counter=0;
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

    void EnQ(int n)
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
    int DeQ()
    {
        if(!IsEmpty())
        {
            int value=queArr[head++];
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
            return -1;
        }

    }
    int peak()
    {
        if(!IsEmpty())
        {
            return queArr[head];
        }
        else
            {
            cout<<"Queue is Empty"<<endl;
        return -1;
            }
    }
    int GetCount()
    {
        return counter;
    }


};





int main()
{


Queue q1(5);
q1.DeQ();
cout<<"--------------------------"<<endl;
q1.EnQ(1);
q1.EnQ(2);
q1.EnQ(3);
q1.EnQ(4);
q1.EnQ(5);
q1.EnQ(6);
cout<<"Current Queue Count : "<<q1.GetCount()<<endl<<"-----------------------------"<<endl;

cout<<"Current Queue : "<<"1 2 3 4 5 "<<endl<<"-----------------------------"<<endl;
cout<<"First Dequeue : "<<q1.DeQ()<<endl<<"-----------------------------"<<endl;
cout<<"Peak before Second Dequeue : "<<q1.peak()<<endl<<"-----------------------------"<<endl;
cout<<"Second Dequeue : "<<q1.DeQ()<<endl<<"-----------------------------"<<endl;
cout<<"third Dequeue : "<<q1.DeQ()<<endl<<"-----------------------------"<<endl;
cout<<"Forth Dequeue : "<<q1.DeQ()<<endl<<"-----------------------------"<<endl;
cout<<"Fifth Dequeue : "<<q1.DeQ()<<endl<<"-----------------------------"<<endl;
cout<<"6th Dequeue : "<<q1.DeQ()<<endl<<"-----------------------------"<<endl;
cout<<"Current Queue Count : "<<q1.GetCount()<<endl<<"-----------------------------"<<endl;










    return 0;
}
