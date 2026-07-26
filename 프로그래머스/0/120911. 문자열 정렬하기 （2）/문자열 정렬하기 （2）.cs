using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
        int[] count = new int[26];
        foreach (char c in my_string)
        {
            char lower = c <= 'Z' ? (char)(c + 32) : c;
            count[lower - 'a']++;
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 26; i++)
        {
            while (count[i]-- > 0)
                sb.Append((char)('a' + i));
        }
        return sb.ToString();
    }
}