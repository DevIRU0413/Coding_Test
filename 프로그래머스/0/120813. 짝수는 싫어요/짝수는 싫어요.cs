using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[n / 2 + n % 2];
        for(int i = 0; i < answer.Length; i++){
            answer[i] = (i << 1) + 1;
        }
        return answer;
    }
}