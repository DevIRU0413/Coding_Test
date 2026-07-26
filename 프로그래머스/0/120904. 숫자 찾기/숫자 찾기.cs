using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
        int lt = (int)Math.Log10(num);
        for(int i = lt; i >= 0; i--)
        {
            int pow = (int)Math.Pow(10, i);
            int digit = num / pow % 10;
            if(digit == k){
                answer = lt + 1 - i;
                break;
            }
        }
        return answer;
    }
}