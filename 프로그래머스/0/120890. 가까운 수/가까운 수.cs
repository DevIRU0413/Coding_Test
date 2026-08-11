using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        for(int i = 1; i < array.Length; i++){
            int num1 =  Math.Abs(array[i] - n);
            int num2 = Math.Abs(array[answer] - n);
            if(num1 < num2 || 
               num1 == num2 && array[i] < array[answer])
                answer = i;
        }
        return array[answer];
    }
}