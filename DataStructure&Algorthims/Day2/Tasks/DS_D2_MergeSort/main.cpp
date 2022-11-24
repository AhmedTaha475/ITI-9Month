#include <iostream>

using namespace std;

void MergeArr(int* arr,int lfirst, int llast, int rfirst, int rlast)
{
    int* temp=new int[10];
    int Index=lfirst;
    int saveFirst=lfirst;
    while((lfirst<=llast)&& (rfirst<=rlast))
    {
        if(arr[lfirst]<arr[rfirst])
            temp[Index++]=arr[lfirst++];
        else
            temp[Index++]=arr[rfirst++];
    }
    while(lfirst<=llast)
    {
        temp[Index++]=arr[lfirst++];

    }
    while(rfirst<=rlast)
    {
        temp[Index++]=arr[rfirst++];

    }

    for(int i=saveFirst;i<=rlast;i++)
            arr[i]=temp[i];
}

void MergeSort(int* arr,int first,int last)
{
    if(first<last)
    {
        int middle=(first+last)/2;
        MergeSort(arr,first,middle);
        MergeSort(arr,middle+1,last);
        MergeArr(arr,first,middle,middle+1,last);
    }
}


int main()
{
    int arr[10]={1,6,5,9,0,32,46,10,2,5};
    MergeSort(arr,0,9);

    for(int i=0;i<10;i++)
        cout<<arr[i]<<endl;
    return 0;
}
