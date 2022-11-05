#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#include <string.h>
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
    int i,current=0,EFlag=0,EmpIndex,tempId,counter=0,counter1=0,counter2=0,counter3=0;
    char TempName[100],test='y';
    struct Employee E[10];
for(i=0;i<10;i++)
{
    E[i].ID=-1;
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


char Menu[6][13]={"New         ","DisplayByID ","DisplayAll  ","DeleteByID  ","DeleteByName","Exit        "},ch;



do{

textattr(NormalPen);
system("cls");
for(i=0;i<6;i++)
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
            gotoxy(0,0);
            printf("Enter Employee Index:\n");
            scanf("%i",&EmpIndex);
            _flushall();
            if(E[EmpIndex].ID!=-1)
                {
                    printf("This Index Already Has Data Do you Want to overwrite it y/n  ?");
                    test=getchar();
                }


system("cls");
if(test=='y'||test=='Y'){
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
_flushall();
gotoxy(8,2);
scanf("%i",&E[EmpIndex].ID);
gotoxy(10,5);
_flushall();
gets(E[EmpIndex].Name);
gotoxy(12,8);
scanf("%lf",&E[EmpIndex].Salary);
gotoxy(12,11);
scanf("%lf",&E[EmpIndex].Deduct);
gotoxy(13,14);
_flushall();
gets(E[EmpIndex].Address);
gotoxy(34,2);
scanf("%i",&E[EmpIndex].Age);
gotoxy(37,5);
_flushall();
scanf("%c",&E[EmpIndex].Gender);
gotoxy(40,8);
scanf("%lf",&E[EmpIndex].overTime);
}
        //printf("Welcome To New \nEnter New Character\n ");
        break;
    case 1: ///DisplayByID
        system("cls");
        counter3=0;
        printf("Please Enter Id:");
        scanf("%i",&tempId);
        for(i=0;i<10;i++){
            if(E[i].ID==tempId)
                {
                    printf("\nID:%i Name:%s  NetSalary:%lf\n",E[tempId].ID,E[tempId].Name,NetSalary(E[tempId].Salary,E[tempId].Deduct,E[tempId].overTime));
                    counter3++;
                }


        }
        if(counter3==0)
                printf("No Data Found\n");
        _getch();
        break;
    case 2:   //DisplayALl
        system("cls");
        for(i=0;i<10;i++)
        {
            if(E[i].ID!=-1)
               printf("ID:%i Name:%s  NetSalary:%lf\n",E[i].ID,E[i].Name,NetSalary(E[i].Salary,E[i].Deduct,E[i].overTime));
        }
        getch();
        break;
    case 3:                    //Delete By ID
        system("cls");
        counter1=0;
        printf("Enter ID :");
        scanf("%i",&tempId);
        for(i=0;i<10;i++)
        {
            if(E[i].ID==tempId)
            {
                E[i].ID=-1;
                counter1=1;
                printf("Data Row has been deleted by ID");
            }

        }
        if(counter1==0){
            printf("No data with That ID Found");
        }
        getch();
        break;
    case 4: // Delete By Name
                system("cls");
                counter=0;
        printf("Enter Name :");
        _flushall();
        gets(TempName);
        for(i=0;i<10;i++)
        {
            if(strcmp((E[i].Name),TempName)==0)
            {
                E[i].ID=-1;
                strcpy(E[i].Name," ");
                printf("Data row has been deleted");
                counter=1;
            }

        }
        if(counter ==0){
            printf("No data with That Name Found");
        }
        getch();
        break;
    case 5:
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
                current=5;
            break;
        case 80:  //down
            current++;
            if(current==6)
                current=0;
            break;
        case 71:   //home
            current=0;
            break;
        case 79:  //end
            current=5;
            break;
        }
    break;

}

}while(!EFlag);


    return 0;
}
