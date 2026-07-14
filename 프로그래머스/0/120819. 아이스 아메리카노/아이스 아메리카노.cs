using System;

public class Solution {
    public int[] solution(int money) {
        int buy = 5500;
        int[] answer = new int[] {money/buy, money%buy};
        return answer;
    }
}