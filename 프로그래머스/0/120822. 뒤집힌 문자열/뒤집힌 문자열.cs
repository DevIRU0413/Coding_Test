using System;

public class Solution {
    public string solution(string my_string) {
        char[] answer = my_string.ToCharArray();
        int length = answer.Length - 1;
        int half = answer.Length / 2;
        for(int i = 0; i < half; i++)
        {
            int idx = length - i;
            
            char temp = answer[idx];
            answer[idx] = answer[i];
            answer[i] = temp;
        }
        return new string(answer);
    }
}