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


  int i,R,C,n;

do
{
printf("Enter the size \n");
scanf("%i",&n);
}while(n==1||n%2==0);
/*
for(i=0;;i++)
{
printf("Enter the size \n");
scanf("%i",&n);
if((n==1)||(n%2==0))
    continue;
else
    break;
}
*/
R=1;C=(n/2)+1;
for(i=1;i<=(n*n);i++)
    {
    gotoxy(C*3,R*3);
    printf("%i",i);
       if((i%n)==0)
       {
          R++;
          if(R>n)
            R=1;
       }


       else
        {

            R--;
            C--;

            if(R==0)
            {
                R=n;
            }
            if(C==0)
            {
                C=n;

            }

        }
    }
}
