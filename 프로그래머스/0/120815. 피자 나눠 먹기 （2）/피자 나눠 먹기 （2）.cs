using System;

public class Solution {
    public int solution(int n) {
        int answer = n;
        int b = 6;

        while (b != 0) {
            int t = n % b;
            n = b;
            b = t;
        }

        return answer / n;
    }
}