using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        int dir = (direction == "left") ? -1 : 1;
        for(int i = 0; i < numbers.Length; i++) {
            int idx = i + dir;
            if(idx < 0)
                idx = numbers.Length - 1;
            else if (idx == numbers.Length)
                idx = 0;
            answer[idx] = numbers[i];
        }
        return answer;
    }
}