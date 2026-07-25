using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        int ns = (int)Math.Log10(order) + 1;
        for(int i = ns - 1; i >= 0; i--){
            int c = (int)Math.Pow(10, i);
            int n = order / c % 10;
            if(n != 0 && n % 3 == 0)
                answer++;
        }
        return answer;
    }
}