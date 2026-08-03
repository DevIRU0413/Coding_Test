using System;

public class Solution {
    public int solution(string before, string after) {
        int[] counting = new int[26];
        for(int i = 0; i < before.Length; i++){
            int idx = before[i] - 'a';
            counting[idx]++;
        }
        
        for(int i = 0; i < after.Length; i++){
            int idx = after[i] - 'a';
            counting[idx]--;
        }
        
        for(int i = 0; i < counting.Length; i++){
            if(counting[i] != 0)
                return 0;
        }
        
        return 1;
    }
}