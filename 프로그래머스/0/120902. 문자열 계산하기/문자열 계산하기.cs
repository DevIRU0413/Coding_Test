using System;

public class Solution {
    public int solution(string my_string) {
        string[] arr = my_string.Split(' ');
        int answer = int.Parse(arr[0]);
        for(int i = 1; i < arr.Length; i += 2){
            int num = int.Parse(arr[i + 1]);
            if(arr[i] == "+")
                answer += num;
            else
                answer -= num;
        }
        return answer;
    }
}