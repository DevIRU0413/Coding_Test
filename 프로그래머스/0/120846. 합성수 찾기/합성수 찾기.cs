using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int count = 0;
        for(int c = 4; c <= n; c++){
            count = 0;
            for(int i = 2; i * i <= c; i++){
                if(c % i == 0){
                    answer++;
                    break;
                }        
            }
        }
        return answer;
    }
}