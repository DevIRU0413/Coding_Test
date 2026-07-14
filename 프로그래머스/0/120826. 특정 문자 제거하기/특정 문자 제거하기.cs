using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer;
        
        int length = my_string.Length;
        int count = 0;
        char[] strC = new char[length];
        
        for(int i = 0; i < length; i++)
        {
            if(my_string[i] != letter[0])
            {
                strC[count] = my_string[i];
                count++;
            }
        }
        answer = new string(strC, 0, count);
        return answer;
    }
}