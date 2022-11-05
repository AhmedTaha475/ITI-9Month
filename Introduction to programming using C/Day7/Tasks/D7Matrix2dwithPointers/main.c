#include <stdio.h>
#include <stdlib.h>

int main()
{
    int **marks,stdn,subn,i,j,*sum,*avg;
    printf("Please Enter student number :\n");
    scanf("%i",&stdn);
    marks=(int**)malloc(stdn*sizeof(int*));
    sum=(int*)malloc(stdn*sizeof(int));
    printf("Please Enter the number of Subjects :\n");
    scanf("%i",&subn);
    for(i=0;i<stdn;i++)
        marks[i]=(int*)malloc(subn*sizeof(int));
    avg=(int*)malloc(subn*sizeof(int));
    for(i=0;i<stdn;i++)
            sum[i]=0;
    for(i=0;i<subn;i++)
        avg[i]=0;
     for(i=0;i<stdn;i++)
     {
         for(j=0;j<subn;j++)
         {
             printf("Subject(%i) for Student (%i) : ",j+1,i+1);
             scanf("%i",&marks[i][j]);
             sum[i]+=marks[i][j];
             avg[j]+=marks[i][j];
         }
         printf("---------------\n");
     }
     printf("The Matrix is self :\n");
     for(i=0;i<stdn;i++)
     {
         for(j=0;j<subn;j++)
         {
             printf("%i ,",marks[i][j]);
         }
         printf("\n");
     }
printf("Sum of Each row :\n");
for(i=0;i<stdn;i++)
{
    printf("Sum of Row %i is : %i\n",i+1,sum[i]);
}
printf("Avg of Each Col :\n");
for(j=0;j<subn;j++)
{
    printf("Avg of Col %i is : %i \n",j+1,(avg[j]/subn));
}

free(sum);
free(avg);
for(i=0;i<stdn;i++)
    free(marks[i]);
free(marks);
    return 0;
}
