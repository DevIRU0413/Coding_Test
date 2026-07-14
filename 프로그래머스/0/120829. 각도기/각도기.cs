using System;

public class Solution {
    public int solution(int angle) {
        int answer = angle / 90 * 2;
        answer += (angle % 90 == 0) ? 0 : 1;
        return answer;
    }
}