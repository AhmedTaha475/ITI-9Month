#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i=0;
    do{

    printf("\nEnter Key \n");
    char ch = _getch();
    if(ch==-32){
            ch=_getch();
        printf("ASCI IS %i",ch);

    }
    }while(i<10);















    return 0;
}
