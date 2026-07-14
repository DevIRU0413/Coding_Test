using System;

public class Solution {
    public int solution(int[] dot) {
        int x = dot[0] >> 31 & 1;
        int y = dot[1] >> 31 & 1;
        int answer = (1 + x) * (1 - y) + (4 - x) * y;
        return answer;
    }
}