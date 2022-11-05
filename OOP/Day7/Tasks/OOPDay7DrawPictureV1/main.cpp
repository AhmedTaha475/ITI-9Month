#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <stdio.h>
using namespace std;
/*class ColorPicker
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

};*/
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
    int color;

public:
    myRect(int _x1,int _y1,int _x2,int _y2,int c):UL(_x1,_y1),BR(_x2,_y2)
    {
        color=c;
    }
    ~myRect()
    {
        cout<<"Rec Destructor"<<endl;
    }
    void rectDraw()
    {
        setcolor(color);
        rectangle(UL.getX(),UL.getY(),BR.getX(),BR.getY());
    }



};

class myLine
{
    mPoint P1,P2;
    int color;
public:
    myLine(int _x1,int _y1,int _x2,int _y2,int c):P1(_x1,_y1),P2(_x2,_y2)
    {
        color=c;
    }
    ~myLine()
    {
        cout<<"Line Destructor"<<endl;
    }
    void drawLine()
    {
        setcolor(color);
        line(P1.getX(),P1.getY(),P2.getX(),P2.getY());
    }
};

class myCircle
{
    mPoint Center;
    int radius,color;
public:
    myCircle(int _x,int _y,int _r,int c):Center(_x,_y)
    {
        radius=_r;
        color=c;
    }
    ~myCircle()
    {
        cout<<"Circle Destructor"<<endl;
    }

    void drawCircle()
    {
        setcolor(color);
        circle(Center.getX(),Center.getY(),radius);
    }
};

class myTriangle
{
    mPoint P1,P2,P3;
    int color;
public:
    myTriangle(int _x1,int _y1,int _x2,int _y2,int _x3,int _y3,int c):P1(_x1,_y1),P2(_x2,_y2),P3(_x3,_y3)
    {
        color=c;
    }
    ~myTriangle()
    {
        cout<<"Tri Destructor"<<endl;
    }
    void drawTri()
    {
        setcolor(color);
        line(P1.getX(),P1.getY(),P2.getX(),P2.getY());
        line(P1.getX(),P1.getY(),P3.getX(),P3.getY());
        line(P2.getX(),P2.getY(),P3.getX(),P3.getY());
    }
};

class Picture
{
    myLine* Lptr;
    int lineSize;
    myRect* Rptr;
    int rectSize;
    myCircle* Cptr;
    int CircSize;
    myTriangle* Tptr;
    int TriSize;

public:
    Picture()
    {
        Lptr=NULL;
        Rptr=NULL;
        Cptr=NULL;
        Tptr=NULL;
        lineSize=rectSize=CircSize=TriSize=0;
    }
    Picture(myLine* L,int Lsize,myRect* R,int Rsize,myCircle* C,int Csize,myTriangle* T,int Tsize)
    {
        Lptr=L;
        lineSize=Lsize;
        Rptr=R;
        rectSize=Rsize;
        Cptr=C;
        CircSize=Csize;
        Tptr=T;
        TriSize=Tsize;
    }
    void SetMyrect(myRect* R,int Size)
    {
        Rptr=R;
        rectSize=Size;
    }
    void SetMyLine(myLine* R,int Size)
    {
        Lptr=R;
        lineSize=Size;
    }
    void SetMyCirc(myCircle* R,int Size)
    {
        Cptr=R;
        CircSize=Size;
    }
    void SetMyTri(myTriangle* R,int Size)
    {
        Tptr=R;
        TriSize=Size;
    }

    void PaintPicture()
    {
        for(int i=0;i<lineSize;i++)
        {

            Lptr[i].drawLine();
        }
         for(int i=0;i<rectSize;i++)
        {

            Rptr[i].rectDraw();
        }
         for(int i=0;i<CircSize;i++)
        {

            Cptr[i].drawCircle();
        }
         for(int i=0;i<TriSize;i++)
        {

            Tptr[i].drawTri();
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
    Picture p1(LArr,4,RArr,1,CArr,2,TArr,2);
    p1.PaintPicture();
    /*myRect r1(200,300,350,400);
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
    */
    _getch();
    return 0;
}
