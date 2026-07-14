using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int length = num_list.Length - 1;
        int half = length / 2;
        for(int i = 0; i < half; i++)
        {
            int idx = length - i;
            
            int temp = num_list[idx];
            num_list[idx] = num_list[i];
            num_list[i] = temp;
        }
        return num_list;
    }
}