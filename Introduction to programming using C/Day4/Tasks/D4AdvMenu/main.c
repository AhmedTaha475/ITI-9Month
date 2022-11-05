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
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}


char Menu[3][5]={"New ","Save","Exit"};

int i,current=0;

for(i=0;i<3;i++)
{
    if(current==i)
        textattr(0xF0);
    gotoxy(5,5+(3*i));
    printf("%s",Menu[i]);


}








    return 0;
}
