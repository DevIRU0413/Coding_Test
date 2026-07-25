using System;

public class Solution {
    public int solution(int[] array) {
        QuickSort(array, 0, array.Length-1);
        int answer = array[array.Length / 2];
        return answer;
    }
    
    private static void QuickSort(int[] arr, int left, int right) {
        if (left >= right) return;

        int pivotIndex = Partition(arr, left, right);
        QuickSort(arr, left, pivotIndex - 1);
        QuickSort(arr, pivotIndex + 1, right);
    }

    private static int Partition(int[] arr, int left, int right) {
        int pivot = arr[right];
        int i = left;

        for (int j = left; j < right; j++) {
            if (arr[j] < pivot) {
                Swap(arr, i, j);
                i++;
            }
        }

        Swap(arr, i, right);
        return i;
    }

    private static void Swap(int[] arr, int a, int b) {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}