using System;

public class Solution {
    public string solution(string my_string) {
        char[] myCharArray = new char[my_string.Length];
        for(int i = 0; i < my_string.Length; i++)
            myCharArray[i] = (char)(my_string[i] ^ 32);
        
        return new string(myCharArray);
    }
}