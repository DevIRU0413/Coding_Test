using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int[] count = new int[26];
        
        foreach(char c in s)
            count[c - 'a']++;
        
        for(int i = 0; i < count.Length; i++)
        {
            if(count[i] == 1)
                answer += (char)('a' + i);
        }
        return answer;
    }
}