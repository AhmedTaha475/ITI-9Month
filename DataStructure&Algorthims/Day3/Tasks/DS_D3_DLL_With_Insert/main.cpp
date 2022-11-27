#include <iostream>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

class Node
{
public:
    int Data;
    Node* Pnext;
    Node* Pprev;


};

class LinkedList
{
public:
        Node* Pstart;
        Node* Plast;

        LinkedList()
        {
            Pstart=Plast=NULL;
        }
Node* NewNode( int d)
{
    Node* Pnew = new Node();
    if(Pnew==NULL)
        exit(0);
    Pnew->Data=d;
    Pnew->Pnext=NULL;
    Pnew->Pprev=NULL;
    return Pnew;
};

void AddNode( int d)
{
    Node* Pnew=NewNode(d);
    if(Plast==NULL)
        Plast=Pstart=Pnew;

    else
    {
        Plast->Pnext=Pnew;
        Pnew->Pprev=Plast;
        Plast=Pnew;
    }
}


Node* SearchList(int id)
{
    Node* Psearch=Pstart;
    while(Psearch!=NULL)
    {
        if(Psearch->Data==id)
            break;
        Psearch=Psearch->Pnext;
    }
    return Psearch;

};

void display( int Id)
{
    Node* Pdis= SearchList(Id);
    if(Pdis==NULL)
        cout<<"Not Found"<<endl;
    else
        cout<<"Data: "<<Pdis->Data<<endl;
}

void DisplayAll()
{
    Node* Pda=Pstart;
    while(Pda!=NULL)
    {
        cout<<endl;
        cout<<"ID: "<<Pda->Data<<endl;
        Pda=Pda->Pnext;
    }
}

void DeleteNode( int d)
{
    Node* Pdel=SearchList(d);
    if(Pdel==NULL)

        cout<<"Not Found "<<endl;
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
    Node* Temp;
    while(Pstart!=NULL)
    {
        Temp=Pstart;
        Pstart=Pstart->Pnext;

        delete Temp;
    }
    Plast=NULL;
}

void insertNode(int d)
{
    Node* Pnew = NewNode(d);

    if(Pstart==NULL)
        Pstart=Plast=Pnew;
    else
    {
        Node * Psr=Pstart;

        while((Psr!=NULL)&&(Psr->Data<d))
            Psr=Psr->Pnext;

        if(Psr==NULL) /// adding in the last
            {
                Plast->Pnext=Pnew;
                Pnew->Pprev=Plast;
                Plast=Pnew;
            }
       else if(Psr==Pstart) /// adding first
       {
           Pstart->Pprev=Pnew;
           Pnew->Pnext=Pstart;
           Pstart=Pnew;
       }
       else /// general case
       {

           Pnew->Pnext=Psr;
           Pnew->Pprev=Psr->Pprev;
           Psr->Pprev->Pnext=Pnew;
           Psr->Pprev=Pnew;

       }
    }



}


};


int main()
{
    LinkedList l1;

        l1.insertNode(5);
        l1.insertNode(4);
        l1.insertNode(10);
        l1.insertNode(1);
        l1.insertNode(9);
        l1.insertNode(6);
        l1.insertNode(9);
        l1.insertNode(3);

    l1.DisplayAll();
    return 0;
}
