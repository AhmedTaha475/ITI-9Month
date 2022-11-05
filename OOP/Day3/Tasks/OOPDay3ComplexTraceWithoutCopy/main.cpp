#include <iostream>

using namespace std;

class Complex
{
    int Real;
    int Img;

public:

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
    c3.PrintComplex();
/// RVO removed the constructor of input parameter and temp object constructor and destructor.
    ///6 Objects //4 Constructors ///5 Destructors
    ///Conclusion from tracing every object created in main has constructor and destructor
    /// member function inside the class every input parameter is object but it doesn't get initialized by any constructor but it uses destructor at the end of the function
    /// so in general for sum function it will be 5 objects (3 in main c1,c2,c3) (2 in sum function c1=parameter , c3)
    /// 4 constructors 3 for main objects 1 for sum function c3
    /// 5 destructors 3 for main 1 for sum c3 and 1 for sum input c1
    return 0;
}
