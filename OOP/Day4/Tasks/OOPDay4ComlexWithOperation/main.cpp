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
    }
    Complex(int R,int I)
    {
        Real=R;
        Img=I;
    }
    Complex(int n)
    {
        Real=Img=n;
    }
    Complex()
    {
        Real=Img=0;
    }

    void SetReal(int _R)
    {
        Real=_R;
    }
    void SetImg(int _I)
    {
        Img=_I;
    }
    int GetReal()
    {
        return Real;
    }
    int GetImg()
    {
        return Img;
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

    ///Operators Section
    Complex operator -(const Complex& Right) ///Both Complex
    {
        Complex R(Real-Right.Real,Img-Right.Img);
        return R;
    };
    Complex operator -(int Right) ///Left complex and right integar
    {
        Complex R(Real-Right,Img);
        return R;
    };
    Complex& operator -=(const Complex& R) ///Both Complex
    {
        Real-=R.Real;
        Img-=R.Img;
        return *this;
    }
    Complex& operator -=(int R)
    {
        Real-=R;
        return *this;
    }
    Complex& operator --()///prefix
    {
        Real--;
        return *this;
    }
    Complex operator -- (int)
    {
        Complex R(*this);

        Real--;
        return R;
    }

    bool operator == (const Complex& R)
    {
        return (Real==R.Real)&&(Img==R.Img);
    }
    bool operator !=(const Complex& R)
    {
        return !((Real==R.Real)&&(Img==R.Img));
    }

    bool operator > (const Complex& R )
    {
        if(Real>R.Real)
        {
            return true;
        }
        else if (Real<R.Real)
        {
            return false;
        }
        else
        {
            if(Img>R.Img)
                return true;
            else
                return false;
        }
    }
    bool operator >= (const Complex& R)
    {
        if(Real>R.Real)
        {
            return true;
        }
        else if (Real<R.Real)
        {
            return false;
        }
        else
        {
            if(Img>R.Img)
                return true;
            else if(Img<R.Img)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }



    bool operator < (const Complex& R)
    {
        if(Real<R.Real)
        {
            return true;
        }
        else if (Real>R.Real)
        {
            return false;
        }
        else
        {
            if(Img<R.Img)
                return true;
            else
                return false;
        }

    }

    bool operator <= (const Complex& R)
    {

        if(Real<R.Real)
        {
            return true;
        }
        else if (Real>R.Real)
        {
            return false;
        }
        else
        {
            if(Img<R.Img)
                return true;
            else if(Img>R.Img)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    operator int ()
    {

        return Real;
    }
    operator char*()
    {

        string t;
        if(Real>0&&Img>0)
        {
            t=to_string(Real)+"+"+to_string(Img)+"i";
            char *temp= new char[t.length()];
            for(int i=0; i<t.length(); i++)
            {
                temp[i]=t[i];
            }
            return temp;
        }
        else if(Real>0&&Img<0)
        {
            t=to_string(Real)+to_string(Img)+"i";
            char *temp= new char[t.length()];
            for(int i=0; i<t.length(); i++)
            {
                temp[i]=t[i];
            }
            return temp;
        }
        else if(Real<0&&Img>0)
        {
            t=to_string(Real)+"+"+to_string(Img)+"i";
            char *temp= new char[t.length()];
            for(int i=0; i<t.length(); i++)
            {
                temp[i]=t[i];
            }
        return temp;
        }
        else if(Real<0&&Img<0)
        {
            t=to_string(Real)+to_string(Img)+"i";
            char *temp= new char[t.length()];
            for(int i=0; i<t.length(); i++)
            {
                temp[i]=t[i];

            }
            return temp;
        }
        else if (Real==0)
        {
            t=to_string(Img)+"i";
            char *temp= new char[t.length()];
            for(int i=0; i<t.length(); i++)
            {
                temp[i]=t[i];

            }
            return temp;

        }
        else if (Img==0)
        {
            t=to_string(Real);
            char *temp= new char[t.length()];
            for(int i=0; i<t.length(); i++)
            {
                temp[i]=t[i];

            }
            return temp;
        }


    }
};
///out side of class


Complex operator -(int L,Complex R)  ///Left integer , Right complex
{

    Complex Result(L-R.GetReal(),R.GetImg());
    return Result;
};

Complex& operator -=(int L, Complex& R)
{
    int temp = 7-(R.GetReal());
    R.SetReal(temp);
    return R;
}

int main()
{

    Complex c1(3,4),c2(5,6),c3;
    cout<<"C1 is : ";
    c1.PrintComplex();
    cout<<endl;
    cout<<"C2 is : ";
    c2.PrintComplex();
    cout<<endl;
    cout<<"C1-C2= ";//1
    c3=c1-c2;
    c3.PrintComplex();

    cout<<"7-C2= ";//2
    c3=7-c2;
    c3.PrintComplex();

    cout<<"C2-7= "; //3
    c3=c2-7;
    c3.PrintComplex();

    cout<<"c1-=c2 : c1= ";//4
    c1-=c2;
    c1.PrintComplex();

    cout<<"c1-=7 : c1=";//5
    c1-=7;
    c1.PrintComplex();

    cout<<"7-=c1 : c1=";//6
    7-=c1;
    c1.PrintComplex();

    cout<<"--c1 : c1=";//7
    --c1;
    c1.PrintComplex();

    cout<<"c1-- : c1=";//8
    c3=c1--;
    c3.PrintComplex();

    bool x=(c1==c2);
    cout<<"c1==c2 : "<<x<<endl;;//9

    x=(c1!=c2);
    cout<<"c1!=c2 : "<<x<<endl;//10

    x=(c1>c2);
    cout<<"c1>c2 : "<<x<<endl;//11

    x=(c1>=c2);
    cout<<"c1>=c2 : "<<x<<endl;//12

    x=(c1<c2);
    cout<<"c1<c2 : "<<x<<endl;//13

    x=(c1<=c2);
    cout<<"c1<=c2 : "<<x<<endl;//14

    int r=(int)c1;
    cout<<"int r =(int)c1 : r="<<r<<endl;//15

    char*z=(char*)c1;

    cout<<"Complex c1 : "<<z;
    return 0;
}
