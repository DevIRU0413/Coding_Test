using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        for(int i=0;i<cipher.Length+1;i++)
            if(i % code == 0 && i !=0)
                answer += cipher[i-1];
        return answer;
    }
}