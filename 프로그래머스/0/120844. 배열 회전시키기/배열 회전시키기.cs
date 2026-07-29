using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        int dir = (direction == "left") ? -1 : 1;
        for(int i = 0; i < numbers.Length; i++) {
            int idx = (i + dir + numbers.Length) % numbers.Length;
            answer[idx] = numbers[i];
        }
        return answer;
    }
}