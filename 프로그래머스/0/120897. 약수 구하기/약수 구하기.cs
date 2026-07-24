using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        int pair = -1;
        
        for(int i = 1; i * i  <= n; i++) 
        {
            if(n % i != 0) 
                continue;
            
            answer.Add(i); 
            pair = n / i;
            if(pair != i) 
                answer.Add(pair);
        }
        answer.Sort();
        return answer.ToArray();
    }
}