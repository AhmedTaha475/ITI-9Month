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

    double virtual cArea()=0;
};
class rect : public GeoShape
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
    double cArea() override
    {
        return dim1*dim2;
    }
};
class square :public rect
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

};

class Circle :public GeoShape
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

    double cArea() override
    {
        return 3.14*dim1*dim2;
    }
};


class triangle : public GeoShape
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
    double cArea() override
    {
        return 0.5*dim1*dim2;
    }
};

double SumOfAreas(GeoShape** arr,int c)
{
    double sum=0;
    for(int i=0;i<c;i++)
    {
        sum+=arr[i]->cArea();
    }
    return sum;
}



int main()
{



rect arr1[3]={rect(2,5),rect(3,4),rect(5,6)};
square arr2[2]={square(10),square(20)};
triangle arr3[3]={triangle(10,5),triangle(16.5,10.6),triangle(3.6,20.6)};
Circle arr4[3]={Circle(6),Circle(7),Circle(6)};

GeoShape* shapes[11]={arr1,&arr1[1],&arr1[2],arr2,&arr2[1],arr3,&arr3[1],&arr3[2],arr4,&arr4[1],&arr4[2]};

cout<<"Total area is : "<<SumOfAreas(shapes,11)<<endl;





















    return 0;
}
