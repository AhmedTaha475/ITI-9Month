#include <stdio.h>
#include <stdlib.h>
/// when you start this function a local scope variables x,y will be created
///it doesn't have anything with the variables that was entered as input parameters to that function
///so only x,y will be swaped not the  real variable in the main function scope
void SwapByValue(int x,int y)
{
    int temp=x;
    x=y;
    y=temp;

}
///int that case pointer x,y refer to the location of the input parameters and change their actual values
void SwapByReferance(int* x,int* y)
{
    int temp=*x;
    *x=*y;
    *y=temp;

}


int main()
{

    int a=5,b=6;
    SwapByValue(a,b);
    printf("Swap By value:\n");
    printf("A is :%i and B is :%i\n" ,a,b);
    printf("------------------\n");
    printf("Swap by Ref : \n");
    SwapByReferance(&a,&b);
    printf("A is :%i and B is :%i\n" ,a,b);



    return 0;
}
