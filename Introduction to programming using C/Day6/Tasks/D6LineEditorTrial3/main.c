#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#define NormalPen 0x0F
#define HighlightPen 0xF0
#define MyPen 0xFF
#include <string.h>
char name[0];
struct Employee
{
    int Id,Age;
    char Gender;
    char Name[10], Address[10];

    int Salary,OverTime,Deduct;


};


char* LineEditor(int xPos,int yPos,char sChar,char eChar)
{

    char temp;
    int flag=0,Gflag=0;
    int current=0,start=0,end=0,i;
    int* currentCounter=&current;
    int* sCounter=&start;
    int* eCounter=&end;
    for(i=0; i<10; i++)
    {
        textattr(HighlightPen);

        gotoxy(xPos+i,yPos);
        printf(" ");
    }
    textattr(NormalPen);
    gotoxy(xPos,yPos);

    do
    {
        gotoxy(xPos+current,yPos);
        temp=getch();
        if (sChar=='G'&&eChar=='G')
        {

            while(!Gflag)
            {
                if(temp=='M'||temp=='m'||temp=='f'||temp=='F')
                {
                    name[current]=temp;
                    textattr(HighlightPen);
                    printf("%c",name[0]);
                    Gflag=1;
                    end+=1;
                    current+=1;
                    sChar='N';
                    eChar='N';
                }
                else
                {
                    temp=getch();
                }
            };

        }
        else if(temp>=sChar&&temp<=eChar&&end<10)
        {

            name[current]=temp;
            textattr(HighlightPen);
            printf("%c",name[current]);
            if(end!=10&&current==end)
            {
                current+=1;
                end+=1;
            }


        }

        else if (temp==13)
        {
            name[end]='\0';
            flag=1;
        }
        else if (temp==27)
        {
            flag=1;
        }
        else if (!isprint(temp))
        {
            temp=getch();
            switch (temp)
            {
            case 75:   ///left arrow
                current--;
                if(current<start)
                    current=start;
                break;
            case 77:  /// right arrow
                current+=1;
                if(current>end)
                    current=end;
                break;
            case 71:    /// home
                current=start;
                break;
            case 79:   ///end
                current=end;
                break;

            }
        }


    }
    while(!flag);
    return name;
}



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
int main()
{
    int i;

    struct Employee E;




    gotoxy(5,2);
    printf("ID: ");
    gotoxy(5,5);
    printf("Name: ");
    gotoxy(5,8);
    printf("Salary: ");
    gotoxy(5,11);
    printf("Deduct: ");
    gotoxy(5,14);
    printf("Address: ");
    gotoxy(30,2);
    printf("Age: ");
    gotoxy(30,5);
    printf("Gender: ");
    gotoxy(30,8);
    printf("Over Time:");

    E.Id=atoi(LineEditor(8,2,'0','9'));
    strcpy(E.Name,LineEditor(10,5,'A','z')) ;
    E.Salary= atoi(LineEditor(12,8,'0','9'));
    E.Deduct=atoi(LineEditor(12,11,'0','9'));
    strcpy(E.Address,LineEditor(13,14,'A','z'));
    E.Age= atoi(LineEditor(34,2,'0','9'));
    E.Gender=LineEditor(37,5,'G','G')[0];
    E.OverTime=atoi(LineEditor(40,8,'0','9'));


gotoxy(0,16);
    return 0;
}
