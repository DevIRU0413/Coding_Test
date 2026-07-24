using System;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int count = 0;
        foreach (var x in numlist)
            if (x % n == 0) 
                count++;

        int[] answer = new int[count];
        int idx = 0;
        foreach (var x in numlist)
            if (x % n == 0) 
                answer[idx++] = x;
        
        return answer;
    }
}