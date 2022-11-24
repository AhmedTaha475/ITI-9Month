#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;
class Employee
{
public:
    int ID,Age;
    char Gender,Name[10],Address[10];
    int Salary,overTime,Deduct;
};

class DDL
{
public:
    Employee Data;
    DDL* Pnext;
    DDL* Pprev;


};
DDL* Pstart;
DDL* Plast;



DDL* NewNode( Employee Emp)
{
    DDL* Pnew = new DDL();
    if(Pnew==NULL)
        exit(0);
    Pnew->Data=Emp;
    Pnew->Pnext=NULL;
    Pnew->Pprev=NULL;
    return Pnew;
};
void AddNode( Employee emp)
{
    DDL* Pnew=NewNode(emp);
    if(Plast==NULL)
        Plast=Pstart=Pnew;

    else
    {
        Plast->Pnext=Pnew;
        Pnew->Pprev=Plast;
        Plast=Pnew;
    }
}

DDL* SearchList(int id)
{
    DDL* Psearch=Pstart;
    while(Psearch!=NULL)
    {
        if(Psearch->Data.ID==id)
            break;
        Psearch=Psearch->Pnext;
    }
    return Psearch;

};

void display( int Id)
{
    DDL* Pdis= SearchList(Id);
    if(Pdis==NULL)
        cout<<"Not Found"<<endl;
    else
        cout<<"Emp ID: "<<Pdis->Data.ID<<endl;
}

void DisplayAll()
{
    DDL* Pda=Plast;
    while(Pda!=NULL)
    {
        cout<<endl;
        cout<<"ID: "<<Pda->Data.ID<<endl;
        Pda=Pda->Pprev;
    }
}

void DeleteNode( Employee emp)
{
    DDL* Pdel=SearchList(emp.ID);
    if(Pdel==NULL)

        cout<<"Not Found dell"<<endl;
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

        delete Pdel;
    }
}

void DeleteAll()
{
    DDL* Temp;
    while(Pstart!=NULL)
    {
        Temp=Pstart;
        Pstart=Pstart->Pnext;

        delete Temp;
    }
    Plast=NULL;
}
class MyStack
{

public:
    bool IsFull()
    {
        return false;
    }
    bool IsEmpty()
    {
        return Pstart==NULL;
    }

    Employee Pop()
    {
        Employee temp;
        if(!IsEmpty())
        {
            temp = Plast->Data;
            DeleteNode(Plast->Data);
            return temp;
        }
        else
        {

            cout<<"Stack is Empty"<<endl;
            return temp;
        }
    }
    void Push(Employee e)
    {
        AddNode(e);
    }

    Employee Peek()
    {
        Employee e;
        if(!IsEmpty())
        {
            return Plast->Data;
        }
        else
        {
            cout<<"Stack is Empty PEEK"<<endl;
            return e;
        }
    }

    void ViewContent()
    {
        DisplayAll();
    }

};




int main()
{
    Employee e1;
    e1.ID=0;

    Employee e2;
    e2.ID=1;

    Employee e3;
    e3.ID=2;


    Employee e4;
    e4.ID=3;


    MyStack s1;
    s1.Push(e1);
    s1.Push(e2);
    s1.Push(e3);
    s1.Push(e4);

    s1.ViewContent();
    cout<<"----------------------------------"<<endl;
    Employee e= s1.Pop();
    cout<<"Emp ID:"<<e.ID<<endl;
    cout<<"-------------------------"<<endl;
    s1.ViewContent();
    cout<<"-------------------------------"<<endl;
    display(s1.Peek().ID);
    return 0;
}
