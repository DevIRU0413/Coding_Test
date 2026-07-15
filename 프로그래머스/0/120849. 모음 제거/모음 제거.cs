using System.Text;

public class Solution {
    public string solution(string my_string) {
        StringBuilder sb = new StringBuilder();

        foreach (char c in my_string) {
            if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                sb.Append(c);
        }

        return sb.ToString();
    }
}