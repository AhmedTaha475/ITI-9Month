#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#include <string.h>
#define NormalPen 0x0F
#define HighlightPen 0xF0
#define Enter 0x0D
#define Esc 27

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
double NetSalary(double salary,double deduct,double overtime)
{
    return salary+overtime-deduct;
}
char** MultiLineEditor(int c,int* size,int* xPos,int* yPos,int* sChar,int* eChar )
{
    int i,j;
    char** MLines=(char**)malloc(c * sizeof(char*));///allocate the array of strings inside the heap
    for(i=0; i<8; i++) ///allocation of each array of char inside the heap  ,,,,Don't forget to free them in the main function after you take the data inside any other variable of Char**
    {
        MLines[i]=(char*)malloc(size[i]*sizeof(char));
    }
    ///Drawing the box for the inputs
    for(i=0; i<c; i++)
    {
        textattr(HighlightPen);
        for(j=0; j<size[i]-1; j++)
        {

            gotoxy(xPos[i]+j,yPos[i]);
            printf(" ");
        }

    }

    /// End of drawing
    int CurrentLine=0;///refers to the Line of each input 0--->7
    char temp; ///holds the char from user;
    int bFlag=0;///the outer do while flag;
    int CCounter[c],ECounter[c]; ///for moving inside everyLine
    for(i=0; i<c; i++)
    {
        CCounter[i]=0;
        ECounter[i]=0;
    }
    do
    {
        gotoxy(xPos[CurrentLine]+CCounter[CurrentLine],yPos[CurrentLine]);///goto the place where you were at each input
        temp=_getch();
        if(temp==-32)
        {
            temp=_getch();///Get the real key from the buffer
            switch(temp)/// up and down for movement around the form,else is for movement inside each line
            {
            case 71:///Home Key
                CCounter[CurrentLine]=0;
                break;
            case 79:///End Key
                CCounter[CurrentLine]=ECounter[CurrentLine];
                break;
            case 75:///LeftArrow
                CCounter[CurrentLine]--;
                if(CCounter[CurrentLine]<0)
                    CCounter[CurrentLine]=0;
                break;
            case 77:///RightArrow
                CCounter[CurrentLine]++;
                if(CCounter[CurrentLine]>ECounter[CurrentLine])
                    CCounter[CurrentLine]=ECounter[CurrentLine];
                break;
            case 72:///UpArrow
                CurrentLine--;
                if(CurrentLine<0)
                    CurrentLine=c-1;
                break;
            case 80:///DownArrow
                CurrentLine++;
                if(CurrentLine>c-1)
                    CurrentLine=0;
                break;



            }

        }
        else
        {
            switch(temp)
            {
            case 13: ///Case Enter gets the whole data from all inputs and then leave the form to the menu
                for(i=0; i<c; i++)
                {
                    if(ECounter[i]==size[i]-2)
                    {
                        MLines[i][ECounter[i]+1]='\0';
                    }
                    else
                    {
                        MLines[i][ECounter[i]]='\0';
                    }
                }
                bFlag=1;
                break;
            case 27:///Case ESC terminates the form and back to the loop
                bFlag=1;
                break;
            case 9:///Tab moves downward on the form and then back to the first
                CurrentLine++;
                if(CurrentLine>c-1)
                    CurrentLine=0;
                break;
            default:
                if((size[CurrentLine]==2)&&(temp=='f'||temp=='F'||temp=='m'||temp=='M'))///Gender Case lets hope it works good like that
                {

                    MLines[CurrentLine][CCounter[CurrentLine]]=temp;
                    printf("%c",temp);


                }
                else if(temp>=sChar[CurrentLine]&&temp<=eChar[CurrentLine])
                {
                    MLines[CurrentLine][CCounter[CurrentLine]]=temp;///creating the string for each input except gender
                    printf("%c",temp);
                    if((ECounter[CurrentLine]!=size[CurrentLine]-2)&&(ECounter[CurrentLine]==CCounter[CurrentLine]))
                    {
                        ECounter[CurrentLine]+=1;
                        CCounter[CurrentLine]+=1;
                    }
                }
                else
                {
                    temp=_getch();
                }
                break;

            }





        }
    }
    while(!bFlag);
    return MLines;

}

struct Employee
{
    int ID,Age;
    char Gender,Name[10],Address[10];
    int Salary,overTime,Deduct;
};
struct DDL
{
    struct Employee Data;
    struct DDL* Pnext;
    struct DDL* Pprev;

};

struct DDL* Pstart;
struct DDL* Plast;




///LinkedList Functions
struct DDL* NewNode(struct Employee Emp)
{
    struct DDL* Pnew = (struct DDL*) malloc(sizeof(struct DDL));
    if(Pnew==NULL)
        exit(0);
    Pnew->Data=Emp;
    Pnew->Pnext=NULL;
    Pnew->Pprev=NULL;
    return Pnew;
};
void AddNode(struct Employee emp)
{
    struct DDL* Pnew=NewNode(emp);
    if(Plast==NULL)
        Plast=Pstart=Pnew;
    else
    {
        Plast->Pnext=Pnew;
        Pnew->Pprev=Plast;
        Plast=Pnew;
    }
}

struct DDL* SearchList(int id)
{
    struct DDL* Psearch=Pstart;
    while(Psearch!=NULL)
    {
        if(Psearch->Data.ID==id)
            break;
        Psearch=Psearch->Pnext;
    }
    return Psearch;

};

void display(struct Employee emp)
{
    struct DDL* Pdis= SearchList(emp.ID);
    if(Pdis==NULL)
        printf("Not Found\n");
    else
        printf("%d \n",Pdis->Data.ID);
}

void DisplayAll()
{
    struct DDL* Pda=Pstart;
    while(Pda!=NULL)
    {
        printf("\nID:%i Name:%s Age:%i Gender:%c Address:%s  NetSalary:%lf\n",Pda->Data.ID,Pda->Data.Name,Pda->Data.Age,Pda->Data.Gender,Pda->Data.Address,NetSalary(Pda->Data.Salary,Pda->Data.Deduct,Pda->Data.overTime));
        Pda=Pda->Pnext;
    }
}

void DeleteNode(struct Employee emp)
{
    struct DDL* Pdel=SearchList(emp.ID);
    if(Pdel==NULL)
        printf("Not Found \n");
    else
    {
        if(Pstart==Plast)
            Pstart=Plast=NULL;
        else if (Pstart==Pdel)
        {
            Pstart=Pstart->Pnext;
            Pstart->Pprev=NULL;
        }
        else if(Plast==Pdel)
        {
            Plast=Plast->Pprev;
            Plast->Pnext=NULL;
        }
        else
        {
            Pdel->Pprev->Pnext=Pdel->Pnext;
            Pdel->Pnext->Pprev=Pdel->Pprev;
        }
        free(Pdel);
    }
}

void DeleteAll()
{
    struct DDL* Temp;
    while(Pstart!=NULL)
    {
        Temp=Pstart;
        Pstart=Pstart->Pnext;
        free(Temp);
    }
    Plast=NULL;
}

int main()
{
    int i,current=0,EFlag=0,EmpIndex,tempId,counter=0,counter1=0,counter2=0,counter3=0;
    char test='y',TempName[10];
    struct DDL* SP;
    char** Data;///Don't forget to free that
    int c=8;
    int size[8]= {4,11,9,9,11,3,2,9};
    int xPos[8]= {8,10,12,12,13,34,37,40};
    int yPos[8]= {2,5,8,11,14,2,5,8};
    int sChar[8]= {48,65,48,48,65,48,71,48};
    int eChar[8]= {57,122,57,57,122,57,71,57};


    char Menu[6][13]= {"New         ","DisplayByID ","DisplayAll  ","DeleteByID  ","DeleteALL   ","Exit        "},ch;



    do
    {

        textattr(NormalPen);
        system("cls");
        for(i=0; i<6; i++)
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
                printf("Enter Employee ID:\n");
                scanf("%i",&EmpIndex);
                SP=SearchList(EmpIndex);
                _flushall();
                if(SP !=NULL)
                {
                    printf("This Index Already Has Data Do you Want to overwrite it y/n  ?");
                    test=getchar();
                }


                system("cls");
                if(test=='y'||test=='Y')
                {
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
                    Data=MultiLineEditor(c,size,xPos,yPos,sChar,eChar);
                    E.ID=atoi(Data[0]);
                    strcpy(E.Name,Data[1]);
                    E.Salary=atoi(Data[2]);
                    E.Deduct=atoi(Data[3]);
                    strcpy(E.Address,Data[4]);
                    E.Age=atoi(Data[5]);
                    E.Gender=Data[6][0];
                    E.overTime=atoi(Data[7]);
                    AddNode(E);
                    for(i=0; i<c; i++) ///using free on each array of ch
                    {
                        free(Data[i]);
                    }
                    free(Data); ///using free to free the Array of strings
                }
                break;
            case 1: ///DisplayByID
                system("cls");
                counter3=0;
                printf("Please Enter Id:");
                scanf("%i",&tempId);
                SP=SearchList(tempId);
                if(SP!=NULL)
                {
                    printf("\nID:%i Name:%s Age:%i Gender:%c Address:%s  NetSalary:%lf\n",SP->Data.ID,SP->Data.Name,SP->Data.Age,SP->Data.Gender,SP->Data.Address, NetSalary(SP->Data.Salary,SP->Data.Deduct,SP->Data.overTime));
                    counter3++;
                }

                if(counter3==0)
                    printf("No Data Found\n");
                _getch();
                break;
            case 2:   //DisplayALl
                system("cls");
                DisplayAll();
                _getch();
                break;
            case 3:                    //Delete By ID
                system("cls");
                counter1=0;
                printf("Enter ID :");
                scanf("%i",&tempId);
                SP=SearchList(tempId);
                if(SP!=NULL)
                {
                    DeleteNode(SP->Data);
                    counter1=1;
                    printf("Data Row has been deleted by ID");
                }


                if(counter1==0)
                {
                    printf("No data with That ID Found");
                }
                _getch();
                break;
            case 4: // Delete ALL
                system("cls");
                counter=0;
                _flushall();


                DeleteAll();
                printf("All rows has been deleted");
                counter=1;



                if(counter ==0)
                {
                    printf("No data with That Name Found");
                }
                _getch();
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

    }
    while(!EFlag);


    return 0;
}







/*

    struct Employee d1;
    d1.ID=0;
    d1.Salary=2500;

    struct Employee d2;
    d2.ID=1;
    d2.Salary=4500;

    struct Employee d3;
    d3.ID=2;
    d3.Salary=3500;

    AddNode(d1);
    AddNode(d2);
    AddNode(d3);

    //display(d2);
    DisplayAll();
    printf("--------------------------\n");
    DeleteNode(d2);
    DisplayAll();
    printf("---------------------------\n");
    DeleteAll();
    DisplayAll();
*/











