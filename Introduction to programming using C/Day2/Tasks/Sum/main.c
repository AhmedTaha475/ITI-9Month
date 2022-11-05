#include <stdio.h>
#include <stdlib.h>

void main()
{

    int sum=0,x;
    while(sum<100)
    {
        printf("Please type a number \n");
        scanf("%i",&x);
        sum+=x;
    }

    printf("%i",sum);


}
