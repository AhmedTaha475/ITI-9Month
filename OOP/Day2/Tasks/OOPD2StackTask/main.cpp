#include <iostream>

using namespace std;

class MyStack
{
    int *stk,Tos,Size;
public:
    MyStack(int _size)
    {
        Size=_size;
        stk = new int[_size];
        Tos=0;
    }
    ~MyStack()
    {
        delete [] stk;
    }
    bool IsFull()
    {
        return Tos==Size;
    }
    bool IsEmpty()
    {
        return Tos==0;
    }

    int Pop()
    {
        if(!IsEmpty())
        {
            return stk[--Tos];
        }
        else
        {
            cout<<"Stack is Empty"<<endl;
            return -1;
        }
    }
    void Push(int n)
    {
        if(!IsFull())
        {
            stk[Tos++]=n;

        }
        else
        {
            cout<<"Stack is Full"<<endl;
        }
    }

    int Peek()
    {
        if(!IsEmpty())
        {
            return stk[Tos-1];
        }
        else
        {
            cout<<"Stack is Empty PEEK"<<endl;
            return -1;
        }
    }

    int GetCount()
    {


    return Tos;

    }

};





int main()
{
    MyStack s1(5);
    s1.Pop();
    cout<<"---------------------------"<<endl;
    s1.Push(1);
    s1.Push(2);
    s1.Push(3);
    s1.Push(4);
    s1.Push(5);
    s1.Push(6);

cout<<"Current stack Count : "<<s1.GetCount()<<endl<<"-----------------------------"<<endl;
cout<<"Current stack  : "<<"1 2 3 4 5 "<<endl<<"-----------------------------"<<endl;
cout<<"First pop : "<<s1.Pop()<<endl<<"-----------------------------"<<endl;
cout<<"Peak before Second pop : "<<s1.Peek()<<endl<<"-----------------------------"<<endl;
cout<<"Second pop : "<<s1.Pop()<<endl<<"-----------------------------"<<endl;
cout<<"third pop : "<<s1.Pop()<<endl<<"-----------------------------"<<endl;
cout<<"Forth pop : "<<s1.Pop()<<endl<<"-----------------------------"<<endl;
cout<<"Fifth pop : "<<s1.Pop()<<endl<<"-----------------------------"<<endl;
cout<<"6th pop : "<<s1.Pop()<<endl<<"-----------------------------"<<endl;
cout<<"Current stack Count : "<<s1.GetCount()<<endl<<"-----------------------------"<<endl;











    return 0;
}
