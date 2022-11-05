
#include <stdio.h>
#include <stdlib.h>

void main()
{
int n,m,x,s,i,j,k,sum;
printf("Please enter the Size of first Matrix : \n");
printf("Rows :\n");
scanf("%i",&n);
printf("Cols :\n");
scanf("%i",&m);

printf("Please enter the size of the second Matrix\n");
do{
    printf("Rows:\n");
    scanf("%i",&x);
}while(m!=x);
printf("Cols:\n");
scanf("%i",&s);

int mat1[n][m];
int mat2[x][s];
int mat3[n][s];

printf("Please enter the first Matrix \n");
for(i=0;i<n;i++)
{
    printf("Enter numbers of Row%i \n",i+1);
    for(j=0;j<m;j++)
    {
        scanf("%i",&mat1[i][j]);
    }
}



printf("Please enter the Second Matrix \n");
for(i=0;i<x;i++)
{
    printf("Enter numbers of Row%i \n",i+1);
    for(j=0;j<s;j++)
    {
        scanf("%i",&mat2[i][j]);
    }
}


for(i=0;i<n;i++)
{
    for(j=0;j<s;j++)
    {
        mat3[i][j]=0;
    }
}





////////////////////////////
for(i=0;i<n;i++)
    {

            for(j=0;j<m*s;j++)
            {
            mat3[i][j/m]+=mat1[i][j%m]*mat2[j%m][j/m];

            }

    }


    printf("Result is :\n");
    for(i=0;i<n;i++)
    {
        for(j=0;j<s;j++){
        printf("%i ,",mat3[i][j]);
        }
        printf("\n");
    }





}
