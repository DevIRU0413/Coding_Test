using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int b = 0;
        foreach(int n in sides)
        {
            answer += n;
            if(b < n) { b = n; }
        }
        return (answer - b > b) ? 1 : 2;
    }
}