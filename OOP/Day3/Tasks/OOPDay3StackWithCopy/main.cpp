#include <iostream>

using namespace std;

class MyStack
{
    int *stk,Tos,Size;
public:

    MyStack(MyStack& sOld)
    {
        Tos=sOld.Tos;
        Size=sOld.Size;
        stk= new int[Size];
        for(int i=0;i<Tos;i++)
        {
            stk[i]=sOld.stk[i];
        }
        cout<<"Copy Constructor\n";
    }
    MyStack(int _size)
    {
        Size=_size;
        stk = new int[_size];
        Tos=0;
        cout<<"Welcomeeeee Constructor\n";
    }
    ~MyStack()
    {
        cout<<"Welcome Destructor\n";
        for(int i=0;i<Tos;i++)
        {
            stk[i]=-1;
        }
        delete []stk;
    }
    bool IsFull()
    {
        return Tos==Size;
    }
    bool IsEmpty()
    {
        return Tos==0;
    }

    friend void ViewContent(MyStack s);




MyStack Reverse()
    {
        MyStack R(Size);
        for(int i=0;i<Tos;i++)
        {
            R.Push(stk[Tos-i-1]);
        }
return R;
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
void ViewContent(MyStack s)
{
for(int i=0;i<s.Tos;i++)
{
    cout<<s.stk[i]<<",";
}
cout<<endl;
};



int main()
{
    MyStack s1(5);
    cout<<"---------------------------"<<endl;
    s1.Push(13);
    s1.Push(2);
    s1.Push(3);
    s1.Push(4);
    s1.Push(5);
ViewContent(s1);
//cout<<s1.Reverse().Pop()<<endl;









    return 0;
}
