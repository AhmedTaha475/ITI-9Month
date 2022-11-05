#include<stdio.h>
#include<windows.h>


void main()
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


int i,R,C;
R=0;C=5;


for(i=1;i<=9;i++)
{
    gotoxy(C,R);
    printf("%i",i);
    if(i%3==0)
        {
            if(R>=10)
                R=0;
             else
                R=R+5;
        }
    else
        {
            if(R<=0)
                R=10;
             else
                R=R-5;
             if(C<=0)
                C=10;
              else
                C=C-5;
        }
}

}
