using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        char[] arr = new char[cipher.Length/code];
        for(int i = code - 1; i < cipher.Length; i += code)
            arr[i / code] = cipher[i];
        
        answer = new string(arr); 
        return answer;
    }
}