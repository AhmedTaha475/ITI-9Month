#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <stdio.h>
using namespace std;

class mPoint
{
int x,y;
public:
    mPoint(int _x,int _y)
    {
        x=_x;
        y=_y;
    }
    ~mPoint()
    {
        cout<<"Point Destructor"<<endl;
    }

    void setX(int _x)
    {
        x=_x;
    }
    void setY(int _y)
    {
        y=_y;
    }
    int getX()
    {
        return x;
    }
    int getY()
    {
        return y;
    }

    void printPoint()
    {
        cout<<"("<<x<<","<<y<<")"<<endl;
    }

};

class myRect
{

    mPoint UL,BR;
    int PenColor;

public:
    myRect(int _x1,int _y1,int _x2,int _y2,int _color=1):UL(_x1,_y1),BR(_x2,_y2)
    {
        PenColor=_color;
    };

    ~myRect()
    {
        cout<<"Rec Destructor"<<endl;
    }
    void rectDraw()
    {
        setcolor(PenColor);
        rectangle(UL.getX(),UL.getY(),BR.getX(),BR.getY());
    }



};

class myLine
{
    mPoint P1,P2;
    int myColor;
public:
    myLine(int _x1,int _y1,int _x2,int _y2,int _color=1):P1(_x1,_y1),P2(_x2,_y2)
    {
        myColor=_color;
    }
    ~myLine()
    {
        cout<<"Line Destructor"<<endl;
    }
    void drawLine()
    {
        setcolor(myColor);
        line(P1.getX(),P1.getY(),P2.getX(),P2.getY());
    }
};

class myCircle
{
    mPoint Center;
    int myColor,radius;
public:
    myCircle(int _x,int _y,int _r,int _color=3):Center(_x,_y)
    {
        radius=_r;
        myColor=_color;
    }
    ~myCircle()
    {
        cout<<"Circle Destructor"<<endl;
    }

    void drawCircle()
    {
        setcolor(myColor);
        circle(Center.getX(),Center.getY(),radius);
    }
};

class myTriangle
{
    mPoint P1,P2,P3;
    int myColor;
public:
    myTriangle(int _x1,int _y1,int _x2,int _y2,int _x3,int _y3,int _color=4):P1(_x1,_y1),P2(_x2,_y2),P3(_x3,_y3)
    {
        myColor=_color;
    }
    ~myTriangle()
    {
        cout<<"Tri Destructor"<<endl;
    }
    void drawTri()
    {
        setcolor(myColor);
        line(P1.getX(),P1.getY(),P2.getX(),P2.getY());
        line(P1.getX(),P1.getY(),P3.getX(),P3.getY());
        line(P2.getX(),P2.getY(),P3.getX(),P3.getY());
    }
};

int main()
{
    initgraph();
    myRect r1(200,300,350,400,4);
    r1.rectDraw();
    myTriangle t1(250,350,300,350,275,325,4);
    t1.drawTri();
      myTriangle t2(250,350,300,350,275,375,5);
    t2.drawTri();

    myLine l1(250,300,250,250,2),l2(300,300,300,250,2);
    l1.drawLine();
    l2.drawLine();

    myCircle c1(275,225,70,3);
    c1.drawCircle();

    myLine l3(250,200,260,140,5),l4(300,200,290,140,5);
    l3.drawLine();
    l4.drawLine();

    myCircle c2(275,120,50,9);
    c2.drawCircle();
    _getch();
    return 0;
}
