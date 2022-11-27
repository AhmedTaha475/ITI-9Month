#include <iostream>

using namespace std;
int BinarySearchIt(int* arr,int Size, int Value)
{
    int low =0 , high=Size-1 ;

    while(low<=high)
    {
        int mid=(low+high)/2;

        if(Value==arr[mid])
            return mid;
        else if (Value<arr[mid])
            high=mid-1;
        else
            low=mid+1;
    }
    return -1;
}
int main()
{
   int arr[7]={1,2,3,4,5,6,7};

    cout<<"Binary Search value:" <<BinarySearchIt(arr,7,5)<<endl;
    return 0;
}
