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

    }
    MyStack(int _size)
    {
        Size=_size;
        stk = new int[_size];
        Tos=0;

    }
    ~MyStack()
    {

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


///Operators
MyStack& operator =(const MyStack& s)
{
    delete []stk;
    Tos=s.Tos;
    Size=s.Size;
    stk=new int[Size];
    for(int i=0;i<Size;i++)
    {
        stk[i]=s.stk[i];
    }
}

MyStack operator + ( const MyStack& R)
{
MyStack Result(Size+R.Size);
for(int i=0;i<Size;i++)
{
    Result.Push(stk[i]);
}
for(int i=0;i<R.Size;i++)
{
    Result.Push(R.stk[i]);
}
return Result;

}

int& operator [] (int index)
{
    if((index>=0)&&(index<Size))
    {
        return stk[index];
    }
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

    MyStack s1(4),s2(4),s3(1);
    s1.Push(1);
    s1.Push(2);
    s1.Push(3);
    s1.Push(4);

    s2.Push(5);
    s2.Push(6);
    s2.Push(7);
    s2.Push(8);

s3=s1+s2;
ViewContent(s3);
cout<<endl<<s3[7];
    return 0;
}
