using System;

public class Solution {
    public string solution(string my_string) {
        char[] chars = my_string.ToCharArray();
        for(int i = 0; i < chars.Length; i++){
            if(chars[i] >= 'A' && chars[i] <= 'Z')
                chars[i] = (char)(chars[i] + 32);
        }
        Array.Sort(chars);
        return new string(chars);
    }
}