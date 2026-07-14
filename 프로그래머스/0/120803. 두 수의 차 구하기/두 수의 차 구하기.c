#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int num1, int num2) {
    int answer = 0;
    answer = (num1 <= 50000 && num1 >= -50000) ? num1 : 0;
    answer -= (num2 <= 50000 && num2 >= -50000) ? num2 : 0;
    return answer;
}