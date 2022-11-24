#include <iostream>

using namespace std;

void MySwap(int& a,int &b)
{
    int temp=a;
    a=b;
    b=temp;
}

void BSortAsc(int* arr, int Size)
{
    bool sorted=false;
    for(int i=0;(i<Size)&&(!sorted);i++)
    {
        sorted=true;
        for(int j=0;j<Size-i-1;j++)
        {
            if(arr[j]>arr[j+1])
            {
                MySwap(arr[j],arr[j+1]);
                sorted=false;
            }
        }
    }
}

int main()
{
    int arr[5]={1,9,3,2,5};
    BSortAsc(arr,5);
    for(int i=0;i<5;i++)
        cout<<arr[i]<<endl;
    return 0;
}
