#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <stdio.h>
using namespace std;
class ColorPicker
{
protected:
    int color;
public:
    ColorPicker()
    {
        color=0;
    }
    ColorPicker(int c)
    {
        color=c;
    }

    void SetColor(int c)
    {
        setcolor(c);
    }
};
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

class myRect : public ColorPicker
{

    mPoint UL,BR;

public:
    myRect(int _x1,int _y1,int _x2,int _y2):UL(_x1,_y1),BR(_x2,_y2),ColorPicker()
    {
    }

    ~myRect()
    {
        cout<<"Rec Destructor"<<endl;
    }
    void rectDraw()
    {
        //setcolor(color);
        rectangle(UL.getX(),UL.getY(),BR.getX(),BR.getY());
    }



};

class myLine : public ColorPicker
{
    mPoint P1,P2;
public:
    myLine(int _x1,int _y1,int _x2,int _y2):P1(_x1,_y1),P2(_x2,_y2),ColorPicker()
    {

    }
    ~myLine()
    {
        cout<<"Line Destructor"<<endl;
    }
    void drawLine()
    {

        line(P1.getX(),P1.getY(),P2.getX(),P2.getY());
    }
};

class myCircle:public ColorPicker
{
    mPoint Center;
    int radius;
public:
    myCircle(int _x,int _y,int _r):Center(_x,_y),ColorPicker()
    {
        radius=_r;
    }
    ~myCircle()
    {
        cout<<"Circle Destructor"<<endl;
    }

    void drawCircle()
    {
        circle(Center.getX(),Center.getY(),radius);
    }
};

class myTriangle:public ColorPicker
{
    mPoint P1,P2,P3;
public:
    myTriangle(int _x1,int _y1,int _x2,int _y2,int _x3,int _y3):P1(_x1,_y1),P2(_x2,_y2),P3(_x3,_y3),ColorPicker()
    {
    }
    ~myTriangle()
    {
        cout<<"Tri Destructor"<<endl;
    }
    void drawTri()
    {

        line(P1.getX(),P1.getY(),P2.getX(),P2.getY());
        line(P1.getX(),P1.getY(),P3.getX(),P3.getY());
        line(P2.getX(),P2.getY(),P3.getX(),P3.getY());
    }
};



int main()
{
    initgraph();
    myRect r1(200,300,350,400);
    r1.SetColor(4);
    r1.rectDraw();
    myTriangle t1(250,350,300,350,275,325);
    t1.SetColor(4);
    t1.drawTri();
    myTriangle t2(250,350,300,350,275,375);
    t2.SetColor(5);
    t2.drawTri();

    myLine l1(250,300,250,250),l2(300,300,300,250);
    l1.SetColor(2);
    l1.drawLine();
    l2.SetColor(2);
    l2.drawLine();

    myCircle c1(275,225,70);
    c1.SetColor(3);
    c1.drawCircle();

    myLine l3(250,200,260,140),l4(300,200,290,140);
    l3.SetColor(5);
    l3.drawLine();
    l4.SetColor(5);
    l4.drawLine();

    myCircle c2(275,120,50);
    c2.SetColor(9);
    c2.drawCircle();
    _getch();
    return 0;
}
