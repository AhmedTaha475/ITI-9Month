#include <iostream>

using namespace std;

void MySwap(int& a,int &b)
{
    int temp=a;
    a=b;
    b=temp;
}

void BSortdesc(int* arr, int Size)
{
    bool sorted=false;
    for(int i=0;(i<Size)&&(!sorted);i++)
    {
        sorted=true;
        for(int j=0;j<Size-i-1;j++)
        {
            if(arr[j]<arr[j+1])
            {
                MySwap(arr[j],arr[j+1]);
                sorted=false;
            }
        }
    }
}

int main()
{
    int arr[6]={1,9,3,9,2,5};
    BSortdesc(arr,6);
    for(int i=0;i<6;i++)
        cout<<arr[i]<<endl;
    return 0;
}
