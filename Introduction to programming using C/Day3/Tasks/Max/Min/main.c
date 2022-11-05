#include <stdio.h>
#include <stdlib.h>

void main()
{
   int arr[7]={0};
   int i;
    printf("Please Enter the array: \n");

    for(i=0;i<7;i++)
    {
        printf("Enter number %i \n",i+1);
        scanf("%i",&arr[i]);
    }
   int max=arr[0],min=arr[0];
    printf("\n");
    for(i=0;i<7;i++)
        printf("%i,",arr[i]);
    printf("\n");
   for(i=0;i<7;i++)
    {
        if(arr[i]<min)
            min=arr[i];
        if(arr[i]>max)
            max=arr[i];
    }
    printf("Max is : %i \n",max);
    printf("Min is : %i \n",min);

}
