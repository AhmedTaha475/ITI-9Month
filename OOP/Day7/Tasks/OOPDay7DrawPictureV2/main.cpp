#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <stdio.h>
using namespace std;
class shape
{
protected:
    int color;
public:
    shape()
    {
        color=0;
    }
    shape(int c)
    {
        color=c;
    }
    void virtual draw()=0;



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

class myRect: public shape
{

    mPoint UL,BR;

public:
    myRect(int _x1,int _y1,int _x2,int _y2,int c):UL(_x1,_y1),BR(_x2,_y2),shape(c)
    {
    }
    ~myRect()
    {
        cout<<"Rec Destructor"<<endl;
    }
    void draw() override
    {
        setcolor(color);
        rectangle(UL.getX(),UL.getY(),BR.getX(),BR.getY());
    }



};

class myLine : public shape
{
    mPoint P1,P2;
public:
    myLine(int _x1,int _y1,int _x2,int _y2,int c):P1(_x1,_y1),P2(_x2,_y2),shape(c)
    {
    }
    ~myLine()
    {
        cout<<"Line Destructor"<<endl;
    }
    void draw() override
    {
        setcolor(color);
        line(P1.getX(),P1.getY(),P2.getX(),P2.getY());
    }
};

class myCircle : public shape
{
    mPoint Center;
    int radius;
public:
    myCircle(int _x,int _y,int _r,int c):Center(_x,_y),shape(c)
    {
        radius=_r;
    }
    ~myCircle()
    {
        cout<<"Circle Destructor"<<endl;
    }

    void draw() override
    {
        setcolor(color);
        circle(Center.getX(),Center.getY(),radius);
    }
};

class myTriangle : public shape
{
    mPoint P1,P2,P3;
public:
    myTriangle(int _x1,int _y1,int _x2,int _y2,int _x3,int _y3,int c):P1(_x1,_y1),P2(_x2,_y2),P3(_x3,_y3),shape(c)
    {
    }
    ~myTriangle()
    {
        cout<<"Tri Destructor"<<endl;
    }
    void draw()
    {
        setcolor(color);
        line(P1.getX(),P1.getY(),P2.getX(),P2.getY());
        line(P1.getX(),P1.getY(),P3.getX(),P3.getY());
        line(P2.getX(),P2.getY(),P3.getX(),P3.getY());
    }
};

class Picture
{

    shape** AllShapes;
    int Size;

public:
    Picture()
    {
        AllShapes=NULL;
        Size=0;
    }
    Picture(shape** _Sh,int _Size)
    {
        AllShapes=_Sh;
        Size=_Size;
    }
    void SetMyShapes(shape** _sh,int _s)
    {
        AllShapes=_sh;
        Size=_s;
    }


    void PaintPicture()
    {
        for(int i=0;i<Size;i++)
        {
            AllShapes[i]->draw();
        }
    }
};

int main()
{
    initgraph();
    myLine LArr[4]={myLine(250,300,250,250,2),myLine(300,300,300,250,2),myLine(250,200,260,140,5),myLine(300,200,290,140,5)};
    myRect RArr[1]={myRect(200,300,350,400,4)};
    myCircle CArr[2]={myCircle(275,225,70,3),myCircle(275,120,50,9)};
    myTriangle TArr[2]={myTriangle(250,350,300,350,275,325,4),myTriangle(250,350,300,350,275,375,5)};
    shape* sh[9]={LArr,&LArr[1],&LArr[2],&LArr[3],RArr,CArr,&CArr[1],TArr,&TArr[1]};
    Picture p1(sh,9);
    p1.PaintPicture();



    _getch();
    return 0;
}
