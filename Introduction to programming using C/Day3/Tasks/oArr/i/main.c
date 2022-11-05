#include <stdio.h>
#include <stdlib.h>

void main()
{

int arr[5] ={0};
int i;
printf("Please enter 5 numbers :\n");

for(i=0;i<5;i++)
{
    printf("Please Enter  Number %i\n",i+1);
    scanf("%i",&arr[i]);
}
printf("Output is : \n");
for(i=0;i<5;i++)
{
    printf("%i,",arr[i]);
}




int x=0%2;

printf("---------------------------\n");
printf("%i",x);

}
