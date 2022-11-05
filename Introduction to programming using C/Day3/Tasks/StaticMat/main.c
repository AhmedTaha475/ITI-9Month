#include <stdio.h>
#include <stdlib.h>

void main()
{
    int mat1[3][2]={{1,2},{3,4},{5,6}};
    int mat2[2][1]={{2},{2}};
    int matR[3][1];
    int i,j,k,sum;

    for(i=0;i<3;i++)
    {
        sum=0;
         for(k=0;k<1;k++)
            {
                for(j=0;j<2;j++)
                    {
                        sum+=mat1[i][j]*mat2[j][k];
                    }
                matR[i][k]=sum;
            }

    }



    printf("Result is :\n");
    for(i=0;i<3;i++)
    {
        printf("%i\n",matR[i][0]);
    }
}
