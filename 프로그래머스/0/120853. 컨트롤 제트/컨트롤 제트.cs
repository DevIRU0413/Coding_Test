using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int num = 0;
        foreach(string c in s.Split(' '))
        {
            if(c == "Z"){
                answer -= num;
                continue;
            }
            num = int.Parse(c);
            answer += num;
        }
        return answer;
    }
}