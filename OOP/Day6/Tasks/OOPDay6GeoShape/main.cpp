#include <iostream>

using namespace std;
class GeoShape
{
protected:
    double dim1;
    double dim2;
public:
    GeoShape()
    {
        dim1=dim2=0;
    }
    GeoShape(double _d1,double _d2)
    {
        dim1=_d1;
        dim2=_d2;
    }
    ~GeoShape()
    {
        // cout<<"Geo"<<endl;
    }
    int getDim1()
    {
        return dim1;
    }
    void setDim1(double d)
    {
        dim1=d;
    }
    int getDim2()
    {
        return dim2;
    }
    void setDim2(double d)
    {
        dim2=d;
    }
};
class rect : protected GeoShape
{
public:
    rect()
    {
    }
    rect(double d1,double d2):GeoShape(d1,d2)
    {
    }
    ~rect()
    {
        //cout<<"Rec"<<endl;
    }
///override part

    int getDim1()
    {
        return dim1;
    }
    void setDim1(double d)
    {
        dim1=d;
    }
    int getDim2()
    {
        return dim2;
    }
    void setDim2(double d)
    {
        dim2=d;
    }
    double calcArea()
    {
        return dim1*dim2;
    }
};
class square :protected rect
{
public:
    square()
    {

    }
    square(double d):rect(d,d)
    {
    }
    ~square()
    {
        //cout<<"square"<<endl;
    }
///override part

    int getDim1()
    {
        return dim1;
    }
    void setDim1(double d)
    {
        dim1=dim2=d;
    }
    int getDim2()
    {
        return dim2;
    }
    void setDim2(double d)
    {
        dim1=dim2=d;
    }

    double calcArea()
    {
        return dim1*dim2;
    }
};

class Circle :protected GeoShape
{
public:
    Circle()
    {

    }
    Circle(double d):GeoShape(d,d)
    {
    }
    ~Circle()
    {
        //cout<<"Circle"<<endl;
    }
///override part

    int getDim1()
    {
        return dim1;
    }
    void setDim1(double d)
    {
        dim1=dim2=d;
    }
    int getDim2()
    {
        return dim2;
    }
    void setDim2(double d)
    {
        dim1=dim2=d;
    }

    double calcArea()
    {
        return 3.14*dim1*dim2;
    }
};


class triangle : protected GeoShape
{
public:
    triangle() {}
    triangle(double d1,double d2):GeoShape(d1,d2)
    {
    }
    ~triangle()
    {
        //cout<<"triangle"<<endl;
    }
///override part

    int getDim1()
    {
        return dim1;
    }
    void setDim1(double d)
    {
        dim1=d;
    }
    int getDim2()
    {
        return dim2;
    }
    void setDim2(double d)
    {
        dim2=d;
    }
    double calcArea()
    {
        return 0.5*dim1*dim2;
    }
};


double SumOfAreas(rect* r1,int recSize,square* s1,int squSize,Circle* c1,int CircSize,triangle* t1,int triSize)
{
    double sum=0;
    for(int i=0; i<recSize; i++)
    {
        sum+=r1[i].calcArea();
    }
    for(int i=0; i<squSize; i++)
    {
        sum+=s1[i].calcArea();
    }
    for(int i=0; i<CircSize; i++)
    {
        sum+=c1[i].calcArea();
    }
    for(int i=0; i<triSize; i++)
    {
        sum+=t1[i].calcArea();
    }
    return sum;
}



int main()
{
    /*
        rect r1(20,10);
        cout<<"Rec = "<<r1.calcArea()<<endl;
        square s1 (20);
        cout<<"Square = "<<s1.calcArea()<<endl;
         Circle c1(10);
        cout<<"circle = "<<c1.calcArea()<<endl;
        triangle t1(10,20);
         cout<<"Tri = "<<t1.calcArea()<<endl;
    */


    rect* r1 = new rect[3];
    r1[0].setDim1(5);
    r1[0].setDim2(10);
    r1[1].setDim1(5);
    r1[1].setDim2(10);
    r1[2].setDim1(5);
    r1[2].setDim2(10);

    square* s1 = new square[4];
    s1[0].setDim1(20);
    s1[1].setDim1(10);
    s1[2].setDim1(15);
    s1[3].setDim1(23.5);

    Circle* c1 = new Circle[2];
    c1[0].setDim1(20);
    c1[1].setDim1(16.9);

    triangle* t1 = new triangle[3];
    t1[0].setDim1(15);
    t1[0].setDim2(17.3);
    t1[1].setDim1(15);
    t1[1].setDim2(17.3);
    t1[2].setDim1(15);
    t1[2].setDim2(17.3);

    cout<<"Total sum of shapes = "<<SumOfAreas(r1,3,s1,4,c1,2,t1,3)<<endl;

    return 0;
}
