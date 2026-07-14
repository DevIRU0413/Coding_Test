using System;

public class Solution {
    public string solution(string my_string, int n) {
        char[] c = new char[my_string.Length * n];
        for(int i = 0; i < my_string.Length; i++)
        {
            char cc = my_string[i];
            for(int j = i * n; j < i * n + n; j++)
                c[j] = cc;
        }
        string answer = new string(c);
        return answer;
    }
}