#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#define NormalPen 0x0F
#define HighlightPen 0xF0
#define Enter 0x0D
#define Esc 27
int main()
{
    void gotoxy( int column, int line )
  {
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
  }
void textattr (int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),i);
}


char Menu[3][5]={"New ","Save","Exit"},ch;

int i,current=0,EFlag=0;

do{

textattr(NormalPen);
system("cls");
for(i=0;i<3;i++)
{
    if(current==i)
        textattr(HighlightPen);
    else
        textattr(NormalPen);
    gotoxy(5,5+(3*i));
    printf("%s",Menu[i]);

}

ch=_getch();

switch(ch)
{
case Enter:
    switch(current)
    {
    case 0:
        system("cls");
        printf("Welcome To New \nEnter New Character\n ");
        _getch();
        break;
    case 1:
        system("cls");
        printf("Welcome To Save \nEnter New Character\n ");
        _getch();
        break;
    case 2:
        EFlag=1;
        break;
    }
    break;
case Esc:
    EFlag=1;
    break;
case -32:
        ch=_getch();
        switch(ch)
        {
        case 72 :  //up
            current--;
            if(current<0)
                current=2;
            break;
        case 80:  //down
            current++;
            if(current>2)
                current=0;
            break;
        case 71:   //home
            current=0;
            break;
        case 79:  //end
            current=2;
            break;
        }
    break;

}

}while(!EFlag);



    return 0;
}
