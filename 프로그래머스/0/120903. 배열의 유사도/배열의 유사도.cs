using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        
        if (s1.Length > s2.Length) 
        {
            var tmp = s1; 
            s1 = s2; 
            s2 = tmp;
        }

        for (int i = 0; i < s1.Length; i++) 
        {
            if(!s2.Contains(s1[i])) continue;
            for (int j = 0; j < s2.Length; j++) {
                if (s1[i] == s2[j]) {
                    answer++;
                    break; 
                }
            }
        }
        return answer;
    }
}