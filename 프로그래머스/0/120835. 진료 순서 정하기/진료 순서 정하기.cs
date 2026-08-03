using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer =  new int[emergency.Length];
        int count = 0;
        
        for(int i = 0; i < emergency.Length; i++){
            int num = emergency[i];
            count = 0;
            for(int j = 0; j < emergency.Length; j++){
                if(num < emergency[j])
                    count++;
            }
            answer[i] = count + 1;
        }
        
        return answer;
    }
}