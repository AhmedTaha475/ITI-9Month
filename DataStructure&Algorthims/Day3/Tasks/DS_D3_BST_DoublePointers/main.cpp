#include <iostream>
#include<stdlib.h>
using namespace std;

class Node
{
public:
    int key;
    Node* left;
    Node* right;
};
Node* root;


Node* SearchTree(Node* proot,int key)
{

    if(proot!=NULL)
    {
        if(proot->key==key)
            return proot;
        else if (key<proot->key)
            return SearchTree(proot->left,key);
        else
            return SearchTree(proot->right,key);
    }
    return NULL;
}

int countNode(Node* proot)
{
    if(proot!=NULL)
        return countNode(proot->left)+1+countNode(proot->right);
    return 0;
}

void TreeTraverse(Node* proot)
{
    if(proot!=NULL)
    {
        ///go left ///root /// go right  ///In order format
        TreeTraverse(proot->left);
        cout<<proot->key<<"\t";
        TreeTraverse(proot->right);
    }
}


Node* NewNode()
{
    Node* Pnew=new Node();
    if(Pnew==NULL)
        exit(0);
    Pnew->left=Pnew->right=NULL;
    cout<<"Enter your Node Data"<<endl;
    cin>>Pnew->key;
    return Pnew;
}


void InsertNode(Node* proot,Node* pleaf,Node* Pnew) ///Two pointers to make sure the main root isn't checked again
{

    if (pleaf==NULL)
    {
        if(proot==NULL)
            root=Pnew;
        else
        {
            if(proot->key>Pnew->key)
                proot->left=Pnew;
            else if (proot->key==Pnew->key) /// not allowing duplicate keys
                cout<<Pnew->key<<" is a Duplicate key "<<endl;
            else
                proot->right=Pnew;
        }
    }

    else if(Pnew->key < pleaf->key)
        InsertNode(pleaf,pleaf->left,Pnew);
    else
        InsertNode(pleaf,pleaf->right,Pnew);

}

void DeleteNode (Node* &proot);
int GetMax(Node* proot);

Node* Delete(Node* &proot,int key)
{
    Node* Psearch = SearchTree(proot,key); /// to check if the key you want to delete exist in the tree or not
    if(Psearch!=NULL)
    {
        if(key<proot->key)
            Delete(proot->left,key);
        else if(key>proot->key)
            Delete(proot->right,key);
        else  /// 3 cases of delete node
        {
            DeleteNode(proot);
        }
    }
    return Psearch;

}


void DeleteNode (Node* &proot)
{
    Node* Pdelete = proot;
///if leaf or node with single child
    if(proot->left==NULL)
    {
        proot=proot->right;
        delete Pdelete;
    }
    else if (proot->right==NULL)
    {
        proot=proot->left;
        delete Pdelete;
    }
    else
    {
        int TempKey = GetMax(proot->left); ///get max in left sub tree
        proot->key=TempKey;  ///swap the value with the max child on the left
        Delete(proot->left,TempKey); /// delete redundant key from left sub tree
    }


}

int GetMax(Node* proot)
{
    while(proot->right!=NULL)
    {
        proot=proot->right;
    }
    return proot->key;
}






int main()
{

    for(int i=0; i<5; i++)
        InsertNode(root,root,NewNode());


    cout<<"--------------------------"<<endl;
    TreeTraverse(root);
    cout<<endl<<"Node Count:"<<countNode(root)<<endl;
    cout<<"------------------------------------"<<endl;
    cout<<"Select Node You want to search for"<<endl;
    int x;
    cin>>x;
    Node* psearch = SearchTree(root,x);
    if(psearch!=NULL)
        cout<<"Found"<<endl;
    else
        cout<<"Not Found"<<endl;
    cout<<"-----------------------------"<<endl;
    cout<<"Delete Node :" <<endl;
    int del;
    cin>>del;
    if (Delete(root,del)==NULL)
        cout<<"This Key doesn't exist"<<endl;
    else
        TreeTraverse(root);
    return 0;
}
