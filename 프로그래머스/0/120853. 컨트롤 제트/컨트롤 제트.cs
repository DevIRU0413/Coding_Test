using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int addNum = 0;
        int num = 0;
        bool minus = false;
        foreach(char c in s){
            if(' ' == c){
                if(minus)
                    num *= -1;
                answer += num;
                addNum = num;
                num = 0;
                minus = false;
                continue;
            }
            else if('Z' == c){
                answer -= addNum;
                continue;
            }
            else if('-' == c){
                minus = true;
                continue;
            }
            
            num *= 10;
            num += c - '0';
        }
        if (minus)
            num *= -1;
        answer += num;
        return answer;
    }
}