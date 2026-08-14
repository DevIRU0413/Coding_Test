using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = (2 * k - 2) % numbers.Length;
        return numbers[answer];
    }
}