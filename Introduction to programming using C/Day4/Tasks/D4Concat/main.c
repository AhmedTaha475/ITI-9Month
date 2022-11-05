#include <stdio.h>
#include <stdlib.h>
#include<string.h>
int main()
{
    char Name1[10],Name2[10];

    printf("Please Enter First Name\n");
    gets(Name1);

    printf("Please Enter Second Name\n");
    gets(Name2);

        strcat(Name1," ");
        strcat(Name1,Name2);

        puts(Name1);
    return 0;
}
