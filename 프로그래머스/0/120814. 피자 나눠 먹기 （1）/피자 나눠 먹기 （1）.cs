using System;

public class Solution {
    public int solution(int n) {
        int a = 7;
        return n / a + (n % a > 0 ? 1 : 0);
    }
}