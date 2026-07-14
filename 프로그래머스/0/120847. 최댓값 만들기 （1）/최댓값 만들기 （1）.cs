using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int b = 0;
        foreach(int n in numbers)
        {
            if(n > b) { answer = b; b = n;}
            else if(n > answer) { answer = n; }
        }
        return b * answer;
    }
}