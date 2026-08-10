using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int num = 0;
        foreach(char c in my_string){
            if('0' <= c && '9' >= c){
                num *= 10;
                num += c - '0';
                continue;
            }
            answer += num;
            num = 0;
        }
        
        answer += num;
        return answer;
    }
}