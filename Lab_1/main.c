#include <stdio.h>
#include <windows.h>

void main()
{
    char buffer[200];
    HANDLE handout = GetStdHandle(STD_OUTPUT_HANDLE);
    HANDLE handin = GetStdHandle(STD_INPUT_HANDLE);
    int len;
    WriteFile(handout, "Write a message\n", strlen("Write a message\n"),&len, NULL);
    ReadFile(handin, buffer, 200, &len, NULL);
    WriteFile(handout, "Your message: ", strlen("Your message: "), &len, NULL);
    WriteFile(handout, buffer, strlen(buffer), &len, NULL);

}
