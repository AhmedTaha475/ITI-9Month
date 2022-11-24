#include <iostream>

using namespace std;
MySwap(int& a, int& b)
{
    int temp =a;
    a=b;
    b=temp;
}

int IndexOfMinValue(int* arr,int StartIndex, int EndIndex)
{
    int Index=StartIndex;
    for(int i=StartIndex+1;i<EndIndex;i++)
    {
        if(arr[i]<arr[Index])
            Index=i;
    }
    return Index;
}

void selectionSort(int * arr,int Size)
{

int Index;

for(int i=0;i<Size;i++)
{
    Index=IndexOfMinValue(arr,i,Size);
    MySwap(arr[i],arr[Index]);
}
}




int main()
{
 int arr[8]={2,6,8,0,1,6,5,7};
 selectionSort(arr,8);

 for(int i=0;i<8;i++)
    cout<<arr[i]<<endl;
    return 0;
}
