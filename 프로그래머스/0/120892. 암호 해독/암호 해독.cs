using System;
using System.Linq;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = String.Concat(cipher.Where((x, i) => (i + 1) % code == 0));
        return answer;
    }
}
