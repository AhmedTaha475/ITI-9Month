#include <iostream>

using namespace std;
template <class T>
class MyStack
{
    T *stk;
    int Tos,Size;
public:

    MyStack(MyStack& sOld)
    {
        Tos=sOld.Tos;
        Size=sOld.Size;
        stk= new T[Size];
        for(int i=0;i<Tos;i++)
        {
            stk[i]=sOld.stk[i];
        }

    }
    MyStack(int _size)
    {
        Size=_size;
        stk = new T[Size];
        Tos=0;

    }
    ~MyStack()
    {

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

//friend void ViewContent(MyStack s);

MyStack Reverse()
    {
        MyStack R(Size);
        for(int i=0;i<Tos;i++)
        {
            R.Push(stk[Tos-i-1]);
        }
return R;
    }
    T Pop()
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
    void Push(T n)
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
    stk=new T[Size];
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

T& operator [] (int index)
{
    if((index>=0)&&(index<Size))
    {
        return stk[index];
    }
}
void ViewContent()
{
for(int i=0;i<Tos;i++)
{
    cout<<stk[i]<<",";
}
cout<<endl;
};


};


int main()
{


    MyStack<double> s1(5);
    s1.Push(1.3);
    s1.Push(2.6);
    s1.Push(2.9);
    s1.ViewContent();
    cout << endl;
        MyStack<char> s2 (5);
    s2.Push('a');
    s2.Push('h');
    s2.Push('m');
    s2.Push('e');
    s2.Push('d');
    s2.ViewContent();
    cout << endl;
    return 0;
}
