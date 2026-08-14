using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int sign = 1;
        string[] strArray = my_string.Split(' ');
        for(int i = 0; i < strArray.Length; i++){
            string str = strArray[i];
            if(!int.TryParse(str, out int num))
            {
                sign = (str == "-") ? -1 : 1;
                continue;
            }
            answer += num * sign;
        }
        return answer;
    }
}