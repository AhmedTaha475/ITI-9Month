#include <iostream>

using namespace std;

class intArray
{
private:
    int *Marr;
    int Size;
public:
    intArray(int _s)///const
    {
        Size=_s;
        Marr= new int[Size];
    }
    ~intArray()///destructor
    {
        for(int i=0; i<Size;i++)
        {
            Marr[i]=-1;
        }
        delete []Marr;
    }
    intArray(const intArray& x) ///Copy const
    {
        Size=x.Size;
        Marr=new int[Size];
        for(int i=0;i<Size;i++)
        {
            Marr[i]=x.Marr[i];
        }
    }
    intArray& operator = (const intArray& s)
    {
        delete []Marr;
        Size=s.Size;
        Marr=new int[Size];
        for(int i=0;i<Size;i++)
        {
            Marr[i]=s.Marr[i];
        }
        return *this;
    }
    int& operator [](int index)
    {
        if((index>=0)&&(index<Size))
        {
            return Marr[index];
        }

    }

    void setArrayValue(int index,int Value)
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
    intArray MyA(7),MyB(7),Result(1);
    for(int i=0;i<MyA.GetSize();i++)
    {
        MyA[i]=3*i;
        MyB[i]=3*i;
        cout<<MyA[i]<<",";

    }
    cout<<endl;
    for(int i=0;i<MyB.GetSize();i++)
    {
        cout<<MyB[i]<<",";
    }


Result=MyA+MyB;
cout<<endl;
for(int i=0;i<Result.GetSize();i++)
{
    cout<<Result[i]<<",";
}
    return 0;
}
