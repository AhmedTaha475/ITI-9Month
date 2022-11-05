#include <iostream>

using namespace std;
class Complex
{
private:
    int Real;
    int Img;
public:
    void SetReal(int _R)
       {

        Real=_R;
       }


    void SetImg(int _I)
        {Img=_I;}
    int GetReal()
        {return Real;}
    int GetImg()
        {return Img;}
     Complex Sum(Complex C1)
     {
         C1.SetReal(Real+C1.GetReal());
         C1.SetImg(Img+C1.GetImg());
         return C1;
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
Complex Sub(Complex C1,Complex C2)
{
    Complex Result;
    Result.SetReal(C1.GetReal()-C2.GetReal());
    Result.SetImg(C1.GetImg()-C2.GetImg());
    return Result;
}
int main()
{

int x;
Complex c1,c2,c3;
cout<<"Please Enter first the complex number"<<endl;
cout<<"Real is : ";
cin>>x;
c1.SetReal(x);
cout<<"Img is : ";
cin>>x;
c1.SetImg(x);
cout<<"First number is "<<endl;
c1.PrintComplex();
//////////////////////////////////////////////////////
cout<<"Please Enter the second complex number"<<endl;
cout<<"Real is : ";
cin>>x;
c2.SetReal(x);
cout<<"Img is : ";
cin>>x;
c2.SetImg(x);
cout<<"Second number is "<<endl;
c2.PrintComplex();
cout<<endl;
//////////////////////////////////////////////////////
cout<<"Sum is : ";
c3=c1.Sum(c2);
c3.PrintComplex();
cout<<endl;
cout<<"sub is : ";
c3=Sub(c1,c2);
c3.PrintComplex();









    return 0;
}
