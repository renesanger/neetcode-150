public class Solution {
    public bool IsPalindrome(string s) {
        string str = s.ToLower();
        string clean_str = "";
        for(int i=0;i<str.Length;i++){
            if((str[i]>='a' && str[i]<='z') || (str[i]>='0' && str[i]<='9')){
                clean_str += str[i];
            }
        }

        char[] c = clean_str.ToCharArray();
        Array.Reverse(c);
        string result_str = new string(c);

        return result_str == clean_str;
    }
}
