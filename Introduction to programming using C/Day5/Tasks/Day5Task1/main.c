#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
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
/*void textattr (int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),i);
}*/

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

struct Employee E;
E.ID=-1;
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
scanf("%i",&E.ID);
gotoxy(10,5);
_flushall();
gets(E.Name);
gotoxy(12,8);
scanf("%lf",&E.Salary);
gotoxy(12,11);
scanf("%lf",&E.Deduct);
gotoxy(13,14);
_flushall();
gets(E.Address);
gotoxy(34,2);
scanf("%i",&E.Age);
gotoxy(37,5);
_flushall();
scanf("%c",&E.Gender);
gotoxy(40,8);
scanf("%lf",&E.overTime);
gotoxy(0,17);

printf("ID:%i  Name:%s  Net:%lf",E.ID,E.Name,NetSalary(E.Salary,E.Deduct,E.overTime));
    return 0;
}
