#include <stdio.h>
#include <stdlib.h>

void main()
{
    printf("Please choose From the Menu (a b c):\na-Sports\nb-Movies\nc-Animals\n");
    char x = getchar();

    switch(x)
    {
    case 'a':
    case 'A':
        printf("Sports");
        break;
    case 'b':
    case 'B':
        printf("Movies");
        break;
    case 'c':
    case 'C':
        printf("Animals");
        break;
    default:
        printf("N/A");
        break;
    }
}
