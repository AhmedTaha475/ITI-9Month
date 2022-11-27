#include <iostream>

using namespace std;
int BinarySearch(int* arr,int low , int high , int value)
{
    if(low<=high)
    {
        int mid = (low+high)/2;

        if(value ==arr[mid])
            return mid;
        else if (value <arr[mid])
           return BinarySearch(arr,low,mid-1,value);
        else
            return BinarySearch(arr,mid+1,high,value);
    }
 return -1;
}
int main()
{
int arr[7]={1,2,3,4,5,6,7};

cout<<"Binary Search value:" <<BinarySearch(arr,0,6,5)<<endl;

    return 0;
}
