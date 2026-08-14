using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[my_str.Length / n + ((my_str.Length % n > 0) ? 1 : 0)];
        for (int i = 0; i < answer.Length; i++)
        {
            int length = Math.Min(n, my_str.Length - i * n);
            answer[i] = my_str.Substring(i * n, length);
        }
        return answer;
    }
}