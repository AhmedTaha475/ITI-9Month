#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#define NormalPen 0x0F
#define HighlightPen 0xF0
#define Enter 0x0D
#define Esc 27
double NetSalary(double salary,double deduct,double overtime)
{
    return salary+overtime-deduct;
}
struct Employee
{
    int ID,Age;
    char Gender,Name[100],Address[200];
    double Salary,overTime,Deduct;
};

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


char Menu[3][8]={"New    ","Display","Exit   "},ch;

int i,current=0,EFlag=0;
struct Employee E[3];
for(i=0;i<3;i++)
{
    E[i].ID=-1;
}
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
    case 0:///New
        system("cls");
        for(i=0;i<3;i++)
        {
            system("cls");
            gotoxy(0,0);
            printf("Enter Employee %i\n",i);


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

gotoxy(8,2);
scanf("%i",&E[i].ID);
gotoxy(10,5);
_flushall();
gets(E[i].Name);
gotoxy(12,8);
scanf("%lf",&E[i].Salary);
gotoxy(12,11);
scanf("%lf",&E[i].Deduct);
gotoxy(13,14);
_flushall();
gets(E[i].Address);
gotoxy(34,2);
scanf("%i",&E[i].Age);
gotoxy(37,5);
_flushall();
scanf("%c",&E[i].Gender);
gotoxy(40,8);
scanf("%lf",&E[i].overTime);


        }
        //printf("Welcome To New \nEnter New Character\n ");
        break;
    case 1: ///Display
        system("cls");
        for(i=0;i<3;i++)
        {
            if(E[i].ID!=-1)
            printf("ID:%i Name:%s  NetSalary:%lf\n",E[i].ID,E[i].Name,NetSalary(E[i].Salary,E[i].Deduct,E[i].overTime));
            else
                printf("No Data Found\n");
        }
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
