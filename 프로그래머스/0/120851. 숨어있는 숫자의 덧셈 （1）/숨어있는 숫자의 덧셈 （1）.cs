using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int zero = (int)'0';
        int nine = (int)'9';
        foreach(char c in my_string)
        {
            if(zero <= c && c <= nine)
                answer += (int)c - zero;
        }
        return answer;
    }
}