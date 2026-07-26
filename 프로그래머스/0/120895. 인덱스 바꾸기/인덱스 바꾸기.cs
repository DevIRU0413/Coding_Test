using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        char[] answer = my_string.ToCharArray();
        char c = answer[num1];
        answer[num1] = answer[num2];
        answer[num2] = c;
        return new string(answer);
    }
}