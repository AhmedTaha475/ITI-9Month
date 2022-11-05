#include <stdio.h>
#include <stdlib.h>

void main()
{
    ///assume its array holding int arrays
    int arr[4][5];

     /// i=row,j=col
    int i,j;
    int sum[4]={0};
    int avg[5]={0};
    for(i=0;i<4;i++)
      {
          printf("Please Enter  arr%i : \n",i+1);
         for(j=0;j<5;j++)
            {
                //printf("Enter number %i\n",j+1);
                scanf("%i",&arr[i][j]);
                sum[i]+=arr[i][j];
                avg[j]+=arr[i][j];
            }
      }

printf("\n Sum of Each row is :\n");
for(i=0;i<4;i++)
    printf("%i\n",sum[i]);

printf("Avg of each column is : \n");
for(i=0;i<5;i++)
{
    printf("%i\n",avg[i]/5);
}
}
