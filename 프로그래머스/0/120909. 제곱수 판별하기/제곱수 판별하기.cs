using System;

public class Solution {
    public int solution(int n) {
        return n % Math.Sqrt(n) == 0 ? 1 : 2;
    }
}