using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = ((k - n / 10) * 2000) + (n * 12000);
        return answer;
    }
}