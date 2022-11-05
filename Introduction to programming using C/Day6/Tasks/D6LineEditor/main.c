#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#define NormalPen 0x0F
#define HighlightPen 0xF0
#define MyPen 0xFF
#include <string.h>
struct Employee
{
    int Id,Age;
    char Gender,Name[10],Address[10];
    int Salary,OverTime,Deduct;


};


char* LineEditor(int xPos,int yPos,char sChar,char eChar)
{
    char name[10];
    char temp;
    int flag=0;
    int current=0,start=0,end=0,i;
    int* currentCounter=&current;
     int* sCounter=&start;
     int* eCounter=&end;
    for(i=0;i<10;i++)
    {
    textattr(HighlightPen);

        gotoxy(xPos+i,yPos);
        printf(" ");
    }
    textattr(NormalPen);
    gotoxy(xPos,yPos);

do{
    gotoxy(xPos+*currentCounter,yPos);
     temp=getch();

    if(temp>=sChar&&temp<=eChar)
    {
        name[*currentCounter]=temp;
        *currentCounter+=1;
        *eCounter+=1;
        if(*currentCounter>=10)
            flag=1;

    }
    else if (!isprint(temp))
    {
        temp=getch();
        switch (temp)
        {
        case 13:         ///enter
            name[*currentCounter]='\0';
                flag=1;
            break;
        case 27:     ///esc
            flag=1;
            break;
        case 75:   ///left arrow
            *currentCounter--;
            if(*currentCounter<*sCounter)
                *currentCounter=*sCounter;
            break;
        case 77:  /// right arrow
            *currentCounter+=1;
            if(*currentCounter>*eCounter)
                *currentCounter=*eCounter;
            break;
        case 71:    /// home
            *currentCounter=*sCounter;
            break;
        case 79:   ///end
            *currentCounter=*eCounter;
            break;

        }
    }


}while(!flag);

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
strcpy(E.Name,LineEditor(10,5,'A','z'));
E.Salary= atoi(LineEditor(12,8,'0','9'));
E.Deduct=atoi(LineEditor(12,11,'0','9'));
strcpy(E.Address,LineEditor(13,14,'A','z'));
E.Age= atoi(LineEditor(34,2,'0','9'));
E.Gender=LineEditor(37,5,'M','F')[0];
E.OverTime=atoi(LineEditor(40,8,'0','9'));




_getch();
    return 0;
}
