#include <iostream>

using namespace std;

template <class T>

class intArray
{
private:
    T *Marr;
    int Size;
public:
    intArray(int _s)///const
    {
        Size=_s;
        Marr= new T[Size];
    }
    ~intArray()///destructor
    {

        delete []Marr;
    }
    intArray(const intArray& x) ///Copy const
    {
        Size=x.Size;
        Marr=new T[Size];
        for(int i=0;i<Size;i++)
        {
            Marr[i]=x.Marr[i];
        }
    }
    intArray& operator = (const intArray& s)
    {
        delete []Marr;
        Size=s.Size;
        Marr=new T[Size];
        for(int i=0;i<Size;i++)
        {
            Marr[i]=s.Marr[i];
        }
        return *this;
    }
    T& operator [](int index)
    {
        if((index>=0)&&(index<Size))
        {
            return Marr[index];
        }

    }

    void setArrayValue(int index,T Value)
    {
        if((index>=0)&&(index<Size))
        {
            Marr[index]=Value;
        }
    }

    intArray operator + ( const intArray& R)
    {
        if(Size==R.Size)
        {
            intArray result(Size);
            for(int i=0;i<Size;i++)
            {
                result.Marr[i]=Marr[i]+R.Marr[i];
            }
            return result;
        }
        intArray fault(0);
        return fault;
    }

    int GetSize()
    {
        return Size;
    }
};




int main()
{

    intArray<double> a1(3);
    a1[0]=1.5;
    a1[1]=10.9;
    a1[2]=15;

    for(int i=0;i<3;i++)
    {
        cout<<a1[i]<<",";

    }
    cout<<endl;
    intArray<char> a2(3);
    a2[0]='a';
    a2[1]='b';
    a2[2]='c';

    for(int i=0;i<3;i++)
    {
        cout<<a2[i]<<",";

    }
    return 0;
}
