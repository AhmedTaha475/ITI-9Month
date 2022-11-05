#include <iostream>

using namespace std;
class base
{
    int x;
protected:
    int y;
public:
    int z;

    base(int _x,int _y,int _z)
    {
        x=_x;
        y=_y;
        z=_z;
    }

    int myFun()
    {
        return x+
               y+
               z;
    }
};

class derived01 :public base
{
    int a;
protected :
    int b;
public:
    int c;

    derived01(int _a,int _b, int _c,int _x,int _y,int _z) :base(_x,_y,_z)
    {
        a=_a;
        b=_b;
        c=_c;
    }

       int myFun()
    {
        return x+
               y+
               z+
               a+
               b+
               c;
    }
}

class derived02 : public derived01
{
    int d;
protected:
    int f;
public:
    int g;

    derived02(int _d,int _f,int _g,int _a,int _b, int _c,int _x,int _y,int _z) : derived01(_a,_b,_c,_x,_y,_z)
    {
        d=_d;
        f=_f;
        g=_g;
    }
    int myFun()
    {
        return x+
               y+
               z+
               a+
               b+
               c+
               d+
               f+
               g;
    }
};

};




int main()
{
    ///accessibility of the variables inside myfun in each class (√) in case (protect public from other classes or anything from the same class)
       ///test cases                    ///Base class                       /// derived01                       /// derived02

      1-public public                      x(private)                       a(private)                              d(private)
                                           y(protected)                     b&y(protected)                          f&b&y(protected)
                                           z(public)                        c&z(public)                             g&c&z(public)

-----------------------------------------------------------------------------------------------------------------------------------
      2-public protected                   x(private)                       a(private)                              d(private)
                                           y(protected)                     b&y(protected)                          f&b&y&c&z(protected)
                                           z(public)                        c&z(public)                             g(public)
-----------------------------------------------------------------------------------------------------------------------------------
      3-public private                     x(private)                       a(private)                              d&b&y&c&z(private)
                                           y(protected)                     b&y(protected)                          f(protected)
                                           z(public)                        c&z(public)                             g(public)
-----------------------------------------------------------------------------------------------------------------------------------
      4-private public                     x(private)                       a&y&z(private)                          d(private)
                                           y(protected)                     b(protected)                            f&b(protected)
                                           z(public)                        c(public)                               g&c(public)
-----------------------------------------------------------------------------------------------------------------------------------
      5-private protected                  x(private)                       a&y&z(private)                          d(private)
                                           y(protected)                     b(protected)                            f&b&c(protected)
                                           z(public)                        c(public)                               g(public)
-----------------------------------------------------------------------------------------------------------------------------------
      6-private private                    x(private)                       a&y&z(private)                          d&b&c(private)
                                           y(protected)                     b(protected)                            f(protected)
                                           z(public)                        c(public)                               g(public)
-----------------------------------------------------------------------------------------------------------------------------------
      7-protected public                   x(private)                       a(private)                              d(private)
                                           y(protected)                     b&y&z(protected)                        f&b&y&z(protected)
                                           z(public)                        c(public)                               g&c(public)
-----------------------------------------------------------------------------------------------------------------------------------
      8-protected protected                x(private)                       a(private)                              d(private)
                                           y(protected)                     b&y&z(protected)                        f&b&y&z&c(protected)
                                           z(public)                        c(public)                               g(public)
-----------------------------------------------------------------------------------------------------------------------------------
      9-protected private                  x(private)                       a(private)                              d&b&y&z&c(private)
                                           y(protected)                     b&y&z(protected)                        f(protected)
                                           z(public)                        c(public)                               g(public)



///applying the cases on the main function
                        ///Test cases

base b1;           1-(pub-pub) 2-(pub-pro) 3-(pub-pri)   4-(pri-pub)  5-(pri-pro)  6-(pri-pri)  7-(pro-pub)  8-(pro-pro)  9-(pro-pri)
            b1.x        X           X           X             X            X            X            X            X            X
            b1.y        X           X           X             X            X            X            X            X            X
            b1.z        √           √           √             √            √            √            √            √            √
derived01 d1;
            d1.x        X           X           X             X            X            X            X            X            X
            d1.y        X           X           X             X            X            X            X            X            X
            d1.z        √           √           √             X            X            X            X            X            X
            d1.a        X           X           X             X            X            X            X            X            X
            d1.b        X           X           X             X            X            X            X            X            X
            d1.c        √           √           √             √            √            √            √            √            √

derived02 der2;
            der2.x      X           X           X             X            X            X            X            X            X
            der2.y      X           X           X             X            X            X            X            X            X
            der2.z      √           X           X             X            X            X            X            X            X
            der2.a      X           X           X             X            X            X            X            X            X
            der2.b      X           X           X             X            X            X            X            X            X
            der2.c      √           X           X             √            X            X            √            X            X
            der2.d      X           X           X             X            X            X            X            X            X
            der2.f      X           X           X             X            X            X            X            X            X
            der2.g      √           √           √             √            √            √            √            √            √

























    return 0;
}
