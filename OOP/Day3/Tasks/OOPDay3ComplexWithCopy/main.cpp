#include <iostream>

using namespace std;

class Complex
{
    int Real;
    int Img;

public:

    Complex(Complex& oldCom)
    {
        Real=oldCom.Real;
        Img=oldCom.Img;
        cout<<this<<" (Copy Constructor)"<<endl;
    }
    Complex(int R,int I)
    {
        Real=R;
        Img=I;
        cout<<this<<" (2 input Constructor)"<<endl;
    }
    Complex(int n)
    {
        Real=Img=n;
        cout<<this<<" (Single Input)"<<endl;
    }
    Complex()
    {
        Real=Img=0;
        cout<<this<<" (ParameterLess Constructor)"<<endl;
    }

    void SetReal(int _R){Real=_R;}
    void SetImg(int _I){Img=_I;}
    int GetReal(){return Real;}
    int GetImg(){return Img;}
     Complex SumRef(Complex& C1)
     {
         Complex c3;
         c3.Real=Real+C1.Real;
         c3.Img=Img+C1.Img;
         return c3;
     }
          Complex Sum(Complex C1)
     {
         Complex c3;
         c3.Real=Real+C1.Real;
         c3.Img=Img+C1.Img;
         return c3;
     }
    ~Complex()
    {
        cout<<this<<" (Hello From Destructor)"<<endl;
    }
    void PrintComplex()
    {
        if(Real>0&&Img>0)
        {
            cout<<Real<<"+"<<Img<<"i"<<endl;
        }
        else if(Real>0&&Img<0)
        {
            cout<<Real<<Img<<"i"<<endl;
        }
        else if(Real<0&&Img>0)
        {
            cout<<Real<<"+"<<Img<<"i"<<endl;
        }
        else if(Real<0&&Img<0)
        {
            cout<<Real<<Img<<"i"<<endl;
        }
        else if (Real==0)
        {
            cout<<Img<<"i"<<endl;
        }
        else if (Img==0)
        {
            cout<<Real<<endl;
        }
    }
};


Complex sub(Complex c1,Complex c2)
{
    Complex cResult;

    cResult.SetReal(c1.GetReal()-c2.GetReal());
    cResult.SetImg(c1.GetImg()-c2.GetImg());
    return cResult;

};
int main()
{

    Complex c1(1,2),c2(2),c3;
    c3=c1.Sum(c2);
    //c3=c1.SumRef(c2);

/// RVO removed the constructor  temp object constructor and destructor.
    ///6 Objects //5 Constructors ///5 Destructors
    ///with copy constructor input parameter of the sum function gets initialized by the copy constructor
    ///Case sumRef no object is created for the input parameter because its alias for the variable passed into the parameter
    return 0;
}
