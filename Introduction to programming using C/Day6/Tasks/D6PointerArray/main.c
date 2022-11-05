#include <stdio.h>
#include <stdlib.h>

int main()
{

    int arr[5];
    int* ptr;
    ptr=arr;
    int i;
    printf("Please enter your numbers:\n");
    for(i=0;i<5;i++)
    {

        printf("Please enter no%i : \n",i+1);
        scanf("%i",ptr);
        ptr++;
    }
    ptr=arr;
    printf("Output is :\n");
    for(i=0;i<5;i++)
    {
            printf("%i,",*ptr);
            ptr++;
    }

    return 0;
}
