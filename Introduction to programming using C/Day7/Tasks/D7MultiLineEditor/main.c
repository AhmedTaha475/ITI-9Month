#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#define NormalPen 0x0F
#define HighlightPen 0xF0
#define MyPen 0xFF
#include <string.h>
char name[10];
struct Employee
{
    int Id,Age;
    char Gender;
    char Name[10], Address[10];
    int Salary,OverTime,Deduct;


};
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
        temp=getch();
        if(temp==-32)
        {
            temp=getch();///Get the real key from the buffer
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
                    temp=getch();
                }
                break;

            }





        }
    }
    while(!bFlag);
    return MLines;

}

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
    char** Data;
    int i;
    int c=8;
    int size[8]= {4,11,9,9,11,3,2,9};
    int xPos[8]= {8,10,12,12,13,34,37,40};
    int yPos[8]= {2,5,8,11,14,2,5,8};
    int sChar[8]= {48,65,48,48,65,48,71,48};
    int eChar[8]= {57,122,57,57,122,57,71,57};
///you will free data after you take it and use it from line editor dont forget:
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

///and we will see what will happen;
    Data=MultiLineEditor(c,size,xPos,yPos,sChar,eChar);
    system("cls");
    for(i=0; i<c; i++)
        printf("Data[%i] :%s \n",i,Data[i]);

    //_getch();
    return 0;
}
