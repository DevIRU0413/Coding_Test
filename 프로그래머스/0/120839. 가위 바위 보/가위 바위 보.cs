using System;
using System.Text;

public class Solution {
    public string solution(string rsp) {
        StringBuilder answer = new StringBuilder();
        int[] win = new int[]{5, -1, 0, -1, -1, 2};
        foreach(char c in rsp){
            answer.Append(win[c-'0']);
        }
        return answer.ToString();
    }
}